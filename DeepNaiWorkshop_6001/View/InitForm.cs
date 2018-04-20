using CCWin;
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
    }
}
