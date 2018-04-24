using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepNaiWorkshop_6001.MyTool
{
    class MyFileUtil
    {
        public static bool IsExistInRootDir(string memberFile)
        {
            string filePath = Application.StartupPath+"\\"+memberFile;
            MyFileLog.WriteTestLog("memberFile路径："+ filePath);
            return File.Exists(filePath);
        }
    }
}
