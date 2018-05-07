using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    public class ResourceMovie
    {
        public int memberLevel { set; get; }//要求的观影级别
        public string name { set; get; }//电影名称
        public string url { set; get; }//影片链接（加密后）
        public string updateTime { set; get; }//更新时间
        public int playType { set; get; }//播放器类型 1 vlc 2 web
    }
}
