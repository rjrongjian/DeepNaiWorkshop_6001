using DeepNaiWorkshop_6001.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    class MyFileLog
    {
        /// <summary>
        /// 应用自动退出日志，方便重启
        /// </summary>
        /// <param name="str"></param>
        public static void WriteExitToLog(string str)
        {
            StreamWriter streamWriter = new StreamWriter("ExitLog.txt", true);
            streamWriter.WriteLine(DateTime.Now.ToLongTimeString() + "=>" + str);
            streamWriter.WriteLine("---------------------------------------------------------");
            streamWriter.Close();
        }

        public static void WriteExitToLogAndSendMail(string str)
        {
            WriteExitToLog(str);
            //测试mail发送邮件
            String to = SystemConfig.TO_MAIL;
            if (string.IsNullOrWhiteSpace(to))
            {
                to = "1633545776@qq.com";
            }
            //MailTool mail = new MailTool(to, "【电影信封】：出现问题", "当前版本号："+SystemConfig.version + "，软件崩溃崩溃，原因：" + str);
            //mail.Send();
        }

        public static void WriteErrTolog(string str)
        {
            StreamWriter streamWriter = new StreamWriter("ErrLog.txt", true);
            streamWriter.WriteLine(DateTime.Now.ToLongTimeString() + "=>" + str);
            streamWriter.WriteLine("---------------------------------------------------------");
            streamWriter.Close();
        }

        internal static void WriteExceptionToLogWithExit(string v)
        {
            StreamWriter streamWriter = new StreamWriter("ExceptionLog.txt", true);
            streamWriter.WriteLine(DateTime.Now.ToLongTimeString() + "=>" + v);
            streamWriter.WriteLine("---------------------------------------------------------");
            streamWriter.Close();
        }

        public static void LocalLog(string str)
        {
            StreamWriter streamWriter = new StreamWriter("OperatorLog.txt", true);
            streamWriter.WriteLine(DateTime.Now.ToLongTimeString() + "=>" + str);
            streamWriter.WriteLine("---------------------------------------------------------");
            streamWriter.Close();
        }

        public static void WriteTestLog(string str)
        {
            Console.WriteLine(DateTime.Now.ToLongTimeString() + "=>" + str);
        }
    }
}
