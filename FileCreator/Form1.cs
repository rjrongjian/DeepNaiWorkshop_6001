using DeepNaiWorkshop_6001.Model;
using DeepNaiWorkshop_6001.MyTool;
using FileCreator.Model;
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

        private void button4_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择生成文件所存放的目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show("请选择生成文件所存放的目录");
                    return ;
                }
                string dirPath = dialog.SelectedPath + "\\";
                this.textBox11.Text = dirPath;
            }
            //把打开目录的代码封装了就不能正常操作
            /*
            MyResponse myResponse = MySystemUtil2.OpenDir();
            if (myResponse.isSuccess)//获取文件目录成功
            {
                this.textBox11.Text = myResponse.message;
            }
            else
            {
                MessageBox.Show(myResponse.message);
                return;
            }
            */
        }
        /// <summary>
        /// 开始生成会员码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //判断会员码目录是否为空
            if (string.IsNullOrWhiteSpace(this.textBox11.Text)) {
                MessageBox.Show("请先设置从服务器导下来的会员码目录");
                return;
            }

            int memberLevel = radioButton7.Checked ? 1 : 0;

            //新生成的会员码采取追加方式，即只有在服务器上导下来的才算做正在使用的码
            //不包含目前已经创建和已在使用的会员码
            List<string> canUseCodeList = MemberCodeUtil.CreateUsableCode(this.textBox11.Text, Convert.ToInt32(this.numericUpDown2.Value));
            //生成会员文件的同时，为了方便在发卡平台上传会员码，需要生成一个txt文件记录了新生成的会员码（文件名描述了这个码的会员等级、时长）
            string codeListFilePath = MemberCodeUtil.GetCodeListFilePath(this.textBox11.Text, Convert.ToInt32(this.numericUpDown1.Value), memberLevel);

            
            using (StreamWriter sw = new StreamWriter(File.Open(codeListFilePath, FileMode.Append), Encoding.UTF8))
            {
                foreach (string code in canUseCodeList)
                {
                    string memberFileName = code + SystemConfig.memberCodeFileSuffix;
                    
                    //新创建的会员码文件路径
                    string memberFilePath = MemberCodeUtil.GetMemberFilePath(this.textBox11.Text, Convert.ToInt32(this.numericUpDown1.Value), memberLevel, code);
                    MemberJson memberJson = new MemberJson(Convert.ToInt32(numericUpDown1.Value), memberLevel);
                    //开始将会员内容写入文件
                    using (StreamWriter sw2 = new StreamWriter(File.Open(memberFilePath, FileMode.Create),Encoding.UTF8))
                    {
                        string jsonString = JsonConvert.SerializeObject(memberJson, Formatting.Indented);
                        //加密会员数据
                        jsonString = SystemConfigApp.EncodeForMemberFile(jsonString);
                        sw2.Write(jsonString);
                        sw2.Flush();
                    }
                    //每成功生成一个会员文件，就将会员码写入
                    sw.WriteLine(code);
                    sw.Flush();
                }

                
            }
            
            MessageBox.Show("创建完成！");

        }
        /// <summary>
        /// 选择从服务器上新导下来的会员码文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择生成文件所存放的目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show("请选择生成文件所存放的目录");
                    return;
                }
                string dirPath = dialog.SelectedPath + "\\";
                this.textBox12.Text = dirPath;

            }
        }
    }
}
