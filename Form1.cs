using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//비번 - 김민후개새끼
namespace Cryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            Encrypt(PathBox.Text);
        }

        public void Encrypt(string Path)
        {
            using (RijndaelManaged Aes = new RijndaelManaged())
            {
                Rfc2898DeriveBytes key = MakeKey(Path);
                Rfc2898DeriveBytes vector = MakeVector("벡터값");

                Aes.BlockSize = 128;
                Aes.KeySize = 256;
                Aes.Mode = CipherMode.CBC;
                Aes.Padding = PaddingMode.PKCS7;
                Aes.Key = key.GetBytes(32);
                Aes.IV = vector.GetBytes(16);

                ICryptoTransform Cryptor = Aes.CreateEncryptor(Aes.Key, Aes.IV);
                foreach (var item in FileSearch(Path))
                {
                    Log(item.FullName + " 암호화 시작");
                    using (MemoryStream Ms = new MemoryStream())
                    {
                        using (CryptoStream Cs = new CryptoStream(Ms, Cryptor, CryptoStreamMode.Write))
                        {
                            byte[] inputBytes = File.ReadAllBytes(item.FullName);
                            Cs.Write(inputBytes, 0, inputBytes.Length);
                        }
                        File.WriteAllBytes(item.FullName + ".enc", Ms.ToArray());
                        File.Delete(item.FullName);
                    }
                    Log(item.FullName + "암호화 완료");
                }
            }
        }

        public void Decrypt(string Path)
        {
            using (RijndaelManaged Aes = new RijndaelManaged())
            {
                Rfc2898DeriveBytes key = MakeKey(Path);
                Rfc2898DeriveBytes vector = MakeVector("벡터값");

                Aes.BlockSize = 128;
                Aes.KeySize = 256;
                Aes.Mode = CipherMode.CBC;
                Aes.Padding = PaddingMode.PKCS7;
                Aes.Key = key.GetBytes(32);
                Aes.IV = vector.GetBytes(16);

                ICryptoTransform Cryptor = Aes.CreateDecryptor(Aes.Key, Aes.IV);
                foreach(var item in FileSearch(Path))
                {
                    Log(item.FullName + "복호화 시작");
                    using (MemoryStream Ms = new MemoryStream())
                    {
                        using (CryptoStream Cs = new CryptoStream(Ms, Cryptor, CryptoStreamMode.Write))
                        {
                            byte[] inputBytes = File.ReadAllBytes(item.FullName);
                            Cs.Write(inputBytes, 0, inputBytes.Length);
                        }
                        File.WriteAllBytes(item.FullName.Substring(0, item.FullName.Length - 4), Ms.ToArray());
                        File.Delete(item.FullName);
                    }
                    Log(item.FullName + "복호화 완료");
                }
            }
        }

        public void Log(string Msg)
        {
            Invoke(new Action(delegate ()
            {
                LogBox.AppendText(Msg + Environment.NewLine);
            }));
        }

        public List<FileInfo> FileSearch(string Path, List<FileInfo> Temp = null)
        {
            if (Temp == null) Temp = new List<FileInfo>();
            DirectoryInfo Di = new DirectoryInfo(Path);
            foreach (var s in Directory.GetDirectories(Path)) FileSearch(s, Temp);
            foreach (var item in Di.GetFiles()) Temp.Add(item);
            return Temp;
        }

        public Rfc2898DeriveBytes MakeKey(string Key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(Key);
            byte[] saltBytes = SHA512.Create().ComputeHash(keyBytes);
            Rfc2898DeriveBytes result = new Rfc2898DeriveBytes(keyBytes, saltBytes, 65536);
            return result;
        }

        public Rfc2898DeriveBytes MakeVector(string Vector)
        {
            byte[] vectorBytes = Encoding.UTF8.GetBytes(Vector);
            byte[] saltBytes = SHA512.Create().ComputeHash(vectorBytes);
            Rfc2898DeriveBytes result = new Rfc2898DeriveBytes(vectorBytes, saltBytes, 65536);
            return result;
        }

        private void Btn_Start_Dec_Click(object sender, EventArgs e)
        {
            Decrypt(PathBox.Text);
        }
    }
}
