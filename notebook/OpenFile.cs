using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public partial class OpenFile : Form
    {
        private WriteNote wn;
        private DataHelper dh;
        private DataTable NoteDt;
        private Dictionary<DataRow,string > dateRow;

        public OpenFile()
        {
            InitializeComponent();
        }

        public OpenFile(WriteNote wn)
        {
            InitializeComponent();
            this.wn = wn;
        }

        private void OpenFile_Load(object sender, EventArgs e)
        {
            dateRow = new Dictionary< DataRow,string>();
            dh = new DataHelper();
            DataTable tempdt = dh.GetTable(GlobalParam.TableName_Note);
            tempdt.DefaultView.RowFilter = string.Format("UserName='{0}'",GlobalParam.Active_User);
            NoteDt = tempdt.DefaultView.ToTable();

            foreach (DataRow dr in NoteDt.Rows)
            {
                bool IsAdd=true;
                DateTime time = (DateTime)dr["Date"];
                string date = time.Year + "-" + time.Month + "-" + time.Day;
                foreach (string key in dateRow.Values)
                {
                    if (date.CompareTo(key) == 0)
                    {
                        IsAdd = false;
                    }
                }
                dateRow.Add(dr, date);
                if (IsAdd)
                {
                    comboBox_Date.Items.Add(date);
                }
            }
        }

        private void comboBox_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string date = comboBox_Date.Text;
            comboBox_NoteName.Items.Clear();
            foreach (KeyValuePair<DataRow, string> keyvalue in dateRow)
            {
                if (date.CompareTo(keyvalue.Value) == 0)
                {
                    comboBox_NoteName.Items.Add(keyvalue.Key["NoteName"]);
                }
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            DataRow dr;
            foreach (KeyValuePair<DataRow, string> keyvalue in dateRow)
            {
                if (comboBox_Date.Text.CompareTo(keyvalue.Value)==0)
                {
                    if (comboBox_NoteName.Text.CompareTo(keyvalue.Key["NoteName"]) == 0)
                    {
                        dr = keyvalue.Key;
                        wn.Openfile(dr);
                        break;
                    }
                }
            }
            this.Close();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DataRow dr;
            foreach (KeyValuePair<DataRow, string> keyvalue in dateRow)
            {
                if (comboBox_Date.Text.CompareTo(keyvalue.Value) == 0)
                {
                    if (comboBox_NoteName.Text.CompareTo(keyvalue.Key["NoteName"]) == 0)
                    {
                        dr = keyvalue.Key;
                        string addr = dr["NoteAddr"].ToString();
                        if (File.Exists(addr))
                        {
                            File.Delete(addr);
                        }
                        string sql = string.Format("delete from {0} where noteID={1}", GlobalParam.TableName_Note, dr["noteID"]);
                        dh.ExecuteNonQuery(sql);
                        break;
                    }
                }
            }
            this.Close();
        }
    }
}
