using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeepNaiWorkshop_6001.Model;
using DeepNaiWorkshop_6001.MyTool;
using Newtonsoft.Json;

namespace DeepNaiWorkshop_6001.Service
{
    class SystemService
    {
        private SystemConfigJson systemConfigJson;
        public void Reload()
        {
            //每次启动重新获取一次系统配置，如果出现异常或者不存在就用默认的配置。
            try
            {
                //string content = HttpCodeUtil.GetRequest(SystemConfig.systemConfigUrl, null); //传输过来的串可能存在?
                string content = HttpCodeUtil.HttpGet(SystemConfig.systemConfigUrl, "");
               
                systemConfigJson = MyVal.ParseForSystemConfigJson(content);
                
            }
            catch(Exception e)
            {
                MyFileLog.WriteExceptionToLogWithExit("异常信息："+e);
                systemConfigJson = getDefaultSystemConfigJson();
            }
            

        }

        public SystemConfigJson getCurrentSystemConfigJson()
        {
            return systemConfigJson;
        }

        public SystemConfigJson getDefaultSystemConfigJson()
        {
            SystemConfigJson systemConfigJson = new SystemConfigJson();
            systemConfigJson.kefuQQ = "1633545776";//当没有下发下来的时候，用这个
            systemConfigJson.version = SystemConfig.version;
            systemConfigJson.serverTimeFromUrlResponseHeaderDate = SystemConfig.webRoot;
            systemConfigJson.isUseOtherServerTime = 1;
            systemConfigJson.isSendStatisticMail = 0;

            return systemConfigJson;
        }
    }
}
