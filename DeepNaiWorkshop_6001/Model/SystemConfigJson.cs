using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    public class SystemConfigJson
    {
        public string notify1;//通知1
        public string notify2;//通知2
        public string notify3;//通知3
        public string upgrateAppUrl;//app最新下载链接
        public string kefuQQ;//客服qq
        public int version;//服务器最新版本号 upgrateAppUrl版本对应的版本号，当前app版本号低于此，就提示用户有新版本
        public string serverTimeFromUrlResponseHeaderDate;//通过一个信任的网站的响应头获取日期
        public int isUseOtherServerTime;//1 是 0否 是否使用其他服务器时间作为系统时间
        public int isSendStatisticMail;//是否发送统计邮件 1是 0否
        public int isMustUpgrade;//是否强制升级 1是 0否



    }
}
