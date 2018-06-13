using DeepNaiWorkshop_6001.Model;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    class MySystemUtil
    {
        public static void Exit(string message)
        {
            //Console.WriteLine(message);
            MyFileLog.WriteExitToLog(message);
            //强制退出
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 获取服务器时间时间戳 毫秒为单位
        /// </summary>
        /// <returns></returns>
        public static long GetServerTime(int isUseOtherServerTime,string serverTimeFromUrlResponseHeaderDate)
        {
            string content = "";
            if (isUseOtherServerTime == 1)//启用其他服务器的时间作为系统时间
            {
                content = HttpCodeUtil.GetRequest("http://api.m.taobao.com/rest/api3.do?api=mtop.common.getTimestamp", null);
                if (!string.IsNullOrWhiteSpace(content))//解析此时间 //返回格式 { "api":"mtop.common.getTimestamp","v":"*","ret":["SUCCESS::接口调用成功"],"data":{"t":"1524193088907"}}
                {
                    if (content.Contains("SUCCESS"))
                    {
                        JObject dynamicObject = (JObject)JsonConvert.DeserializeObject(content);
                        if (dynamicObject["data"] != null&&dynamicObject["data"]["t"]!=null)
                        {
                            return Convert.ToInt64(dynamicObject["data"]["t"]);
                        }
                    }
                }
                //如果执行到这里，说明第二种获取时间的方式失效
                content = HttpCodeUtil.GetRequest("http://quan.suning.com/getSysTime.do", null);//{"sysTime1":"20180420110128","sysTime2":"2018-04-20 11:01:28"}
                if (content.Contains("sysTime2"))//说明获取时间成功 
                {
                    JObject dynamicObject = (JObject)JsonConvert.DeserializeObject(content);
                    if (dynamicObject["sysTime2"] != null&& dynamicObject["sysTime2"].ToString().Contains("-"))
                    {
                        return Convert.ToInt64(MyDateUtil.GetTimeStamp(Convert.ToDateTime(dynamicObject["sysTime2"].ToString())));
                    }
                }
                //如果执行到这里，说明第三种获取时间的方式失效
                content = HttpCodeUtil.GetRequest("http://cgi.im.qq.com/cgi-bin/cgi_svrtime",null);//2018-04-20 11:02:37
                if (!string.IsNullOrWhiteSpace(content))
                {
                    return Convert.ToInt64(MyDateUtil.GetTimeStamp(Convert.ToDateTime(content)));
                }
            }
            //使用自己的接口获取响应接口时间
            content = HttpCodeUtil.GetRequestHeader(serverTimeFromUrlResponseHeaderDate, "Date");
            MyFileLog.WriteTestLog("获取的格林时间："+content);
            throw new Exception("还未测完");
            return 0;


        }



        /// <summary>
        /// 获取临时会员时长数据
        /// </summary>
        /// <returns></returns>
        public static int GetRegistryMemberUsedData()
        {
            string registryRootDir = SystemConfig.registryRootKey;
            RegistryKey lm = Registry.CurrentUser;
            RegistryKey software = lm.OpenSubKey("Software\\Dyxf\\"+SystemConfig.registryRootKey, true);
            if (software == null)
            {
                return 0;//说明定时器还没有在此字段中记录数据，返回0，代表此用户还未使用过此数据
            }
            //空指针了
            string m = software.GetValue("m", "").ToString();
            
            if ("".Equals(m))//说明定时器还没有在此字段中记录数据，返回0，代表此用户还未使用过此数据
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(m);
            }

        }

        internal static void SetRegistryMemberUsedData(int step)
        {
            string registryRootDir = SystemConfig.registryRootKey;
            RegistryKey lm = Registry.CurrentUser;
            RegistryKey software = lm.OpenSubKey("Software\\Dyxf\\" , true);
            if (software == null)
            {
                software = lm.CreateSubKey("Software\\Dyxf\\", true);
               
            }

            int time = (int)software.GetValue(SystemConfig.registryRootKey, 0);
            software.SetValue(SystemConfig.registryRootKey,time + step);
        }

        public static string getAppRoorPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
