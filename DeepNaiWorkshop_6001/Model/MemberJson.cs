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
        public List<String> Permissions { set; get; }
        public string MemberType { set; get; }//老司机 普通会员
    }
}
