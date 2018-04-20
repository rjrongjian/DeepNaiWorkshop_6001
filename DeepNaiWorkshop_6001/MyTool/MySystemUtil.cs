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
            MyFileLog.WriteExitToLog(message);
            //强制退出
            System.Environment.Exit(0);
        }
        /// <summary>
        /// 获取服务器时间
        /// </summary>
        /// <returns></returns>
        public static long GetServerTime()
        {
            string url1 = "http://api.m.taobao.com/rest/api3.do?api=mtop.common.getTimestamp";//返回格式 { "api":"mtop.common.getTimestamp","v":"*","ret":["SUCCESS::接口调用成功"],"data":{"t":"1524193088907"}}
            string url2 = "http://quan.suning.com/getSysTime.do"; //{"sysTime1":"20180420110128","sysTime2":"2018-04-20 11:01:28"}
            string url3 = "http://cgi.im.qq.com/cgi-bin/cgi_svrtime";//2018-04-20 11:02:37

            return 0;


        }
    }
}
