namespace notebook
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_passWord = new System.Windows.Forms.TextBox();
            this.textBox_RePassWord = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.linkLabel_returnLogin = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox_password2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_password1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.toolTip_error = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_password2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_password1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "输入密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(67, 18);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(124, 21);
            this.textBox_User.TabIndex = 3;
            this.textBox_User.Validated += new System.EventHandler(this.textBox_User_Validated);
            // 
            // textBox_passWord
            // 
            this.textBox_passWord.Location = new System.Drawing.Point(67, 60);
            this.textBox_passWord.Name = "textBox_passWord";
            this.textBox_passWord.Size = new System.Drawing.Size(124, 21);
            this.textBox_passWord.TabIndex = 4;
            this.textBox_passWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_passWord_KeyPress);
            this.textBox_passWord.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_passWord_Validating);
            // 
            // textBox_RePassWord
            // 
            this.textBox_RePassWord.Location = new System.Drawing.Point(67, 98);
            this.textBox_RePassWord.Name = "textBox_RePassWord";
            this.textBox_RePassWord.Size = new System.Drawing.Size(124, 21);
            this.textBox_RePassWord.TabIndex = 5;
            this.textBox_RePassWord.Validated += new System.EventHandler(this.textBox_RePassWord_Validated);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(36, 142);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(155, 26);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "注册";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // linkLabel_returnLogin
            // 
            this.linkLabel_returnLogin.AutoSize = true;
            this.linkLabel_returnLogin.Location = new System.Drawing.Point(65, 180);
            this.linkLabel_returnLogin.Name = "linkLabel_returnLogin";
            this.linkLabel_returnLogin.Size = new System.Drawing.Size(89, 12);
            this.linkLabel_returnLogin.TabIndex = 7;
            this.linkLabel_returnLogin.TabStop = true;
            this.linkLabel_returnLogin.Text = "用已有账号登陆";
            this.linkLabel_returnLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_returnLogin_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_password2);
            this.groupBox1.Controls.Add(this.pictureBox_password1);
            this.groupBox1.Controls.Add(this.pictureBox_User);
            this.groupBox1.Controls.Add(this.linkLabel_returnLogin);
            this.groupBox1.Controls.Add(this.button_register);
            this.groupBox1.Controls.Add(this.textBox_RePassWord);
            this.groupBox1.Controls.Add(this.textBox_passWord);
            this.groupBox1.Controls.Add(this.textBox_User);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox_password2
            // 
            this.pictureBox_password2.Location = new System.Drawing.Point(189, 98);
            this.pictureBox_password2.Name = "pictureBox_password2";
            this.pictureBox_password2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox_password2.TabIndex = 10;
            this.pictureBox_password2.TabStop = false;
            // 
            // pictureBox_password1
            // 
            this.pictureBox_password1.Location = new System.Drawing.Point(189, 60);
            this.pictureBox_password1.Name = "pictureBox_password1";
            this.pictureBox_password1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox_password1.TabIndex = 9;
            this.pictureBox_password1.TabStop = false;
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Location = new System.Drawing.Point(189, 18);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(24, 21);
            this.pictureBox_User.TabIndex = 8;
            this.pictureBox_User.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 361);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "注册";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_password2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_password1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_passWord;
        private System.Windows.Forms.TextBox textBox_RePassWord;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.LinkLabel linkLabel_returnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.ToolTip toolTip_error;
        private System.Windows.Forms.PictureBox pictureBox_password2;
        private System.Windows.Forms.PictureBox pictureBox_password1;

    }
}