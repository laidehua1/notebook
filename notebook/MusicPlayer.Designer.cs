namespace notebook
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.pictureBox_title = new System.Windows.Forms.PictureBox();
            this.pictureBox_min = new System.Windows.Forms.PictureBox();
            this.pictureBox_close = new System.Windows.Forms.PictureBox();
            this.label_jindu = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.hScrollBar_进度 = new System.Windows.Forms.HScrollBar();
            this.pictureBox_play = new System.Windows.Forms.PictureBox();
            this.pictureBox_parse = new System.Windows.Forms.PictureBox();
            this.pictureBox_stop = new System.Windows.Forms.PictureBox();
            this.hScrollBar_vo = new System.Windows.Forms.HScrollBar();
            this.pictureBox_open = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_parse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_title
            // 
            this.pictureBox_title.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_title.Location = new System.Drawing.Point(3, 2);
            this.pictureBox_title.Name = "pictureBox_title";
            this.pictureBox_title.Size = new System.Drawing.Size(244, 20);
            this.pictureBox_title.TabIndex = 0;
            this.pictureBox_title.TabStop = false;
            this.pictureBox_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_title_MouseDown);
            this.pictureBox_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_title_MouseMove);
            this.pictureBox_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_title_MouseUp);
            // 
            // pictureBox_min
            // 
            this.pictureBox_min.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_min.Location = new System.Drawing.Point(245, 2);
            this.pictureBox_min.Name = "pictureBox_min";
            this.pictureBox_min.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_min.TabIndex = 2;
            this.pictureBox_min.TabStop = false;
            this.pictureBox_min.Click += new System.EventHandler(this.pictureBox_min_Click);
            // 
            // pictureBox_close
            // 
            this.pictureBox_close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_close.Location = new System.Drawing.Point(265, 2);
            this.pictureBox_close.Name = "pictureBox_close";
            this.pictureBox_close.Size = new System.Drawing.Size(20, 20);
            this.pictureBox_close.TabIndex = 3;
            this.pictureBox_close.TabStop = false;
            this.pictureBox_close.Click += new System.EventHandler(this.pictureBox_close_Click);
            // 
            // label_jindu
            // 
            this.label_jindu.AutoSize = true;
            this.label_jindu.BackColor = System.Drawing.Color.Transparent;
            this.label_jindu.Location = new System.Drawing.Point(13, 77);
            this.label_jindu.Name = "label_jindu";
            this.label_jindu.Size = new System.Drawing.Size(0, 12);
            this.label_jindu.TabIndex = 4;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Location = new System.Drawing.Point(154, 77);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 12);
            this.label_name.TabIndex = 5;
            // 
            // hScrollBar_进度
            // 
            this.hScrollBar_进度.Location = new System.Drawing.Point(13, 93);
            this.hScrollBar_进度.Name = "hScrollBar_进度";
            this.hScrollBar_进度.Size = new System.Drawing.Size(269, 15);
            this.hScrollBar_进度.TabIndex = 6;
            this.hScrollBar_进度.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_进度_Scroll);
            // 
            // pictureBox_play
            // 
            this.pictureBox_play.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_play.Location = new System.Drawing.Point(13, 111);
            this.pictureBox_play.Name = "pictureBox_play";
            this.pictureBox_play.Size = new System.Drawing.Size(28, 25);
            this.pictureBox_play.TabIndex = 7;
            this.pictureBox_play.TabStop = false;
            this.pictureBox_play.Click += new System.EventHandler(this.pictureBox_play_Click);
            this.pictureBox_play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_play_MouseDown);
            this.pictureBox_play.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_play_MouseUp);
            // 
            // pictureBox_parse
            // 
            this.pictureBox_parse.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_parse.Location = new System.Drawing.Point(41, 111);
            this.pictureBox_parse.Name = "pictureBox_parse";
            this.pictureBox_parse.Size = new System.Drawing.Size(28, 25);
            this.pictureBox_parse.TabIndex = 8;
            this.pictureBox_parse.TabStop = false;
            this.pictureBox_parse.Click += new System.EventHandler(this.pictureBox_parse_Click);
            this.pictureBox_parse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_parse_MouseDown);
            this.pictureBox_parse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_parse_MouseUp);
            // 
            // pictureBox_stop
            // 
            this.pictureBox_stop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_stop.Location = new System.Drawing.Point(69, 111);
            this.pictureBox_stop.Name = "pictureBox_stop";
            this.pictureBox_stop.Size = new System.Drawing.Size(28, 25);
            this.pictureBox_stop.TabIndex = 9;
            this.pictureBox_stop.TabStop = false;
            this.pictureBox_stop.Click += new System.EventHandler(this.pictureBox_stop_Click);
            this.pictureBox_stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_stop_MouseDown);
            this.pictureBox_stop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_stop_MouseUp);
            // 
            // hScrollBar_vo
            // 
            this.hScrollBar_vo.Location = new System.Drawing.Point(117, 121);
            this.hScrollBar_vo.Name = "hScrollBar_vo";
            this.hScrollBar_vo.Size = new System.Drawing.Size(84, 15);
            this.hScrollBar_vo.TabIndex = 10;
            this.hScrollBar_vo.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_vo_Scroll);
            // 
            // pictureBox_open
            // 
            this.pictureBox_open.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_open.Location = new System.Drawing.Point(245, 111);
            this.pictureBox_open.Name = "pictureBox_open";
            this.pictureBox_open.Size = new System.Drawing.Size(28, 25);
            this.pictureBox_open.TabIndex = 11;
            this.pictureBox_open.TabStop = false;
            this.pictureBox_open.Click += new System.EventHandler(this.pictureBox_open_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(213, 121);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 15);
            this.axWindowsMediaPlayer1.TabIndex = 12;
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::notebook.Properties.Resources.player11;
            this.ClientSize = new System.Drawing.Size(291, 148);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.pictureBox_open);
            this.Controls.Add(this.hScrollBar_vo);
            this.Controls.Add(this.pictureBox_stop);
            this.Controls.Add(this.pictureBox_parse);
            this.Controls.Add(this.pictureBox_play);
            this.Controls.Add(this.hScrollBar_进度);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_jindu);
            this.Controls.Add(this.pictureBox_close);
            this.Controls.Add(this.pictureBox_min);
            this.Controls.Add(this.pictureBox_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MusicPlayer_FormClosed);
            this.Load += new System.EventHandler(this.MusicPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_parse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_title;
        private System.Windows.Forms.PictureBox pictureBox_min;
        private System.Windows.Forms.PictureBox pictureBox_close;
        private System.Windows.Forms.Label label_jindu;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.HScrollBar hScrollBar_进度;
        private System.Windows.Forms.PictureBox pictureBox_play;
        private System.Windows.Forms.PictureBox pictureBox_parse;
        private System.Windows.Forms.PictureBox pictureBox_stop;
        private System.Windows.Forms.HScrollBar hScrollBar_vo;
        private System.Windows.Forms.PictureBox pictureBox_open;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;

    }
}