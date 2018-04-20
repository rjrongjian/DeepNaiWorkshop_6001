using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.Model
{
    class SystemConfig
    {
        public static int version = 10;//含义 1.0
        public static string channel = "default";//软件推广的渠道标记
        public SystemConfigJson SystemConfigJson { get; }
        public SystemConfig(SystemConfigJson systemConfigJson)
        {
            SystemConfigJson = systemConfigJson;
        }
    }
}
