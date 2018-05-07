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
    public partial class MainForm : Form
    {
        public MainForm()
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

            //this.textBox18.Text = SystemConfig.resourceFileNameWithSuffix;
            this.comboBox1.ValueMember = "index";
            this.comboBox1.DisplayMember = "moduleName";

            this.comboBox2.ValueMember = "index";
            this.comboBox2.DisplayMember = "moduleName";

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
        /// <summary>
        /// 从发卡平台获取的已出售的卡集合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            //选择订单数据
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "(txt文件)|*.txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox13.Text = file.FileName;

            }
        }
        /// <summary>
        /// 更新会员文件超时时间(认为码是当前时间出售的（且只看年月日，忽略后面的部分）)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox12.Text))
            {

                MessageBox.Show("请设置从服务器导下来的会员码文件夹");
                return;
            }

            if (string.IsNullOrWhiteSpace(this.textBox13.Text))
            {

                MessageBox.Show("请设置从发卡平台获取的已经出售的会员码");
                return;
            }
            //这里认为发卡平台下载的出售的码的文件中，每行一个码，且文件中只包含码
            List<string> saledCodeList = MyFileUtil.readFile(this.textBox13.Text);
            foreach(string saledCode in saledCodeList)
            {
                string memberFilePath = this.textBox12.Text + saledCode + SystemConfig.memberCodeFileSuffix;
                string updateMemberFileDir = this.textBox12.Text + "needUploadServerForUpdateExpire\\";
                string updateMemberFilePath = updateMemberFileDir+ saledCode + SystemConfig.memberCodeFileSuffix;
                MyFileUtil.CreateDir(updateMemberFileDir);
                if (!File.Exists(memberFilePath))
                {
                    MessageBox.Show("已被出售的会员码："+ saledCode+"文件不存在请检查问题");
                    return;
                }
                //读取文件内容，并转成对象
                using (StreamReader sr = new StreamReader(memberFilePath, Encoding.UTF8))
                {
                    String memberJson = sr.ReadToEnd();
                    MemberJson member = SystemConfigApp.ParseForMemberJson(memberJson);

                    //更新超时时间
                    member.ExpireTime = Convert.ToInt64(MyDateUtil.GetTimeStamp(System.DateTime.Now, 13));

                    using (StreamWriter sw = new StreamWriter(File.Open(updateMemberFilePath, FileMode.Create), Encoding.UTF8))
                    {
                        string jsonString = JsonConvert.SerializeObject(member, Formatting.Indented);
                        jsonString = SystemConfigApp.EncodeForMemberFile(jsonString);
                        sw.Write(jsonString);
                        sw.Flush();
                    }
                }
            }

            MessageBox.Show("更新完成");
        }
        
        /// <summary>
        /// 生成空资源文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            isNullResourceFile = true;
            resourceMoviesJson = new ResourceMoviesJson();

            resourceMoviesJson.resourceList = new List<ResourceModule>();
            MyJsonUtil<ResourceMoviesJson> myJsonUtil = new MyJsonUtil<ResourceMoviesJson>();
            string jsonStr = myJsonUtil.parseJsonObj(resourceMoviesJson);

            //同步到文件中
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择生成文件所存放的目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show("请选择生成文件所存放的目录");
                    return;
                }
                textBox14.Text = dialog.SelectedPath+"\\";
                textBox14.Text = textBox14.Text + SystemConfig.resourceFileNameWithSuffix;
                string filePath = textBox14.Text;

                MyFileUtil.writeToFile(filePath, jsonStr);
                MessageBox.Show("初始空文件成功");
            }


        }
        /// <summary>
        /// 选择初始资源文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {

            isNullResourceFile = false;
            //选择订单数据
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "("+SystemConfig.resourceFileNameSuffix + "文件)|*"+ SystemConfig.resourceFileNameSuffix;
            if (file.ShowDialog() == DialogResult.OK)
            {
                textBox14.Text = file.FileName;
                string jsonStr = MyFileUtil.readFileAll(textBox14.Text);
                jsonStr = MyVal.DecodeForResourceFile(jsonStr);

                MyJsonUtil<ResourceMoviesJson> myJsonUtil = new MyJsonUtil<ResourceMoviesJson>();
                resourceMoviesJson = myJsonUtil.parseJsonStr(jsonStr);

                //同步模块到combox中
                List<ResourceModule> resourceModuleList = resourceMoviesJson.resourceList;
                list = new List<ResourceInfoForCombox>();
                for(int i = 0;i< resourceModuleList.Count;i++)
                {
                    ResourceModule resourceModule = resourceModuleList[i];
                    list.Add(new ResourceInfoForCombox { index = i, moduleName = resourceModule.name });
                }
                this.comboBox1.DataSource = MyDataUtil.deepCopy(list);//防止多个combobox绑定同一个数据源导致事件联动
                this.comboBox2.DataSource = list;


                MessageBox.Show("同步数据成功");
            }
        }
        /// <summary>
        /// 添加模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox15.Text))
            {
                MessageBox.Show("模块名不能为空");
                return;
            }
            //给数据源添加一个
            List<ResourceModule> resourceModuleList = resourceMoviesJson.resourceList;
            resourceModuleList.Add( new ResourceModule { name = this.textBox15.Text , movieList = new List<ResourceMovie>()});

            list = new List<ResourceInfoForCombox>();

            //给两个combox添加一个

            list.Add(new ResourceInfoForCombox { index = resourceModuleList.Count-1, moduleName = this.textBox15.Text });

            //数据刷新
            this.comboBox1.DataSource = null;
            this.comboBox1.DataSource = MyDataUtil.deepCopy(list);//防止多个combobox绑定同一个数据源导致事件联动
            this.comboBox1.ValueMember = "index";
            this.comboBox1.DisplayMember = "moduleName";

            this.comboBox2.DataSource = null;
            this.comboBox2.DataSource = list;
            this.comboBox2.ValueMember = "index";
            this.comboBox2.DisplayMember = "moduleName";


            MessageBox.Show("添加模块成功！"+ this.textBox15.Text);
        }

        /// <summary>
        /// 删除选定模块
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            //ResourceModuleForCombox resource = (ResourceModuleForCombox)this.comboBox1.SelectedItem;
            //MessageBox.Show(resource.index + "-" + resource.moduleName);
            MessageBox.Show("功能未开放");
        }
        /// <summary>
        /// 添加资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedItem == null)
            {
                MessageBox.Show("请先选择模块！");
                return;
            }

            if (string.IsNullOrWhiteSpace(this.textBox17.Text))//资源链接
            {
                MessageBox.Show("请输入资源链接！");
                return;
            }

            if (string.IsNullOrWhiteSpace(this.textBox16.Text))//电影名称
            {
                MessageBox.Show("请输入电影名称！");
                return;
            }


            int index = (int)this.comboBox2.SelectedValue;
            List<ResourceModule> resourceList = resourceMoviesJson.resourceList;
            ResourceModule resourceModule = resourceList[index];
            if (resourceModule.movieList == null)
            {
                resourceModule.movieList = new List<ResourceMovie>();
            }

            //
            ResourceMovie resourceMovie = new ResourceMovie();
            resourceMovie.memberLevel = radioButton10.Checked?1:0;
            resourceMovie.name = SystemConfigApp.EncodeLineForResourceFile(textBox16.Text);
            resourceMovie.playType = radioButton12.Checked?2:1; // 播放器类型 1 vlc 2 web
            resourceMovie.updateTime = MyDateUtil.getCurrentDate();
            resourceMovie.url = textBox17.Text;
            resourceModule.movieList.Add(resourceMovie);

            
            if (movieListForCombox == null)
            {
                movieListForCombox = new List<ResourceInfoForCombox>();
            }

            movieListForCombox.Add(new ResourceInfoForCombox { index= resourceModule.movieList.Count-1,moduleName= textBox16.Text });

            //数据刷新
            this.comboBox3.DataSource = null;
            this.comboBox3.DataSource = movieListForCombox;
            this.comboBox3.ValueMember = "index";
            this.comboBox3.DisplayMember = "moduleName";


            MessageBox.Show("资源添加完成");
        }
        /// <summary>
        /// 同步内存中的资源到文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            string filePath = "";
            //文件目录不同
            if (isNullResourceFile)
            {
                //filePath = textBox14.Text + SystemConfig.resourceFileNameWithSuffix;
                filePath = textBox14.Text;
            }
            else
            {
                filePath = textBox14.Text;

            }
            MyJsonUtil<ResourceMoviesJson> myJsonUtil = new MyJsonUtil<ResourceMoviesJson>();
            string jsonStr = myJsonUtil.parseJsonObj(resourceMoviesJson);
            jsonStr = SystemConfigApp.EncodeForResourceFile(jsonStr);//转base
            MyFileUtil.writeToFile(filePath, jsonStr);


            MessageBox.Show("同步内存资源成功");


        }

        //切换模块，将此模块中的资源显示出来
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null)
            {
                return;
            }
            int index = (int)comboBox2.SelectedValue;
            // MessageBox.Show("看看编号a："+index);
            List<ResourceModule> listTemp = resourceMoviesJson.resourceList;
            ResourceModule resourceModule = listTemp[index];
            //数据刷新
            this.comboBox3.DataSource = null;
            if (resourceModule.movieList != null)
            {
                List<ResourceInfoForCombox> movieListForComboxTemp = new List<ResourceInfoForCombox>();
                for(int i = 0;i<resourceModule.movieList.Count;i++)
                {
                    ResourceMovie resourceMovie = resourceModule.movieList[i];
                    movieListForComboxTemp.Add(new ResourceInfoForCombox { index = i, moduleName = resourceMovie.name });
                }

                this.comboBox3.DataSource = movieListForComboxTemp;
            }
            this.comboBox3.ValueMember = "index";
            this.comboBox3.DisplayMember = "moduleName";

        }


        private bool isNullResourceFile = false;
        private ResourceMoviesJson resourceMoviesJson = null;
        private List<ResourceInfoForCombox> list = null;
        private List<ResourceInfoForCombox> movieListForCombox = null;

        
    }
}
