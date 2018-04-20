﻿using CCWin;
using DeepNaiWorkshop_6001.service;
using DeepNaiWorkshop_6001.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepNaiWorkshop_6001.view
{
    //public partial class MainForm : Skin_Mac
    public partial class MainForm : CCSkinMain
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void InitMedia()
        {
            
            // 创建VLC播放资源索引 开始播放后很占内存
            
            IntPtr instance = MediaPlayer.Create_Media_Instance();
            //创建播放器
            IntPtr mediaPlayer = MediaPlayer.Create_MediaPlayer(instance, this.mediaPanel.Handle);


            bool result = MediaPlayer.NetWork_Media_Play(instance, mediaPlayer, @"http://116.211.183.192/alhdl.cdn.zhanqi.tv/zqlive/32071_U12YU.flv?k=5a09326a1efd06742cb6f27e7633ef31&t=5ad4aecd&platform=01&playNum=3779303996&gId=1634103373&ipFrom=1&clientIp=171.43.146.191&fhost=");
            Console.WriteLine("播放网络源结果："+result);
            

            //方法二 不能播放 老是插件路径乱码
            
            /*
            String pluginVlc = System.Environment.CurrentDirectory+"\\plugins\\";//vlc将编码解码
            Console.WriteLine("插件路径：" + pluginVlc);
           VlcPlayer vlc = new VlcPlayer(pluginVlc);
            vlc.SetRenderWindow((int)this.mediaPanel.Handle);
            vlc.PlayFile("http://58.51.149.97/alhdl.cdn.zhanqi.tv/zqlive/264155_E5o7z.flv?k=eca0c978541fe473194ab540470e96a0&t=5ad079b5&platform=01&playNum=3985385074&gId=1686140948&ipFrom=1&clientIp=27.19.150.106&fhost=index");
            //vlc.Pause();
            */
        }
        
        private void accountButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("");

            if (memberControl.Visible)
            {
                animator.Hide(memberControl);
            }
            else
            {
                animator.Show(memberControl);
            }
            //等到所有的动画将完成
            animator.WaitAllAnimations();

        }
        /// <summary>
        /// 显示账户panel
        /// </summary>
        public void showAccountPanel()
        {

            if (!memberControl.Visible)
            {
                animator.Show(memberControl);
            }
            //等到所有的动画将完成
            animator.WaitAllAnimations();
        }
        /// <summary>
        /// 隐藏账户panel
        /// </summary>
        public void hideAccountPanel()
        {
            if (memberControl.Visible)
            {
                animator.Hide(memberControl);
            }
            //等到所有的动画将完成
            animator.WaitAllAnimations();
        }

        private void movieButton_Click(object sender, EventArgs e)
        {
            if (moviePanel.Visible)
            {
                animator.Hide(moviePanel);
            }
            else
            {
                animator.Show(moviePanel);
            }
            //等到所有的动画将完成
            animator.WaitAllAnimations();
        }
        /// <summary>
        /// 显示电影盒子panel
        /// </summary>
        public void showMoviePanel()
        {
            if (!moviePanel.Visible)
            {
                animator.Show(moviePanel);
            }
            //等到所有的动画将完成
            animator.WaitAllAnimations();
        }
        /// <summary>
        /// 隐藏电影盒子panel
        /// </summary>
        public void hideMoviePanel()
        {
            if (moviePanel.Visible)
            {
                animator.Hide(moviePanel);
            }
            //等到所有的动画将完成
            animator.WaitAllAnimations();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
