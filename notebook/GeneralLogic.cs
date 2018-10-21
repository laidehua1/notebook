using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace notebook
{
    class GeneralLogic:IGeneralLogic
    {
        public bool CheckChar(char key, CheckCharType cct)
        {
            bool result = false;
            switch (cct)
            {
                case CheckCharType.OnlyNum:
                    result = char.IsDigit(key);
                    break;
                case CheckCharType.OnlyLetter:
                    if ((key >= 'A' && key <= 'Z') || (key >= 'a' && key <= 'z'))
                    {
                        result = true;
                    }
                    break;
                case CheckCharType.NumOrLetter:
                    if ((key >= '0' && key <= '9') || (key >= 'A' && key <= 'Z') || (key >= 'a' && key <= 'z'))
                    {
                        result = true;
                    }
                    break;
            }
            return result;
        }


        public string ED_code(string EDstr, bool EncryptOrDecrypt)
        {
            DESCryptoServiceProvider descsp = new DESCryptoServiceProvider();//实例化加解密类对象
            byte[] key = Encoding.Unicode.GetBytes(GlobalParam.EDKey);//定义字节数组，用来存储密钥

            string Result = "";
            MemoryStream MStream = new MemoryStream();//实例化内存流对象

            if (EncryptOrDecrypt)
            {
                byte[] data1 = Encoding.Unicode.GetBytes(EDstr);//定义字节数组，用来存储要加密的字符串
                CryptoStream CStream = new CryptoStream(MStream, descsp.CreateEncryptor(key, key), CryptoStreamMode.Write);
                CStream.Write(data1, 0, data1.Length);//向加密流中写入数据
                CStream.FlushFinalBlock();//释放加密流
                Result = Convert.ToBase64String(MStream.ToArray());//加密字符串
                CStream.Close();
            }
            else
            {
                byte[] data1;
                try
                {
                    data1 = Convert.FromBase64String(EDstr);
                }
                catch
                {
                    return null;
                }
                CryptoStream CStream = new CryptoStream(MStream, descsp.CreateDecryptor(key, key), CryptoStreamMode.Write);
                CStream.Write(data1, 0, data1.Length);//向解密流中写入数据
                CStream.FlushFinalBlock();//释放解密流
                Result = Encoding.Unicode.GetString(MStream.ToArray());
                CStream.Close();
            }
            MStream.Close();
            return Result;
        }
    }
}
