using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace notebook
{
    public partial class Register : Form
    {
        private Login log;
        private DataHelper dh;
        private IGeneralLogic igl;
        
        public Register()
        {
            InitializeComponent();
        }

        public Register(Login log)
        {
            InitializeComponent();
            this.log = log;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            dh = new DataHelper();
            ClassFactory cf = new ClassFactory();
            igl = cf.GetIGeneralLogin();
            
            pictureBox_User.Location = new Point(textBox_User.Location.X + textBox_User.Size.Width,
                textBox_User.Location.Y);
            pictureBox_User.Width = 20;
            pictureBox_User.Height = textBox_User.Size.Height;
            pictureBox_User.BackColor = Color.Transparent;
            pictureBox_User.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_password1.Location = new Point(textBox_passWord.Location.X + textBox_passWord.Size.Width,
                textBox_passWord.Location.Y);
            pictureBox_password1.Width = 20;
            pictureBox_password1.Height = textBox_passWord.Size.Height;
            pictureBox_password1.BackColor = Color.Transparent;
            pictureBox_password1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_password2.Location = new Point(textBox_RePassWord.Location.X + textBox_RePassWord.Size.Width,
                textBox_RePassWord.Location.Y);
            pictureBox_password2.Width = 20;
            pictureBox_password2.Height = textBox_RePassWord.Size.Height;
            pictureBox_password2.BackColor = Color.Transparent;
            pictureBox_password2.SizeMode = PictureBoxSizeMode.StretchImage;
            toolTip_error.ShowAlways = true;
            toolTip_error.IsBalloon = true;

            this.Location = log.Location;
            this.Icon = Properties.Resources.Icon_book;
            this.BackgroundImage = Properties.Resources.P_Register_Background;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            linkLabel_returnLogin.BackColor = Color.Transparent;
            textBox_passWord.PasswordChar = (char)0;
            textBox_RePassWord.PasswordChar = (char)0;
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            log.Show();
        }

        private void linkLabel_returnLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void textBox_User_Validated(object sender, EventArgs e)
        {
            string sqlstr = string.Format("select count(*) from {0} where UserName='{1}'",GlobalParam.TableName_User,textBox_User.Text);
            int i = (int)dh.ExecuteScalar(sqlstr);

            if (0 == i)
            {
                Bitmap bit = new Bitmap(Properties.Resources.P_GreenReally);
                bit.MakeTransparent(Color.White);
                pictureBox_User.Image = (Image)bit;
            }
            else
            {
                Bitmap bit = new Bitmap(Properties.Resources.P_close);
                bit.MakeTransparent(Color.White);
                pictureBox_User.Image = (Image)bit;

                toolTip_error.Show("用户名重复！", textBox_User, 2000);
                textBox_User.Focus();
            }
        }

        private void textBox_RePassWord_Validated(object sender, EventArgs e)
        {
            if (textBox_RePassWord.Text.CompareTo(textBox_passWord.Text) != 0)
            {
                textBox_passWord.Focus();
                textBox_RePassWord.Clear();
                toolTip_error.Show("两次密码不同！", textBox_RePassWord, 2000);
                
                pictureBox_password2.Image = Properties.Resources.P_close;
            }
            else
            {
                pictureBox_password2.Image = Properties.Resources.P_GreenReally;
                toolTip_error.Show("点击注册完成注册。", button_register, 2000);        
            }
        }

        private void textBox_passWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = !igl.CheckChar(e.KeyChar,CheckCharType.NumOrLetter);
            }
            else
            {
                e.Handled = false;
            }
            if (e.Handled)
            {
                toolTip_error.Show("输入数字或字母。", textBox_passWord, 2000);
            }
        }

        private void textBox_passWord_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_passWord.Text.Length < 8)
            {
                e.Cancel = true;
                textBox_passWord.Focus();
                toolTip_error.Show("密码长度应大于8位。", textBox_passWord, 2000);
                pictureBox_password1.Image = Properties.Resources.P_close;
            }
            else
            {
                pictureBox_password1.Image = Properties.Resources.P_GreenReally;
            }
            
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_User.Text) && !string.IsNullOrEmpty(textBox_RePassWord.Text))
            {
                string code = igl.ED_code(textBox_RePassWord.Text, true);
                string sql = string.Format("insert into {0} values('{1}','{2}',0,0)",
                    GlobalParam.TableName_User,textBox_User.Text,code);
                dh.ExecuteNonQuery(sql);

                log.AddComboBoxItems(textBox_User.Text);
                this.Close();
            }
        }
    }
}
