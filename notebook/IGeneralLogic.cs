using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notebook
{
    interface IGeneralLogic
    {
        bool CheckChar(char key, CheckCharType cct); 
        /// <summary>
        /// 加密解密字符串
        /// </summary>
        /// <param name="EDstr">待加密/解密字符串</param>
        /// <param name="EncryptOrDecrypt">标识加密/解密，true:加密；false:解密</param>
        /// <returns></returns>
        string ED_code(string EDstr, bool EncryptOrDecrypt);
    }
}
