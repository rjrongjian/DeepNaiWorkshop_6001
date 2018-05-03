using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    public class ResourceMovie
    {
        public int memberLevel;//要求的观影级别
        public string name;//电影名称
        public string url;//影片链接（加密后）
        public string updateTime;//更新时间
        public string playType;//播放器类型 1 vlc 2 web
    }
}
