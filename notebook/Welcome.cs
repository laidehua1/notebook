using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace notebook
{
    public partial class Welcome : Form
    {
        private int G_num = 1;

        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Width = 400;
            this.Height = 360;
            this.Location = new Point(
                (Screen.PrimaryScreen.WorkingArea.Width-this.Size.Width)/2,
                (Screen.PrimaryScreen.WorkingArea.Height-this.Size.Height)/2);
            this.Icon = Properties.Resources.Icon_book;
            
            timer1.Enabled = true;
            timer2.Start();
            timer2.Interval = 3000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string image_num = "P_welcome_" + G_num.ToString();
            ResourceManager resMan = Properties.Resources.ResourceManager;
            Image image = (Image)resMan.GetObject(image_num);
            this.BackgroundImage = image;
            if (++G_num > 15) G_num = 1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            WindowsAPI.AnimateWindow(this.Handle, 3000, WindowsAPI.AW_BLEND | WindowsAPI.AW_HIDE);
        }

        private void Welcome_MouseDown(object sender, MouseEventArgs e)
        {
            //使用Windows API实现无边框窗体鼠标点击移动
            if (e.Button == MouseButtons.Left)
            {
                WindowsAPI.ReleaseCapture();
                WindowsAPI.SendMessage(this.Handle, 0xA1, 0x02, 0);
            }
        }
    }
}
