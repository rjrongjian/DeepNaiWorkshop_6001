using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFrom_WebApi_Demo;

namespace DeepNaiWorkshop_6001.MyTool
{
    public class YiYunUtil
    {
        public static Dictionary<String, String> ApiUrl;
        /// <summary>
        /// GetExpired | 获取用户的到期时间
        /// </summary>
        public static String GetExpired(String userName)
        {
            // GetExpired | 获取用户的到期时间
            String url = ApiUrl["GetExpired"];  //  这里改成自己的地址
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            //  这里改成自己的参数名称
            parameters.Add("UserName", userName);

           String ret = WebPost.ApiPost(url, parameters);

            if (ret.Length > 0)
            {
                return ret;
            }
            else
            {
                return "";
            }
        }



        static YiYunUtil()
        {
            ApiUrl = new Dictionary<string, string>();
            ApiUrl.Add("UserLogin", "http://w.eydata.net/839c03e916a2a8e5");//用户登录
            ApiUrl.Add("SingleLogin", "http://w.eydata.net/c102e0f81d48e322");//单码用户登录
            ApiUrl.Add("UserRegin", "http://w.eydata.net/cfe22fbe2935fc5e");//用户注册
            ApiUrl.Add("CardRegin", "http://w.eydata.net/efea0a0342833b32");//卡密注册
            ApiUrl.Add("UserRecharge", "http://w.eydata.net/efea0a0342833b32");//用户充值
            ApiUrl.Add("GetExpired", "http://w.eydata.net/1f6208e5b7cc9208");//获取用户的到期时间
            ApiUrl.Add("CheckUserStatus", "http://w.eydata.net/a246b5c4c26efc10");//检测用户状态
            ApiUrl.Add("LogOut", "http://w.eydata.net/61b3173a01089775");//退出登录
            ApiUrl.Add("GetAppCode", "http://w.eydata.net/4ec486e2143192d2");//获取程序数据
            ApiUrl.Add("GetVersionCode", "http://w.eydata.net/aa365946f64b1f30");//获取程序版本数据
            ApiUrl.Add("GetVersionName", "http://w.eydata.net/8eb48137682f79e9");//获取版本名称
            ApiUrl.Add("GetLatestVersion", "http://w.eydata.net/a0940d5fdf94e1d1");//获取最新版本号
            ApiUrl.Add("GetVariable", "http://w.eydata.net/be75fabedfc71a0c");//获取变量数据
            ApiUrl.Add("GetBulletin", "http://w.eydata.net/a785c7d10885be26");//获取程序公告
            ApiUrl.Add("UpdatePwd", "http://w.eydata.net/5ff969d2bef16403");//修改用户密码
            ApiUrl.Add("UpdatePwdByEmail", "http://w.eydata.net/e82b0f76670b450a");//用户密码找回
            ApiUrl.Add("IPChangeBind", "http://w.eydata.net/c9a67fe4f240f3f9");//IP转绑
            ApiUrl.Add("MacChangeBind", "http://w.eydata.net/46880cffd0cab06e");//机器码转绑
            ApiUrl.Add("GetUserData", "http://w.eydata.net/db32af340de43d3b");//获取用户数据
            ApiUrl.Add("SetUserData", "http://w.eydata.net/7a9c35a8934869a7");//设置用户数据
            ApiUrl.Add("GetCardInfo", "http://w.eydata.net/674be37d24e8e147");//获取卡密信息
            ApiUrl.Add("CheckAppVersion", "http://w.eydata.net/d12a8e8ba6f73f05");//检测版本是否是最新版
            ApiUrl.Add("GetUserType", "http://w.eydata.net/5df4a5d4bfc55038");//获取用户类型
            ApiUrl.Add("GetOnlineCount", "http://w.eydata.net/c09b8d91392a71f3");//获取在线用户数
            ApiUrl.Add("CleanUserStates", "http://w.eydata.net/79b51da9f63b76d6");//清理用户在线数据
        }
    }
}
