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
    public partial class Tool : Form
    {
        private WriteNote wn;
        public Tool()
        {
            InitializeComponent();
        }

        public Tool(WriteNote wn)
        {
            InitializeComponent();
            this.wn = wn;
        }

        private void Tool_Shown(object sender, EventArgs e)
        {
        }

        private void Tool_Load(object sender, EventArgs e)
        {
            this.Location = new Point(wn.Location.X - this.Width, wn.Location.Y);
            this.TopMost = true;
            this.Icon = Properties.Resources.Icon_book;
            comboBox_font.Items.Add("宋体");
            comboBox_font.Items.Add("黑体");
            comboBox_font.Items.Add("楷体");
            for (int i = 8; i < 25; i++)
            {
                comboBox_size.Items.Add(i);
            }
            comboBox_font.SelectedIndex = 0;
            comboBox_size.SelectedIndex = 1;
        }

        private void comboBox_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            int size = comboBox_size.SelectedIndex + 8;
            switch (comboBox_font.Text)
            {
                case "宋体":
                    {
                        Font font = new Font("宋体", size);
                        wn.SetFont(font);
                    }
                    break;
                case "楷体":
                    {
                        Font font = new Font("楷体", size);
                        wn.SetFont(font);
                    }
                    break;
                case "黑体":
                    {
                        Font font = new Font("黑体", size);
                        wn.SetFont(font);
                    }
                    break;
            }
        }

        private void comboBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fontText = comboBox_font.Text;
            int size = comboBox_size.SelectedIndex + 8;
            Font font = new Font(fontText, size);
            wn.SetFont(font);
        }

        private void Tool_FormClosed(object sender, FormClosedEventArgs e)
        {
            wn.AfterToolClose();
        }

        private void button_Addpicture_Click(object sender, EventArgs e)
        {
            wn.InsertPicture();
        }

        private void pictureBox_center_Click(object sender, EventArgs e)
        {
            wn.text_composition(AlignmentType.Center);
        }

        private void pictureBox_right_Click(object sender, EventArgs e)
        {
            wn.text_composition(AlignmentType.right);
        }

        private void pictureBox_left_Click(object sender, EventArgs e)
        {
            wn.text_composition(AlignmentType.left);
        }
    }
}
