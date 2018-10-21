using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace notebook
{
    class DataHelper
    {
        private static Dictionary<string, SqlDataAdapter> sdaDic = new Dictionary<string, SqlDataAdapter>();
        private SqlConnection sc;

        public DataHelper()
        {
            sc = GetConnection();
            SqlCommand com = new SqlCommand();
            //com.Parameters[0].Direction = ParameterDirection.InputOutput;
        }

        private string GetConnectionString()
        {
            string ConStr = "server=localhost;database=noteBook_1;uid=sa;pwd=224393";
            return ConStr;
        }

        private SqlConnection GetConnection()
        {
            string constr = GetConnectionString();
            SqlConnection sc = new SqlConnection(constr);
            return sc;
        }

        private void ConnectionClose()
        {
            if (sc.State == ConnectionState.Open)
            {
                sc.Close();
            }
        }

        public DataTable GetTable(string TableName)
        {
            string sqlstr = string.Format("select * from {0}",TableName);
            SqlDataAdapter sda = new SqlDataAdapter(sqlstr,sc);
            DataTable temptable = new DataTable();
            sc.Open();
            sda.Fill(temptable);
            temptable.TableName = TableName;
            if (DataHelper.sdaDic.ContainsKey(TableName))
            {
                DataHelper.sdaDic[TableName] = sda;
                
            }
            else
            {
                DataHelper.sdaDic.Add(TableName, sda);
            }
            ConnectionClose();
            return temptable;
        }

        public bool UpdateTable(DataTable dt)
        {
            SqlDataAdapter sda;
            try
            {
                sda = DataHelper.sdaDic[dt.TableName];
            }
            catch
            {
                return false;
            }
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            return true;
        }

        public int ExecuteNonQuery(string Sqlstr)
        {
            int result;
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand(Sqlstr, sc);
                result = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                ConnectionClose();
            }
            return result;
        }

        public object ExecuteScalar(string Sqlstr)
        {
            object result;
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand(Sqlstr, sc);
                result = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                ConnectionClose();
            }
            return result;
        }
    }
}
