using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    class MyIpUtil
    {
        /// <summary>
        /// 获取本地ip地址。多个ip
        /// </summary>
        public static String[] GetLocalIpAddress()
        {
            string hostName = Dns.GetHostName();                    //获取主机名称  
            IPAddress[] addresses = Dns.GetHostAddresses(hostName); //解析主机IP地址  

            string[] IP = new string[addresses.Length];             //转换为字符串形式  
            for (int i = 0; i < addresses.Length; i++) IP[i] = addresses[i].ToString();

            return IP;
        }

        /// <summary>
        /// 获取外网ip地址
        /// </summary>
        public static string GetExtenalIpAddress_0()
        {
            string IP = "未获取到外网ip";
            try
            {
                //从网址中获取本机ip数据  
                System.Net.WebClient client = new System.Net.WebClient();
                client.Encoding = System.Text.Encoding.Default;
                string str = client.DownloadString("http://www.ip138.com/");
                client.Dispose();

                //提取外网ip数据 [218.104.71.178]  
                int i1 = str.IndexOf("["), i2 = str.IndexOf("]");
                IP = str.Substring(i1 + 1, i2 - 1 - i1);
            }
            catch (Exception) { }

            return IP;
        }

        /// <summary>
        /// 获取外网ip地址
        /// </summary>
        public static string GetExtenalIpAddress()
        {
            String url = "http://hijoyusers.joymeng.com:8100/test/getNameByOtherIp";
            string IP = "未获取到外网ip";
            try
            {
                //从网址中获取本机ip数据  
                System.Net.WebClient client = new System.Net.WebClient();
                client.Encoding = System.Text.Encoding.Default;
                string str = client.DownloadString(url);
                client.Dispose();

                if (!str.Equals("")) IP = str;
                else IP = GetExtenalIpAddress_0();
            }
            catch (Exception) { }

            return IP;
        }


        public static string getExternalIp()
        {
            try
            {
                WebClient client = new WebClient();
                client.Encoding = System.Text.Encoding.Default;
                //string response = client.DownloadString("http://1212.ip138.com/ic.asp");//失效了
                //string response = client.DownloadString("http://icanhazip.com/");//可用，可能不稳定
                string response = client.DownloadString("http://ip.chinaz.com/");//站长之家
                string myReg = @"<dd class=""fz24"">([\s\S]+?)<\/dd>";
                Match mc = Regex.Match(response, myReg, RegexOptions.Singleline);
                if (mc.Success && mc.Groups.Count > 1)
                {
                    response = mc.Groups[1].Value;
                    return response;
                }
                else
                {
                    return "Can't get you Ip address!";
                }
            }
            catch (Exception)
            {
                return "Can't get you Ip address!";
            }

        }

    }
}
