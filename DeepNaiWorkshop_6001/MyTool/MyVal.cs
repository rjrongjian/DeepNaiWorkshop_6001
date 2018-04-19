using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    class MyVal
    {
        /// <summary>
        /// Base64加密，采用utf8编码方式加密
        /// </summary>
        /// <param name="source">待加密的明文</param>
        /// <returns>加密后的字符串</returns>
        public static string Base64Encode(string source)
        {
            return Base64Encode(Encoding.UTF8, source);
        }

        /// <summary>
        /// Base64加密
        /// </summary>
        /// <param name="encodeType">加密采用的编码方式</param>
        /// <param name="source">待加密的明文</param>
        /// <returns></returns>
        public static string Base64Encode(Encoding encodeType, string source)
        {
            string encode = string.Empty;
            byte[] bytes = encodeType.GetBytes(source);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = source;
            }
            return encode;
        }

        /// <summary>
        /// Base64解密，采用utf8编码方式解密
        /// </summary>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(string result)
        {
            return Base64Decode(Encoding.UTF8, result);
        }

        /// <summary>
        /// Base64解密
        /// </summary>
        /// <param name="encodeType">解密采用的编码方式，注意和加密时采用的方式一致</param>
        /// <param name="result">待解密的密文</param>
        /// <returns>解密后的字符串</returns>
        public static string Base64Decode(Encoding encodeType, string result)
        {
            string decode = string.Empty;
            byte[] bytes = Convert.FromBase64String(result);
            try
            {
                decode = encodeType.GetString(bytes);
            }
            catch
            {
                decode = result;
            }
            return decode;
        }

        /// <summary>
        /// 会员文件加密方式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EncodeForMemberFile(string str)
        {
            byte[] bs = Encoding.UTF8.GetBytes(str);
            byte[] bs2 = new byte[bs.Length];
            //倒叙
            for(int i = bs.Length - 1; i >= 0; i--)
            {
                bs2[bs2.Length] = bs[i];
            }
            if (bs2.Length >= 3)
            {
                byte t = bs2[0];
                bs2[0] = bs[2];
                bs2[2] = t;
            }

            //压缩bcd，然后在base64

            return MyVal.Base64Encode(System.Text.Encoding.UTF8.GetString(bs2));
        }
        /// <summary>
        /// 会员文件解密方式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DecodeForMemberFile(string str)
        {
            byte[] bs = Encoding.UTF8.GetBytes(MyVal.Base64Decode(str));
            if (bs.Length >= 3)
            {
                byte t = bs[0];
                bs[0] = bs[2];
                bs[2] = t;
            }

            byte[] bs2 = new byte[bs.Length];
            for(int i = bs.Length - 1; i >= 0; i--)
            {
                bs2[bs2.Length] = bs[i];
            }

            return Encoding.UTF8.GetString(bs2);
        }
    }
}
