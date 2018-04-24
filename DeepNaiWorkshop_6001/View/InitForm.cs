using CCWin;
using DeepNaiWorkshop_6001.Model;
using DeepNaiWorkshop_6001.MyTool;
using DeepNaiWorkshop_6001.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepNaiWorkshop_6001.View
{
    public partial class InitForm : CCSkinMain
    {
        private MainForm mainForm;
        public InitForm()
        {
            InitializeComponent();
        }

        private void InitForm_Load(object sender, EventArgs e)
        {
            //new Thread(initAnimator).Start();

        }

        public void InitAnimator()
        {

            this.loadingAnimator.Show(this.initControl11);
            //等到所有的动画将完成
            this.loadingAnimator.WaitAllAnimations();
            Thread.Sleep(1000);
            this.loadingAnimator.Hide(this.initControl11);
            //等到所有的动画将完成
            this.loadingAnimator.WaitAllAnimations();
            this.loadingAnimator.Show(this.initControl21);
            //等到所有的动画将完成
            this.loadingAnimator.WaitAllAnimations();
        }
        /// <summary>
        /// InitForm中的异步动画
        /// </summary>
        public void InitAnimatorAsyn()
        {
            new Thread(InitAnimator).Start();
        }

        private void InitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (mainForm==null||!mainForm.IsShowFirst())//说明选择关闭初始化页面是在还未到主界面的情况，此时关闭，退出应用
            //{
            //    MySystemUtil.Exit("初始化阶段，关闭应用");
            //}
            if (SystemConfig.isNormalCloseInitForm)
            {
                return;
            }
            if (!SystemConfig.isFirstShownForMainForm)
            {
                MySystemUtil.Exit("初始化阶段，关闭应用");
            }


        }

        public void setMainform(MainForm mainform)
        {
            this.mainForm = mainform;
        }

        private void InitForm_Shown(object sender, EventArgs e)
        {
            SystemConfig.isFirstShownForInitForm = true;
        }
    }
}
