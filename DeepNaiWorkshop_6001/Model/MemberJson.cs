using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    class MemberJson
    {
        public int ExpiredDays { set; get; }//时长 天为单位
        public long ExpireTime { set; get; }//过期日期20180503
        public string MemberLevel { set; get; }//观影级别，老司机 1 普通会员 0   影视资源中所有模块都会有一个标码，MemberJson.MemberLevel>=MovieResources.MemberLevel，此模块就显示
    }
}
