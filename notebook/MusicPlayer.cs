using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public partial class MusicPlayer : Form
    {
        private Point mouseOffset;//记录鼠标坐标
        private bool isMouseDown = false;//是否按下鼠标
        private bool havefile=false;


        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void MusicPlayer_Load(object sender, EventArgs e)
        {
            pictureBox_play.Image = Properties.Resources.播放按钮;
            pictureBox_parse.Image = Properties.Resources.暂停按钮;
            pictureBox_stop.Image = Properties.Resources.停止按钮;
            pictureBox_open.Image = Properties.Resources.文件夹打开;

            timer1.Enabled = true;
        }

        private void pictureBox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox_title_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void pictureBox_title_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void pictureBox_title_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void pictureBox_play_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "*.mp3|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                havefile = true;
                axWindowsMediaPlayer1.URL = ofd.FileName;
                label_name.Text =  axWindowsMediaPlayer1.currentMedia.getItemInfo("Title");
            }
        }

        private void pictureBox_parse_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox_stop_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_jindu.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            if (havefile)
            {
                hScrollBar_进度.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                hScrollBar_进度.Minimum = 0;
                hScrollBar_进度.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                hScrollBar_vo.Value = axWindowsMediaPlayer1.settings.volume;
            }
        }

        private void hScrollBar_进度_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = e.NewValue;
        }

        private void hScrollBar_vo_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = e.NewValue;
        }

        private void MusicPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void pictureBox_play_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_play.Image = Properties.Resources.播放按钮变;
        }

        private void pictureBox_play_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_play.Image = Properties.Resources.播放按钮;
        }

        private void pictureBox_parse_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_parse.Image = Properties.Resources.暂停按钮变;
        }

        private void pictureBox_parse_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_parse.Image = Properties.Resources.暂停按钮;
        }

        private void pictureBox_stop_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_stop.Image = Properties.Resources.停止按钮变;
        }

        private void pictureBox_stop_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_stop.Image = Properties.Resources.停止按钮;
        }

    }
}
