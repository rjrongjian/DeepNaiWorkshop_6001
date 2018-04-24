using DeepNaiWorkshop_6001.Model;
using DeepNaiWorkshop_6001.Service;
using DeepNaiWorkshop_6001.view;
using DeepNaiWorkshop_6001.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepNaiWorkshop_6001.controller
{
    class MainFormController
    {
        private MainForm mainForm { get; set; }
        private InitForm initForm;
        private MemberService memberService;
        private MovieService movieService;
        private NotifyService notifyService;
        private PlayerService playerService;

        public MainFormController()
        {
            
        }

        public void Start()
        {
            
            //在子线程中初始化
            new Thread(initService).Start();
            
        }
        /// <summary>
        /// 为了解决InitForm窗口跨线程访问异常问题，这里只能让所有逻辑同步执行（在同一个子线程里）
        /// </summary>
        public void initService()
        {
            //主窗口展示
            //主线程启动初始化界面
            initForm = new InitForm();
            initForm.Show();
            
            initForm.InitAnimator();

            //加载会员信息
            memberService = new MemberService();
            memberService.ReLoad();//会员数据

            //获取影视列表
            movieService = new MovieService();
            movieService.Reload();//加载影视资源数据

            //加载公告信息
            notifyService = new NotifyService();
            notifyService.Reload();

            //初始化播放器
            playerService = new PlayerService();
            playerService.Reload();
            Thread.Sleep(2000);
            Console.WriteLine("假装初始化完成......");

            //销毁初始化窗口
            initForm.Visible = false;
            if (!initForm.IsDisposed && !initForm.Disposing)
            {
                MyAppConfig.isNormalCloseInitForm = true;//正常关闭app
                initForm.Close();

            }
            initForm = null;
            

            //主窗口展示
            mainForm = new MainForm();
            mainForm.Visible = true;
            Application.Run(mainForm);//开始 win32 的窗口消息循环机制。这样能保持主窗体不关闭程序就一直处于消息循环的不关闭状态

            



        }

        public MainForm GetMainForm()
        {
            return this.mainForm;
        }

    }

   
}
