namespace notebook
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Account = new System.Windows.Forms.Label();
            this.label_PassWord = new System.Windows.Forms.Label();
            this.textBox_PassWord = new System.Windows.Forms.TextBox();
            this.linkLabe1 = new System.Windows.Forms.LinkLabel();
            this.checkBox_remberPW = new System.Windows.Forms.CheckBox();
            this.checkBox_AutoLogin = new System.Windows.Forms.CheckBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.comboBox_Account = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_eye = new System.Windows.Forms.PictureBox();
            this.toolTip_p_eye = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Account
            // 
            this.label_Account.AutoSize = true;
            this.label_Account.Location = new System.Drawing.Point(12, 156);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(29, 12);
            this.label_Account.TabIndex = 1;
            this.label_Account.Text = "账号";
            // 
            // label_PassWord
            // 
            this.label_PassWord.AutoSize = true;
            this.label_PassWord.Location = new System.Drawing.Point(12, 183);
            this.label_PassWord.Name = "label_PassWord";
            this.label_PassWord.Size = new System.Drawing.Size(29, 12);
            this.label_PassWord.TabIndex = 2;
            this.label_PassWord.Text = "密码";
            // 
            // textBox_PassWord
            // 
            this.textBox_PassWord.Location = new System.Drawing.Point(47, 180);
            this.textBox_PassWord.Name = "textBox_PassWord";
            this.textBox_PassWord.Size = new System.Drawing.Size(125, 21);
            this.textBox_PassWord.TabIndex = 4;
            // 
            // linkLabe1
            // 
            this.linkLabe1.AutoSize = true;
            this.linkLabe1.Location = new System.Drawing.Point(203, 156);
            this.linkLabe1.Name = "linkLabe1";
            this.linkLabe1.Size = new System.Drawing.Size(53, 12);
            this.linkLabe1.TabIndex = 5;
            this.linkLabe1.TabStop = true;
            this.linkLabe1.Text = "注册账号";
            this.linkLabe1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabe1_LinkClicked);
            // 
            // checkBox_remberPW
            // 
            this.checkBox_remberPW.AutoSize = true;
            this.checkBox_remberPW.Location = new System.Drawing.Point(47, 207);
            this.checkBox_remberPW.Name = "checkBox_remberPW";
            this.checkBox_remberPW.Size = new System.Drawing.Size(72, 16);
            this.checkBox_remberPW.TabIndex = 6;
            this.checkBox_remberPW.Text = "记住密码";
            this.checkBox_remberPW.UseVisualStyleBackColor = true;
            this.checkBox_remberPW.CheckedChanged += new System.EventHandler(this.checkBox_remberPW_CheckedChanged);
            // 
            // checkBox_AutoLogin
            // 
            this.checkBox_AutoLogin.AutoSize = true;
            this.checkBox_AutoLogin.Location = new System.Drawing.Point(125, 207);
            this.checkBox_AutoLogin.Name = "checkBox_AutoLogin";
            this.checkBox_AutoLogin.Size = new System.Drawing.Size(72, 16);
            this.checkBox_AutoLogin.TabIndex = 7;
            this.checkBox_AutoLogin.Text = "自动登陆";
            this.checkBox_AutoLogin.UseVisualStyleBackColor = true;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(29, 229);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(191, 31);
            this.button_Login.TabIndex = 8;
            this.button_Login.Text = "登陆";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // comboBox_Account
            // 
            this.comboBox_Account.FormattingEnabled = true;
            this.comboBox_Account.Location = new System.Drawing.Point(47, 154);
            this.comboBox_Account.Name = "comboBox_Account";
            this.comboBox_Account.Size = new System.Drawing.Size(150, 20);
            this.comboBox_Account.TabIndex = 9;
            this.comboBox_Account.SelectedIndexChanged += new System.EventHandler(this.comboBox_Account_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox_eye
            // 
            this.pictureBox_eye.Location = new System.Drawing.Point(169, 180);
            this.pictureBox_eye.Name = "pictureBox_eye";
            this.pictureBox_eye.Size = new System.Drawing.Size(28, 20);
            this.pictureBox_eye.TabIndex = 10;
            this.pictureBox_eye.TabStop = false;
            this.pictureBox_eye.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_eye_MouseDown);
            this.pictureBox_eye.MouseEnter += new System.EventHandler(this.pictureBox_eye_MouseEnter);
            this.pictureBox_eye.MouseLeave += new System.EventHandler(this.pictureBox_eye_MouseLeave);
            this.pictureBox_eye.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_eye_MouseUp);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(264, 357);
            this.Controls.Add(this.pictureBox_eye);
            this.Controls.Add(this.comboBox_Account);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.checkBox_AutoLogin);
            this.Controls.Add(this.checkBox_remberPW);
            this.Controls.Add(this.linkLabe1);
            this.Controls.Add(this.textBox_PassWord);
            this.Controls.Add(this.label_PassWord);
            this.Controls.Add(this.label_Account);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.登陆_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.Label label_PassWord;
        private System.Windows.Forms.TextBox textBox_PassWord;
        private System.Windows.Forms.LinkLabel linkLabe1;
        private System.Windows.Forms.CheckBox checkBox_remberPW;
        private System.Windows.Forms.CheckBox checkBox_AutoLogin;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.ComboBox comboBox_Account;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox_eye;
        private System.Windows.Forms.ToolTip toolTip_p_eye;
    }
}

