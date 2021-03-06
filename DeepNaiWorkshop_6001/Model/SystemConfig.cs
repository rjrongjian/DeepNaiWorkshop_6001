﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    /// <summary>
    /// 注意本地路径用\   url用/
    /// </summary>
    public class SystemConfig
    {
        
        public static string channel = "default";//软件推广的渠道标记
        
        public static int version = 10;//当前版本号 举例 10->1.0
        public static String memberFile = "member.dyxf";//本地会员文件存在的地方
        public static String webRoot = "http://www.52bang.site/dyxf";//可访问的nginx根目录
        //public static String webRoot = "http://192.168.0.15:9527/dyxf";
        public static string memberCodeDir = webRoot + "/member/";
        public static string memberCodeFileSuffix = ".dyxf";



        public static int durationOfTemporaryMembers = 3600;//秒为单位
        public static String registryRootKey = "dyxf"; //注册表key
        public static String localSystemConfigFile = "sc.dyxf";
        public static String systemConfigUrl = webRoot + "/"+ localSystemConfigFile;//系统配置文件的路径

        public static String resourceFileNameSuffix = ".dyxf"; //这个不能放在下面变量的下面，要不顺序初始化，会造成这个没被赋值
        public static String resourceFileNameWithSuffix = "resource"+ resourceFileNameSuffix;//资源文件默认的文件名
        

        //系统使用的参数，无需关注
        public static bool isFirstShownForInitForm = false;
        public static bool isFirstShownForMainForm = false;
        public static bool isNormalCloseInitForm = false;

        public static string rsaPrivateKey = "<RSAKeyValue><Modulus>3eqiBUQgtEzDqjclXcLePahpwi9pxbbYlleJOcrTnAXGyX0+UBPVc1OxKHumzN9u4a3/bolN9FyPyMZ45Jpei0OGdus+kxiQypKODH3/8pVCdo3W7bvK3IBRKa+7U7AXAgZIhybT4TtfjQMe+OUe/orjCT89qX8xBjU3zZ29O/0=</Modulus><Exponent>AQAB</Exponent><P>/BxTABF8RJwcy+qam4N9eDp3QA+1lIvmEvdRLGa52TtUNxP0oJ0kxc+C9nx59lJbQLgNkWOi9ogeTHrzRVkaDw==</P><Q>4VcPrv+A3jvaLUehlNcAjyItxByyNhQYsXt/fEYRcG1itXNQA9fScW8NaAOhbrGMg5rAs5bD6II+01y1aplFMw==</Q><DP>Yuf9zAYQGZ6hUYK9mwsv+y38wL4o/5kO7xvl1aSLfuTeuijzDNv5pD0v5OGau38925sZf5N2SH/IWzrVG7zEEw==</DP><DQ>lBAWmA/+ZwfAxfvJKflTvrjghXmth2cRCp1xGQEZOFxHfZ51NvE6r5oenvezvP4gq+ClOduYglACY/MIqTBojQ==</DQ><InverseQ>gkLAf5QdHPIgKm1NccjzdnyJfxRuO2D1VXX2Y6gqA7xG4UZrLVltytbeiCIvJB4NI9JMG5pnav3Qn8GiFy633Q==</InverseQ><D>MsdBk5rnMNpv2z8LGc1BNTKYIIrg1RDltmEJUWQLz6OyvOAfpgsjyGPaIb1JiY+Gu7UowY5BfCzB6dsgRo7cGux0aSjr9WhohmKNE7jwpx7g+3VYw5VPjbUzR4PJ24Q0sJKQGjvipAGV2rmAcIajrC57SkOBqHkk34O4oDqZNLE=</D></RSAKeyValue>";


        //邮箱配置
        public static String FROM_MAIL = "1633545776@qq.com";//发件人账号
        public static String MAIL_STMP_HOST = "smtp.qq.com";

        public static String MAIL_FROM_PWD = "dgjpcwxnccdhdiih";//stmp 授权码
        public static String MAIL_STMP_PORT = "25";
        public static String MAIL_FROM_MAIL_NAME = "管理员";//发件人姓名
        public static String TO_MAIL = "1633545776@qq.com";//收件人账号

    }
}
