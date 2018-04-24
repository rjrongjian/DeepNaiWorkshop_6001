using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    class SystemConfig
    {
        public static string channel = "default";//软件推广的渠道标记
        
        public static int version = 10;//当前版本号 举例 10->1.0
        public static String memberFile = "member.dyxf";//本地会员文件存在的地方
        public static String webRoot = "http://www.52bang.site/dyxf";//可访问的nginx根目录
        public static int durationOfTemporaryMembers = 30;//分为单位
        public static String registryRootDir = "dyxf\\test";
        public static String localSystemConfigFile = "sc.dyxf";
        public static String systemConfigUrl = webRoot + "/sc.json";

        //系统使用的参数，无需关注
        public static bool isFirstShownForInitForm = false;
        public static bool isFirstShownForMainForm = false;
        public static bool isNormalCloseInitForm = false;
        
    }
}
