using DeepNaiWorkshop_6001.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    public class MyVal
    {
       

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
                bs2[bs2.Length - i - 1] = bs[i];
            }

            return Encoding.UTF8.GetString(bs2);
        }

       
        /// <summary>
        /// 系统文件解密方式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string DecodeForSysconfig(string str)
        {
            return RsaDecrypt(str, SystemConfig.rsaPrivateKey);
        }


        public static string RsaDecrypt(string encryptedInput, string privateKey)
        {
            if (string.IsNullOrEmpty(encryptedInput))
            {
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(privateKey))
            {
                throw new ArgumentException("Invalid Private Key");
            }

            using (var rsaProvider = new RSACryptoServiceProvider())
            {
                var inputBytes = Convert.FromBase64String(encryptedInput);
                rsaProvider.FromXmlString(privateKey);
                int bufferSize = rsaProvider.KeySize / 8;
                var buffer = new byte[bufferSize];
                using (MemoryStream inputStream = new MemoryStream(inputBytes),
                     outputStream = new MemoryStream())
                {
                    while (true)
                    {
                        int readSize = inputStream.Read(buffer, 0, bufferSize);
                        if (readSize <= 0)
                        {
                            break;
                        }

                        var temp = new byte[readSize];
                        Array.Copy(buffer, 0, temp, 0, readSize);
                        var rawBytes = rsaProvider.Decrypt(temp, false);
                        outputStream.Write(rawBytes, 0, rawBytes.Length);
                    }
                    return Encoding.UTF8.GetString(outputStream.ToArray());
                }
            }
        }
        /// <summary>
        /// 传输过来的base64字符串上多包含了?，得去掉
        /// </summary>
        /// <param name="base64Str"></param>
        /// <returns></returns>
        public static string format(string base64Str)
        {
            if (string.IsNullOrWhiteSpace(base64Str))
            {
                return "";
            }
            else
            {
                return base64Str.Replace("?", "");
            }
            
        }
        
        public static SystemConfigJson ParseForSystemConfigJson(string content)
        {
            return JsonConvert.DeserializeObject<SystemConfigJson>(MyVal.DecodeForSysconfig(content));
        }

    }
}
