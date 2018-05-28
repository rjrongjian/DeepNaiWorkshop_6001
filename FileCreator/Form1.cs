using DeepNaiWorkshop_6001.Model;
using DeepNaiWorkshop_6001.MyTool;
using FileCreator.MyTool;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //选择订单数据
            OpenFileDialog file = new OpenFileDialog();
            //file.Filter = "(excel文件)|*.xls";
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = file.FileName;

            }
            
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("文件名不能为空");
            }
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择生成文件所存放的目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                string path = dialog.SelectedPath+"\\"+textBox2.Text;

                SystemConfigJson systemConfigJson = new SystemConfigJson();
                systemConfigJson.notify1 = MyStringUtil.formatString(textBox3.Text);//通知1
                systemConfigJson.notify2 = MyStringUtil.formatString(textBox4.Text);//通知2
                systemConfigJson.notify3 = MyStringUtil.formatString(textBox8.Text);//通知3
                systemConfigJson.upgrateAppUrl = MyStringUtil.formatString(textBox9.Text);//app最新下载链接(isMustUpgrade=1，此字段必须存在)
                systemConfigJson.kefuQQ = MyStringUtil.formatString(textBox7.Text);//客服qq
                systemConfigJson.version = Convert.ToInt32(MyStringUtil.formatString(textBox6.Text));//服务器最新版本号 upgrateAppUrl版本对应的版本号，当前app版本号低于此，就提示用户有新版本
                systemConfigJson.serverTimeFromUrlResponseHeaderDate = MyStringUtil.formatString(textBox5.Text);//通过一个信任的网站的响应头获取日期
                systemConfigJson.isUseOtherServerTime = radioButton1.Checked?1:0;//1 是 0否 是否使用其他服务器时间作为系统时间
                systemConfigJson.isSendStatisticMail = radioButton4.Checked?1:0;//是否发送统计邮件 1是 0否
                systemConfigJson.isMustUpgrade = radioButton6.Checked?1:0;//是否强制升级 1是 0否

                using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
                {
                    string jsonString = JsonConvert.SerializeObject(systemConfigJson, Formatting.Indented);
                    jsonString = SystemConfigApp.EncodeForSysconfig(jsonString);
                    sw.Write(jsonString);
                    sw.Flush();
                }
                MessageBox.Show("系统配置文件生成成功！");
            }
        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label11.Text = Convert.ToString(SystemConfig.version);
            this.textBox6.Text = Convert.ToString(SystemConfig.version);

        }
    }
}
