using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    class MyFileLog
    {
        /// <summary>
        /// 应用自动退出日志，方便重启
        /// </summary>
        /// <param name="str"></param>
        public static void WriteExitToLog(string str)
        {
            StreamWriter streamWriter = new StreamWriter("ExitLog.txt", true);
            streamWriter.WriteLine(str);
            streamWriter.WriteLine("---------------------------------------------------------");
            streamWriter.Close();

        }
    }
}
