using DeepNaiWorkshop_6001.controller;
using DeepNaiWorkshop_6001.MyTool;
using DeepNaiWorkshop_6001.view;
using DeepNaiWorkshop_6001.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepNaiWorkshop_6001
{
    static class Program
    {
        public static MainFormController mainFormController { get; private set; }
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string str = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            Exception exception = e.Exception;
            MyFileLog.WriteExitToLogAndSendMail(exception == null ? string.Format("应用程序线程错误:{0}", (object)e) : string.Format(str + "异常类型：{0}\r\n异常消息：{1}\r\n异常信息：{2}\r\n", (object)exception.GetType().Name, (object)exception.Message, (object)exception.StackTrace));
            //注释掉，为了能自启动
            //int num = (int)MessageBox.Show("软件发生未知错误,需要重启软件再操作！\r\n请将‘ErrLog.txt’发给程序员", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //强制退出
            MySystemUtil.Exit("软件发生未知错误，重启软件尝试解决此问题");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exceptionObject = e.ExceptionObject as Exception;
            string str = "出现应用程序未处理的异常：" + DateTime.Now.ToString() + "\r\n";
            MyFileLog.WriteExitToLogAndSendMail(exceptionObject == null ? string.Format("Application UnhandledError:{0}", (object)e) : string.Format(str + "Application UnhandledException:{0};\n\r堆栈信息:{1}", (object)exceptionObject.Message, (object)exceptionObject.StackTrace));
            //int num = (int)MessageBox.Show("软件发生未知错误,需要重启软件再操作！\r\n请将‘ErrLog.txt’发给程序员", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //强制退出
            MySystemUtil.Exit("软件发生未知错误，重启软件尝试解决此问题");
        }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Directory.SetCurrentDirectory(Application.StartupPath);
            mainFormController = new MainFormController();
            mainFormController.Start();
            
            //Console.WriteLine(MyIpUtil.GetExtenalIpAddress_0());
            /*
            Console.WriteLine(MyIpUtil.GetExtenalIpAddress());
            Console.WriteLine(MyIpUtil.getExternalIp());
            Console.WriteLine(MyIpUtil.GetLocalIpAddress());

            int[] x = new int[]{1,2,3,4,5,5 };
            var query = from x1 in x where x1 > 3 select x1;
            query.ToList().ForEach(delegate(int val) {
                Console.WriteLine("aa:"+val);
            });
            //Console.WriteLine(query);
            */
            Application.Run();
        }
    }
}
