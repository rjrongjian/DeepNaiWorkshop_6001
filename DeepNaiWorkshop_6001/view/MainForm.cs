using CCWin;
using DeepNaiWorkshop_6001.service;
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
    public partial class MainForm : Skin_Mac
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void InitMedia()
        {
            
            // 创建VLC播放资源索引 开始播放后很占内存
            /*
            IntPtr instance = MediaPlayer.Create_Media_Instance();
            //创建播放器
            IntPtr mediaPlayer = MediaPlayer.Create_MediaPlayer(instance, this.mediaPanel.Handle);


            bool result = MediaPlayer.NetWork_Media_Play(instance, mediaPlayer, @"http://58.51.149.94/alhdl.cdn.zhanqi.tv/zqlive/21841_g3iAb.flv?k=2f578d81d3d65fddb3ea42c401cbb165&t=5ad06a75&platform=01&playNum=1027789598&gId=1686140948&ipFrom=1&clientIp=27.19.150.106&fhost=");
            Console.WriteLine("播放网络源结果："+result);
            */

            //方法二
            
            
            String pluginVlc = System.Environment.CurrentDirectory+"\\plugins\\";//vlc将编码解码
            Console.WriteLine("插件路径：" + pluginVlc);
           VlcPlayer vlc = new VlcPlayer(pluginVlc);
            vlc.SetRenderWindow((int)this.mediaPanel.Handle);
            vlc.PlayFile("http://116.207.113.124/alhdl.cdn.zhanqi.tv/zqlive/111343_Whti8_720p.flv?k=56bebc8ca777e55c3663344f6db9db30&t=5ad07092&platform=01&playNum=2993262388&gId=1686140948&ipFrom=1&clientIp=27.19.150.106&fhost=index");
            //vlc.Pause();
            
        }
    }
}
