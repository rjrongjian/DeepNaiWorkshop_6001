using FileCreator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCreator.MyTool
{
    class MySystemUtil
    {
        /// <summary>
        /// 打开指定文件目录
        /// </summary>
        /// <returns></returns>
        public static MyResponse openDir()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择生成文件所存放的目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                string path = dialog.SelectedPath + "\\" + textBox2.Text;
                using (StreamReader sr = new StreamReader(textBox1.Text, Encoding.UTF8))
                {
                    String systemConfig = sr.ReadToEnd();
                    systemConfig = MyVal.DecodeForSysconfig(systemConfig);
                    using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
                    {
                        //string jsonString = JsonConvert.SerializeObject(systemConfig, Formatting.Indented);
                        //jsonString = MyVal.EncodeForSysconfig(jsonString);
                        sw.Write(systemConfig);
                        sw.Flush();
                    }
                }
                MessageBox.Show("文件解码成功！");
            }
        }
    }
}
