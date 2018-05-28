using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCreator.MyTool
{
    class MyStringUtil
    {
        /// <summary>
        /// 如果字符串为空，返回空字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string formatString(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }
            else
            {
                return str;
            }
        }
    }
}
