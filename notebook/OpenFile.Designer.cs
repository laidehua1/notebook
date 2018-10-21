namespace notebook
{
    partial class OpenFile
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
            this.comboBox_Date = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_NoteName = new System.Windows.Forms.ComboBox();
            this.button_open = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期";
            // 
            // comboBox_Date
            // 
            this.comboBox_Date.FormattingEnabled = true;
            this.comboBox_Date.Location = new System.Drawing.Point(60, 10);
            this.comboBox_Date.Name = "comboBox_Date";
            this.comboBox_Date.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Date.TabIndex = 1;
            this.comboBox_Date.SelectedIndexChanged += new System.EventHandler(this.comboBox_Date_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "日记名";
            // 
            // comboBox_NoteName
            // 
            this.comboBox_NoteName.FormattingEnabled = true;
            this.comboBox_NoteName.Location = new System.Drawing.Point(60, 36);
            this.comboBox_NoteName.Name = "comboBox_NoteName";
            this.comboBox_NoteName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_NoteName.TabIndex = 3;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(197, 8);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 4;
            this.button_open.Text = "打开";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(197, 37);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "删除";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // OpenFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 63);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.comboBox_NoteName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Date);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenFile";
            this.Text = "打开日记";
            this.Load += new System.EventHandler(this.OpenFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_NoteName;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_Delete;
    }
}