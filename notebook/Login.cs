using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//为使用registryKey类，用来读写注册表
using Microsoft.Win32;

namespace notebook
{
    public partial class Login : Form
    {
        private int G_num = 1;
        private DataTable UserDT;
        private DataRow ActiveUser;
        private DataHelper dh;
        private IGeneralLogic igl;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Welcome welform = new Welcome();
            welform.ShowDialog();

            igl = (new ClassFactory()).GetIGeneralLogin();

            dh = new DataHelper();
            UserDT = dh.GetTable(GlobalParam.TableName_User);

            foreach (DataRow dr in UserDT.Rows)
            {
                comboBox_Account.Items.Add(dr["UserName"]);
            }

            this.Icon = Properties.Resources.Icon_book;
            this.AcceptButton = button_Login;
            textBox_PassWord.PasswordChar = '*';
            button_Login.BackColor = Color.Blue;
            button_Login.ForeColor = Color.White;
            button_Login.FlatStyle = FlatStyle.Flat;
            pictureBox_eye.Image = Properties.Resources.P_eye;
            pictureBox_eye.SizeMode = PictureBoxSizeMode.StretchImage;
            toolTip_p_eye.SetToolTip(pictureBox_eye, "显示密码");
            //控件排版
            Composing();

            WindowsAPI.AnimateWindow(this.Handle, 300,WindowsAPI.AW_CENTER|WindowsAPI.AW_ACTIVATE);
            timer1.Enabled = true;
        }

        /// <summary>
        /// 界面排版
        /// </summary>
        private void Composing()
        {
            pictureBox1.Width = this.Width;
            pictureBox1.Height = this.Height / 2;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            label_Account.Location = new Point(12, pictureBox1.Height + 20);

            label_PassWord.Location = new Point(12, label_Account.Location.Y + label_Account.Height + 30);

            comboBox_Account.Location = new Point(
                label_Account.Location.X + label_Account.Width + 10,
                label_Account.Location.Y - (comboBox_Account.Height - label_Account.Height) / 2);

            textBox_PassWord.Location = new Point(
                label_PassWord.Location.X + label_PassWord.Width + 10,
                label_PassWord.Location.Y - (textBox_PassWord.Height - label_PassWord.Height) / 2);
            textBox_PassWord.Width = comboBox_Account.Size.Width - 20;

            pictureBox_eye.Width = 20;
            pictureBox_eye.Height = textBox_PassWord.Size.Height;          
            pictureBox_eye.Location = new Point(
                textBox_PassWord.Location.X+textBox_PassWord.Size.Width,
                textBox_PassWord.Location.Y);

            linkLabe1.Location = new Point(
                comboBox_Account.Location.X + comboBox_Account.Width + 10,
                label_Account.Location.Y);

            checkBox_remberPW.Location = new Point(
                textBox_PassWord.Location.X,
                textBox_PassWord.Location.Y + textBox_PassWord.Height + 10);
            checkBox_AutoLogin.Location = new Point(
                checkBox_remberPW.Location.X + checkBox_remberPW.Width + 10,
                checkBox_remberPW.Location.Y);

            button_Login.Location = new Point(
                (this.Width - button_Login.Width) / 2,
                checkBox_AutoLogin.Location.Y + checkBox_AutoLogin.Height + 10);
        }

        private void 登陆_Paint(object sender, PaintEventArgs e)
        {
            Composing();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string image_num = "P_welcome_" + G_num.ToString();
            ResourceManager resMan = Properties.Resources.ResourceManager;
            Image image = (Image)resMan.GetObject(image_num);
            pictureBox1.Image = image;
            if (++G_num > 15) G_num = 1;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //RegistryKey RegKey1, RegKey2;
            //RegKey1 = Registry.CurrentUser;//获取当前用户注册表项
            //try
            //{
            //    RegKey2 = RegKey1.CreateSubKey(@"Software\NoteBook");//创建注册表子项
            //    RegKey2.SetValue("PointX", this.Location.X.ToString());
            //    RegKey2.SetValue("PointY", this.Location.Y.ToString());
            //}
            //catch { }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string code = igl.ED_code(ActiveUser["PassWord"].ToString(), false);
            //MessageBox.Show("点击登录了", "提示");
            if (textBox_PassWord.Text.CompareTo(code) != 0)
            {
                MessageBox.Show("密码错误！", "提示");
                textBox_PassWord.Text = "";
                textBox_PassWord.Focus();
            }
            else
            {
                GlobalParam.Active_User = this.comboBox_Account.Text;
                if (checkBox_remberPW.Checked) ActiveUser["Rember_PW"] = 1;
                else ActiveUser["Rember_PW"] = 0;
                if (checkBox_AutoLogin.Checked) ActiveUser["AutoLogin"] = 1;
                else ActiveUser["AutoLogin"] = 0;

                WriteNote wn = new WriteNote(this);
                wn.Show();
                dh.UpdateTable(UserDT);
                
                this.Hide();
            }
        }

        private void pictureBox_eye_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_eye.Image = Properties.Resources.P_eye_enter;
        }

        private void pictureBox_eye_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_eye.Image = Properties.Resources.P_eye_down;
            if (!checkBox_remberPW.Checked)
            {
                textBox_PassWord.PasswordChar = (char)0;
            }
        }

        private void pictureBox_eye_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_eye.Image = Properties.Resources.P_eye;
        }

        private void pictureBox_eye_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox_eye.Image = Properties.Resources.P_eye_enter;
            textBox_PassWord.PasswordChar = '*';
        }

        private void linkLabe1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register Reg = new Register(this);
            Reg.Show();
        }

        private void checkBox_remberPW_CheckedChanged(object sender, EventArgs e)
        {
            //if (ActiveUser == null) return;
            //if (checkBox_remberPW.Checked)
            //{
            //    ActiveUser["Rember_PW"] = 1;
            //}
            //else
            //{
            //    ActiveUser["Rember_PW"] = 0;
            //}
            if (!checkBox_remberPW.Checked)
            {
                textBox_PassWord.Text = "";
                textBox_PassWord.Focus();
            }
        }

        private void comboBox_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_PassWord.Text = "";
            checkBox_remberPW.Checked = false;
            checkBox_AutoLogin.Checked = false;
            ActiveUser = null;
            foreach (DataRow dr in UserDT.Rows)
            {
                if (comboBox_Account.Text.CompareTo(dr["UserName"]) == 0)
                {
                    ActiveUser = dr;
                }
            }
            if (ActiveUser!=null && int.Parse(ActiveUser["Rember_PW"].ToString()) == 1)
            {
                checkBox_remberPW.Checked = true;
                textBox_PassWord.Text = igl.ED_code(ActiveUser["PassWord"].ToString(), false);
            }
        }

        public void AddComboBoxItems(string UserName)
        {
            UserDT = dh.GetTable(GlobalParam.TableName_User);
            comboBox_Account.Items.Add(UserName);
            comboBox_Account.Text = UserName;
            textBox_PassWord.Text = "";
            checkBox_remberPW.Checked = false;
            checkBox_AutoLogin.Checked = false;
        }

    }
}
