namespace Cryptor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Start = new System.Windows.Forms.Button();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.LogBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Start_Dec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(687, 13);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(101, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "암호화 시작";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // PathBox
            // 
            this.PathBox.Location = new System.Drawing.Point(107, 15);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(574, 21);
            this.PathBox.TabIndex = 1;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(13, 67);
            this.LogBox.Multiline = true;
            this.LogBox.Name = "LogBox";
            this.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(775, 371);
            this.LogBox.TabIndex = 2;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(107, 40);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(574, 21);
            this.PassBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "경로:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호:";
            // 
            // btn_Start_Dec
            // 
            this.btn_Start_Dec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Start_Dec.Location = new System.Drawing.Point(687, 38);
            this.btn_Start_Dec.Name = "btn_Start_Dec";
            this.btn_Start_Dec.Size = new System.Drawing.Size(101, 23);
            this.btn_Start_Dec.TabIndex = 6;
            this.btn_Start_Dec.Text = "복호화 시작";
            this.btn_Start_Dec.UseVisualStyleBackColor = true;
            this.btn_Start_Dec.Click += new System.EventHandler(this.Btn_Start_Dec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Start_Dec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "암호화";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.TextBox LogBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Start_Dec;
    }
}

