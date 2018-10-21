using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace notebook
{
    [System.Serializable]
    class TestForBinary 
    {
        private string m_name = string.Empty;
        private string m_userid = string.Empty;
 
        public string UserName
        {
            set { m_name = value; }
            get { return m_name; }
        }
 
        public string UserId
        {
            set { m_userid = value; }
            get { return m_userid; }
        }
 
        /// <summary>
        /// 保存序列化对象
        /// </summary>
        /// <param name="fileName">文件完整路径包括名称（c:/test.xxj）</param>
        /// <returns></returns>
        public bool Save(string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs=new FileStream(fileName,FileMode.Create))
            {
                bf.Serialize(fs, this);
                fs.Close();
            }
 
            return true;
        }

        public bool Save(FileStream fs,string fileName)
        {
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();

            return true;
        }
 
        /// <summary>
        /// 反序列化已保存的对象
        /// </summary>
        /// <param name="fileName">文件完整路径包括名称（c:/test.tmp）</param>
        /// <returns></returns>
        public bool Load(string fileName)
        {
            BinaryFormatter xs = new BinaryFormatter();
            TestForBinary tc;
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                tc = xs.Deserialize(fs) as TestForBinary;
            }
 
            if (tc == null)
                return false;
 
            this.m_name = tc.UserName;
            this.UserId = tc.UserId;
 
            return true;
        }
 
    }
}
