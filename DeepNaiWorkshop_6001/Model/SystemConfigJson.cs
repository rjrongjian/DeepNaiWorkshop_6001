using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    class SystemConfigJson
    {
  //"notify1":"",//通知1
  //"notify2":"",//通知2
  //"notify3":"",//通知3
  //"upgrateAppUrl":"",//app最新下载链接
  //"keFuQQ":"",//客服qq
  //"version":"2.2",//upgrateAppUrl版本对应的版本号，当前app版本号低于此，就提示用户有新版本
        public string ServerTimeFromUrlResponseHeaderDate = "http://www.52bang.site";//通过一个信任的网站的响应头获取日期
        public int isUserOtherServerTime = 1;//1 是 0否
    }
}
