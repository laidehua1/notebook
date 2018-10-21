using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notebook
{
    class ClassFactory
    {
        /// <summary>
        /// 获取通用逻辑类实例
        /// </summary>
        /// <returns></returns>
        public IGeneralLogic GetIGeneralLogin()
        {
            return new GeneralLogic();
        }
    }
}
