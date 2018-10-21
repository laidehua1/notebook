using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//为使用registryKey类，用来读写注册表
using Microsoft.Win32;
using System.IO;

namespace notebook
{
    public partial class WriteNote : Form
    {
        /// <summary>
        /// 记录鼠标坐标
        /// </summary>
        private Point mouseOffset;
        /// <summary>
        /// 是否按下鼠标
        /// </summary>
        private bool isMouseDown = false;
        private Login log;
        /// <summary>
        /// 工具栏窗体实例
        /// </summary>
        private Tool tform;
        private DataHelper dh;
        private TestForBinary tfb;

        public WriteNote()
        {
            InitializeComponent();
        }

        public WriteNote(Login log)
        {
            InitializeComponent();
            this.log = log;
        }

        public void Openfile(DataRow dr)
        {
            textBox_title.Text = dr["NoteName"].ToString();
            dateTimePicker1.Value = (DateTime)dr["date"];
            comboBox_weather.Text = dr["weather"].ToString();
            comboBox_mood.Text = dr["mood"].ToString();
            richTextBox1.LoadFile(dr["NoteAddr"].ToString());
        }

        private int GetMaxNoteID()
        {
            string sql = string.Format("select max(NoteID) from {0}",GlobalParam.TableName_Note);
            try
            {
                int num = (int)dh.ExecuteScalar(sql);
                return num;
            }
            catch
            {
                return 0;
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            if (tform == null)
            {
                tform = new Tool(this);
            }
            tform.Show();
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

        public void SetFont(Font font)
        {
            richTextBox1.SelectionFont = font;
        }

        public void AfterToolClose()
        {
            this.tform = null;
        }

        public void InsertPicture()
        {
            OpenFileDialog P_OpenFileDialog = new OpenFileDialog();
            P_OpenFileDialog.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";
            DialogResult P_DialogResult = P_OpenFileDialog.ShowDialog();
            if (P_DialogResult == DialogResult.OK)//判断是否选中文件
            {
                Image temp = Image.FromFile(P_OpenFileDialog.FileName);
                Bitmap im = new Bitmap(temp, richTextBox1.Size.Width,
                    temp.Height * richTextBox1.Size.Width / temp.Width);

                Clipboard.SetDataObject(im, false);
                if (richTextBox1.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                {
                    richTextBox1.Paste();//粘贴剪切板的内容到控件中
                }
            }
        }

        public void text_composition(AlignmentType at)
        {
            switch (at)
            {
                case AlignmentType.Center:
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                case AlignmentType.left:
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                    break;
                case AlignmentType.right:
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                    break;
            }
        }

        private void WriteNote_Load(object sender, EventArgs e)
        {
            dh = new DataHelper();
            tfb = new TestForBinary();

            RegistryKey RegKey1, RegKey2;
            RegKey1 = Registry.CurrentUser;//获取当前用户注册表项
            try
            {
                RegKey2 = RegKey1.CreateSubKey(@"Software\NoteBook");//创建注册表子项
                this.Location = new Point(Convert.ToInt16(RegKey2.GetValue("PointX")), Convert.ToInt16(RegKey2.GetValue("PointY")));
            }
            catch
            {
                this.Location = new Point(
                    (Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width) / 2,
                    (Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height) / 2);
            }

            this.Icon = Properties.Resources.Icon_book;
            pictureBox_min.BackColor = Color.Transparent;
            pictureBox_close.BackColor = Color.Transparent;
            comboBox_weather.Items.Add("晴");
            comboBox_weather.Items.Add("阴");
            comboBox_weather.Items.Add("多云");
            comboBox_weather.Items.Add("雨");
            comboBox_weather.Items.Add("雪");
            comboBox_weather.SelectedIndex = 0;

            comboBox_mood.Items.Add("开心");
            comboBox_mood.Items.Add("郁闷");
            comboBox_mood.Items.Add("失落");
            comboBox_mood.Items.Add("无聊");
            comboBox_mood.SelectedIndex = 0;

            label_UserName.Text = GlobalParam.Active_User;
            WindowsAPI.AnimateWindow(this.Handle, 300, WindowsAPI.AW_CENTER | WindowsAPI.AW_ACTIVATE);
        }

        private void WriteNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistryKey RegKey1, RegKey2;
            RegKey1 = Registry.CurrentUser;//获取当前用户注册表项
            try
            {
                RegKey2 = RegKey1.CreateSubKey(@"Software\NoteBook");//创建注册表子项
                RegKey2.SetValue("PointX", this.Location.X.ToString());
                RegKey2.SetValue("PointY", this.Location.Y.ToString());
            }
            catch { }

            WindowsAPI.AnimateWindow(this.Handle, 1000, WindowsAPI.AW_BLEND | WindowsAPI.AW_HIDE);
        }

        private void pictureBox_open_Click(object sender, EventArgs e)
        {
            if (tform != null)
            {
                tform.Hide();
            }

            OpenFile of = new OpenFile(this);
            of.ShowDialog();
        }

        private void pictureBox_save_Click(object sender, EventArgs e)
        {
            if (tform != null)
            {
                tform.Hide();
            }

            if (string.IsNullOrEmpty(textBox_title.Text))
            {
                MessageBox.Show("文章标题没填。");
                textBox_title.Focus();
                return;
            }
            string fileAddr="";
            SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = ".rtf|.rtf";
            sfd.Filter = ".tty|.tty";
            string addr = GlobalParam.RootDirectory + GlobalParam.Active_User;
            if (!Directory.Exists(addr))
            {
                Directory.CreateDirectory(addr);
            }
            sfd.InitialDirectory = addr;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileAddr = sfd.FileName;
                FileStream st = new FileStream(fileAddr,FileMode.Create);
                richTextBox1.SaveFile(st,RichTextBoxStreamType.RichText);
                //tfb.Save(st,fileAddr);
                string sql = string.Format("insert into {0} values ({1},'{2}','{3}','{4}','{5}','{6}','{7}')",
                    GlobalParam.TableName_Note, GetMaxNoteID() + 1, textBox_title.Text, fileAddr, dateTimePicker1.Value,
                    GlobalParam.Active_User, comboBox_weather.Text, comboBox_mood.Text);
                dh.ExecuteNonQuery(sql);
            }
        }

        private void linkLabel_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            log.Show();
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (tform != null)
            {
                tform.Hide();
            }
        }

        private void pictureBox_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MusicPlayer mp = new MusicPlayer();
            mp.Show();
        }

        private void label_play2_Click(object sender, EventArgs e)
        {
            MusicPlayer mp = new MusicPlayer();
            mp.Show();
        }
    }
}
