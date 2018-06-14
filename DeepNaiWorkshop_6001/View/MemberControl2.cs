using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFrom_WebApi_Demo;
using DeepNaiWorkshop_6001.MyTool;
using DeepNaiWorkshop_6001.Model;
using DeepNaiWorkshop_6001.view;

namespace DeepNaiWorkshop_6001.View
{
    public partial class MemberControl2 : UserControl
    {

        private MainForm fatherForm;
        public MemberControl2()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // 用户登录(UserLogin) url
            var url = YiYunUtil.ApiUrl["UserLogin"]; //  这里改成自己的地址

            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                var code = OperateIniFile.ReadIniData("root", "code", "", "config.ini");
                var upName = OperateIniFile.ReadIniData("root", "upName", "", "config.ini");
                if (code.Length > 0 && upName.Length > 0)
                {
                    // 	退出登录(LogOut) url
                    var logOutUrl = YiYunUtil.ApiUrl["LogOut"]; //  这里改成自己的地址

                    //  这里改成自己的参数名称
                    parameters.Add("StatusCode", code);
                    parameters.Add("UserName", upName);


                    WebPost.ApiPost(logOutUrl, parameters);

                    parameters.Clear();
                }

                //  这里改成自己的参数名称
                parameters.Add("UserName", loginPageUserName.Text.Trim());
                parameters.Add("UserPwd", loginPagePassword.Text);
                parameters.Add("Version", "1.1");
                parameters.Add("Mac", "");



                var ret = WebPost.ApiPost(url, parameters);

                if (ret.Length == 32)
                {
                    OperateIniFile.WriteIniData("root", "code", ret, "config.ini");
                    OperateIniFile.WriteIniData("root", "upName", loginPageUserName.Text.Trim(), "config.ini");
                    if (loginPageRememberMe.Checked)
                    {
                        OperateIniFile.WriteIniData("root", "name", loginPageUserName.Text, "config.ini");
                        OperateIniFile.WriteIniData("root", "pwd", loginPagePassword.Text, "config.ini");
                    }
                    else
                    {
                        OperateIniFile.WriteIniData("root", "name", "", "config.ini");
                        OperateIniFile.WriteIniData("root", "pwd", "", "config.ini");
                    }

                    CacheData.StatusCode = ret;
                    CacheData.UserName = loginPageUserName.Text;

                    //获取超期时间
                    CacheData.ExpireDate = YiYunUtil.GetExpired(CacheData.UserName);

                    fatherForm.DisplayMemberInfo();
                    //FrmMain frm = new FrmMain(ret,txtLoginUserName.Text.Trim());
                    //this.Hide();
                    //frm.Show();
                    //myPlugin.InitMainform(ret, txtLoginUserName.Text.Trim());
                }
                else
                {
                    String errInfo = YiYouCode.getValue(ret);
                    if (string.IsNullOrWhiteSpace(errInfo))
                    {
                        MessageBox.Show("登录失败,错误代码: " + ret);
                    }
                    else
                    {
                        MessageBox.Show(errInfo);
                    }

                }
            }
            catch (Exception e18)
            {
                MyFileLog.WriteErrTolog("登录出现异常，原因："+e18);
                MessageBox.Show("登录出现异常,请联系管理员!");
            }
        }

        public void setFatherForm(MainForm mainForm)
        {
            fatherForm = mainForm;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            // UserRegin | 用户注册 url
            var url = YiYunUtil.ApiUrl["UserRegin"]; //  这里改成自己的地址

            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                //  这里改成自己的参数名称
                parameters.Add("UserName", registPageUserName.Text.Trim());
                parameters.Add("UserPwd", registPagePassword.Text.Trim());
                parameters.Add("Email", registPageEmail.Text.Trim());
                parameters.Add("Mac", "");

                var ret = WebPost.ApiPost(url, parameters);

                if (ret == "1")
                {
                    //MessageBox.Show("注册成功!");
                    registerTip.Text = "注册成功！！！";
                }
                else
                {
                    //MessageBox.Show("注册失败,错误代码: " + ret);
                    registerTip.Text = ret;
                }
            }
            catch (Exception e19)
            {
                MyFileLog.WriteErrTolog("注册出现异常,原因," + e19);
                //MessageBox.Show("网络连接失败!");
                registerTip.Text = "软件异常，请联系客服";
            }
            if (!registerTip.Visible)
            {
                registerTip.Show();
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            // UserRecharge | 用户充值
            var url = YiYunUtil.ApiUrl["UserRecharge"]; //  这里改成自己的地址

            IDictionary<string, string> parameters = new Dictionary<string, string>();

            try
            {
                //  这里改成自己的参数名称
                parameters.Add("UserName", rechargePageUserName.Text.Trim());
                parameters.Add("CardPwd", rechargePageCard.Text.Trim());
                parameters.Add("Referral", rechargePageRec.Text);

                var ret = WebPost.ApiPost(url, parameters);

                if (int.Parse(ret) >= 1)
                {
                    //MessageBox.Show("充值成功!");
                    rechargeTip.Text = "充值成功！";
                }
                else
                {
                    //MessageBox.Show("充值失败,错误代码: " + ret);
                    rechargeTip.Text = ret;
                }
            }
            catch (Exception e20)
            {
                //MyLogUtil.ErrToLog("异常原因," + e20);
                MyFileLog.WriteErrTolog("充值出现异常,原因," + e20);
                //MessageBox.Show("网络连接失败!");
                rechargeTip.Text = "软件异常，请联系客服";
            }
            if (!rechargeTip.Visible)
            {
                rechargeTip.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //调用系统默认的浏览器   
            System.Diagnostics.Process.Start(CacheData.YiYunData.TaskUrlForRechargeCard);
        }
    }
}
