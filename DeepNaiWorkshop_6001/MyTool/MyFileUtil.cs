using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepNaiWorkshop_6001.MyTool
{
    public class MyFileUtil
    {
        private List<string> fileNames = new List<string>();
        public static bool IsExistInRootDir(string memberFile)
        {
            string filePath = Application.StartupPath+"\\"+memberFile;
            MyFileLog.WriteTestLog("memberFile路径："+ filePath);
            return File.Exists(filePath);
        }
        /// <summary>
        /// 递归获取文件夹下的所有文件名（包含了后缀名），包含子目录
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        public List<String> GetAllFiles(DirectoryInfo dir)
        {
            FileInfo[] allFile = dir.GetFiles();
            foreach (FileInfo fi in allFile)
            {
                fileNames.Add(fi.Name);
            }
            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach (DirectoryInfo d in allDir)
            {
                GetAllFiles(d);
            }
            return fileNames;
        }
        /// <summary>
        /// 指定目录不存在就创建
        /// </summary>
        /// <param name="fileDir"></param>
        public static void CreateDir(string fileDir)
        {
            // 判断目录是否存在
            if (!Directory.Exists(fileDir))
            {
                Directory.CreateDirectory(fileDir);//创建新路径
            }
        }
    }
}
