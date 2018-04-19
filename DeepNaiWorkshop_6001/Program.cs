using DeepNaiWorkshop_6001.controller;
using DeepNaiWorkshop_6001.view;
using DeepNaiWorkshop_6001.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepNaiWorkshop_6001
{
    static class Program
    {
        public static MainFormController mainFormController { get; private set; }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Directory.SetCurrentDirectory(Application.StartupPath);

            //mainFormController = new MainFormController();
            //mainFormController.Start();
            Application.Run(new MainForm());
        }
    }
}
