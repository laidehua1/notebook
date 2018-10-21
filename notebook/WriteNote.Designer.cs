namespace notebook
{
    partial class WriteNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteNote));
            this.pictureBox_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.pictureBox_title = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_weather = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_mood = new System.Windows.Forms.ComboBox();
            this.pictureBox_save = new System.Windows.Forms.PictureBox();
            this.pictureBox_open = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.linkLabel_logout = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_min
            // 
            this.pictureBox_min.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_min.BackgroundImage = global::notebook.Properties.Resources.P_min;
            this.pictureBox_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_min.Location = new System.Drawing.Point(495, 12);
            this.pictureBox_min.Name = "pictureBox_min";
            this.pictureBox_min.Size = new System.Drawing.Size(25, 22);
            this.pictureBox_min.TabIndex = 4;
            this.pictureBox_min.TabStop = false;
            this.pictureBox_min.Click += new System.EventHandler(this.pictureBox_min_Click);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_close.BackgroundImage = global::notebook.Properties.Resources.P_close;
            this.pictureBox_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_close.Location = new System.Drawing.Point(526, 12);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(25, 22);
            this.pictureBox_close.TabIndex = 5;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // pictureBox_title
            // 
            this.pictureBox_title.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_title.Location = new System.Drawing.Point(5, 4);
            this.pictureBox_title.Name = "pictureBox_title";
            this.pictureBox_title.Size = new System.Drawing.Size(422, 30);
            this.pictureBox_title.TabIndex = 6;
            this.pictureBox_title.TabStop = false;
            this.pictureBox_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_title_MouseDown);
            this.pictureBox_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_title_MouseMove);
            this.pictureBox_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_title_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(567, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "日记本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(567, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "日程管理";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(578, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "音乐播放";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(178, 101);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 302);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            this.richTextBox1.Leave += new System.EventHandler(this.richTextBox1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(176, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "标题";
            // 
            // textBox_title
            // 
            this.textBox_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_title.Location = new System.Drawing.Point(211, 46);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(309, 14);
            this.textBox_title.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(176, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "日期";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(338, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "天气";
            // 
            // comboBox_weather
            // 
            this.comboBox_weather.FormattingEnabled = true;
            this.comboBox_weather.Location = new System.Drawing.Point(373, 70);
            this.comboBox_weather.Name = "comboBox_weather";
            this.comboBox_weather.Size = new System.Drawing.Size(54, 20);
            this.comboBox_weather.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(433, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "心情";
            // 
            // comboBox_mood
            // 
            this.comboBox_mood.FormattingEnabled = true;
            this.comboBox_mood.Location = new System.Drawing.Point(468, 70);
            this.comboBox_mood.Name = "comboBox_mood";
            this.comboBox_mood.Size = new System.Drawing.Size(52, 20);
            this.comboBox_mood.TabIndex = 18;
            // 
            // pictureBox_save
            // 
            this.pictureBox_save.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_save.BackgroundImage = global::notebook.Properties.Resources.P_saveFail;
            this.pictureBox_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_save.Location = new System.Drawing.Point(464, 12);
            this.pictureBox_save.Name = "pictureBox_save";
            this.pictureBox_save.Size = new System.Drawing.Size(25, 22);
            this.pictureBox_save.TabIndex = 19;
            this.pictureBox_save.TabStop = false;
            this.pictureBox_save.Click += new System.EventHandler(this.pictureBox_save_Click);
            // 
            // pictureBox_open
            // 
            this.pictureBox_open.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_open.BackgroundImage = global::notebook.Properties.Resources.P_openFile;
            this.pictureBox_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_open.Location = new System.Drawing.Point(433, 12);
            this.pictureBox_open.Name = "pictureBox_open";
            this.pictureBox_open.Size = new System.Drawing.Size(25, 22);
            this.pictureBox_open.TabIndex = 20;
            this.pictureBox_open.TabStop = false;
            this.pictureBox_open.Click += new System.EventHandler(this.pictureBox_open_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::notebook.Properties.Resources.P_UserIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 61);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(79, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "欢迎您，";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.BackColor = System.Drawing.Color.Transparent;
            this.label_UserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_UserName.Location = new System.Drawing.Point(79, 70);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(37, 14);
            this.label_UserName.TabIndex = 23;
            this.label_UserName.Text = "用户";
            // 
            // linkLabel_logout
            // 
            this.linkLabel_logout.AutoSize = true;
            this.linkLabel_logout.Location = new System.Drawing.Point(79, 88);
            this.linkLabel_logout.Name = "linkLabel_logout";
            this.linkLabel_logout.Size = new System.Drawing.Size(29, 12);
            this.linkLabel_logout.TabIndex = 24;
            this.linkLabel_logout.TabStop = true;
            this.linkLabel_logout.Text = "注销";
            this.linkLabel_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_logout_LinkClicked);
            // 
            // WriteNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(643, 442);
            this.Controls.Add(this.linkLabel_logout);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_open);
            this.Controls.Add(this.pictureBox_save);
            this.Controls.Add(this.comboBox_mood);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_weather);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_title);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.pictureBox_min);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WriteNote";
            this.Text = "PageTurning";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WriteNote_FormClosed);
            this.Load += new System.EventHandler(this.WriteNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_min;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.PictureBox pictureBox_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_weather;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_mood;
        private System.Windows.Forms.PictureBox pictureBox_save;
        private System.Windows.Forms.PictureBox pictureBox_open;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.LinkLabel linkLabel_logout;
    }
}