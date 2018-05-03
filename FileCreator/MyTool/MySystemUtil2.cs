using FileCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCreator.MyTool
{
    public class MySystemUtil2
    {
        /// <summary>
        /// 打开指定目录
        /// </summary>
        /// <returns></returns>
        public static MyResponse OpenDir()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择生成文件所存放的目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                { 
                    return new MyResponse(false, "文件夹路径不能为空");
                }
                string dirPath = dialog.SelectedPath + "\\";
                return new MyResponse(true, dirPath);
            }
            else
            {
                return new MyResponse(false, "不能获取指定目录");
            }
        }
    }
}
