namespace notebook
{
    partial class Tool
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_font = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.pictureBox_center = new System.Windows.Forms.PictureBox();
            this.pictureBox_right = new System.Windows.Forms.PictureBox();
            this.pictureBox_left = new System.Windows.Forms.PictureBox();
            this.button_Addpicture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_center)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "字体";
            // 
            // comboBox_font
            // 
            this.comboBox_font.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_font.FormattingEnabled = true;
            this.comboBox_font.Location = new System.Drawing.Point(45, 6);
            this.comboBox_font.Name = "comboBox_font";
            this.comboBox_font.Size = new System.Drawing.Size(50, 20);
            this.comboBox_font.TabIndex = 1;
            this.comboBox_font.SelectedIndexChanged += new System.EventHandler(this.comboBox_font_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "字体大小";
            // 
            // comboBox_size
            // 
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Location = new System.Drawing.Point(160, 6);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(50, 20);
            this.comboBox_size.TabIndex = 3;
            this.comboBox_size.SelectedIndexChanged += new System.EventHandler(this.comboBox_size_SelectedIndexChanged);
            // 
            // pictureBox_center
            // 
            this.pictureBox_center.BackgroundImage = global::notebook.Properties.Resources.P_居中对齐;
            this.pictureBox_center.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_center.Location = new System.Drawing.Point(117, 32);
            this.pictureBox_center.Name = "pictureBox_center";
            this.pictureBox_center.Size = new System.Drawing.Size(25, 21);
            this.pictureBox_center.TabIndex = 6;
            this.pictureBox_center.TabStop = false;
            this.pictureBox_center.Click += new System.EventHandler(this.pictureBox_center_Click);
            // 
            // pictureBox_right
            // 
            this.pictureBox_right.BackgroundImage = global::notebook.Properties.Resources.P_右对齐;
            this.pictureBox_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_right.Location = new System.Drawing.Point(148, 32);
            this.pictureBox_right.Name = "pictureBox_right";
            this.pictureBox_right.Size = new System.Drawing.Size(25, 21);
            this.pictureBox_right.TabIndex = 7;
            this.pictureBox_right.TabStop = false;
            this.pictureBox_right.Click += new System.EventHandler(this.pictureBox_right_Click);
            // 
            // pictureBox_left
            // 
            this.pictureBox_left.BackgroundImage = global::notebook.Properties.Resources.P_左对齐;
            this.pictureBox_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_left.Location = new System.Drawing.Point(179, 32);
            this.pictureBox_left.Name = "pictureBox_left";
            this.pictureBox_left.Size = new System.Drawing.Size(25, 21);
            this.pictureBox_left.TabIndex = 8;
            this.pictureBox_left.TabStop = false;
            this.pictureBox_left.Click += new System.EventHandler(this.pictureBox_left_Click);
            // 
            // button_Addpicture
            // 
            this.button_Addpicture.Location = new System.Drawing.Point(12, 32);
            this.button_Addpicture.Name = "button_Addpicture";
            this.button_Addpicture.Size = new System.Drawing.Size(71, 23);
            this.button_Addpicture.TabIndex = 9;
            this.button_Addpicture.Text = "添加图片";
            this.button_Addpicture.UseVisualStyleBackColor = true;
            this.button_Addpicture.Click += new System.EventHandler(this.button_Addpicture_Click);
            // 
            // Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 54);
            this.Controls.Add(this.button_Addpicture);
            this.Controls.Add(this.pictureBox_left);
            this.Controls.Add(this.pictureBox_right);
            this.Controls.Add(this.pictureBox_center);
            this.Controls.Add(this.comboBox_size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_font);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tool";
            this.Text = "工具栏";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tool_FormClosed);
            this.Load += new System.EventHandler(this.Tool_Load);
            this.Shown += new System.EventHandler(this.Tool_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_center)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_left)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_font;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.PictureBox pictureBox_center;
        private System.Windows.Forms.PictureBox pictureBox_right;
        private System.Windows.Forms.PictureBox pictureBox_left;
        private System.Windows.Forms.Button button_Addpicture;
    }
}