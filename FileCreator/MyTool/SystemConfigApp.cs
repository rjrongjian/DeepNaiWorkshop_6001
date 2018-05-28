using DeepNaiWorkshop_6001.MyTool;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileCreator.MyTool
{
    public class SystemConfigApp
    {
       
        public static string rsaPublicKey = "<RSAKeyValue><Modulus>3eqiBUQgtEzDqjclXcLePahpwi9pxbbYlleJOcrTnAXGyX0+UBPVc1OxKHumzN9u4a3/bolN9FyPyMZ45Jpei0OGdus+kxiQypKODH3/8pVCdo3W7bvK3IBRKa+7U7AXAgZIhybT4TtfjQMe+OUe/orjCT89qX8xBjU3zZ29O/0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
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
        /// 会员文件加密方式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EncodeForMemberFile(string str)
        {
            byte[] bs = Encoding.UTF8.GetBytes(str);
            byte[] bs2 = new byte[bs.Length];
            //倒叙
            for (int i = bs.Length - 1; i >= 0; i--)
            {
                bs2[bs2.Length - i - 1] = bs[i];
            }
            if (bs2.Length >= 3)
            {
                byte t = bs2[0];
                bs2[0] = bs[2];
                bs2[2] = t;
            }

            //压缩bcd，然后在base64

            return Base64Encode(System.Text.Encoding.UTF8.GetString(bs2));
        }

        /// <summary>
        /// 系统文件加密方式
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string EncodeForSysconfig(string str)
        {

            /*
            byte[] bs = Encoding.UTF8.GetBytes(str);
            byte[] bs2 = new byte[bs.Length];
            //倒叙
            for (int i = bs.Length - 1; i >= 0; i--)
            {
                bs2[bs2.Length-i-1] = bs[i];
            }
            if (bs2.Length >= 3)
            {
                byte t = bs2[0];
                bs2[0] = bs[2];
                bs2[2] = t;
            }
            */

            //压缩bcd，然后在base64
            return RsaEncrypt(str, SystemConfigApp.rsaPublicKey);

        }


        public static string RsaEncrypt(string rawInput, string publicKey)
        {
            if (string.IsNullOrEmpty(rawInput))
            {
                return string.Empty;
            }

            if (string.IsNullOrWhiteSpace(publicKey))
            {
                throw new ArgumentException("Invalid Public Key");
            }

            using (var rsaProvider = new RSACryptoServiceProvider())
            {
                var inputBytes = Encoding.UTF8.GetBytes(rawInput);//有含义的字符串转化为字节流
                rsaProvider.FromXmlString(publicKey);//载入公钥
                int bufferSize = (rsaProvider.KeySize / 8) - 11;//单块最大长度
                var buffer = new byte[bufferSize];
                using (MemoryStream inputStream = new MemoryStream(inputBytes),
                     outputStream = new MemoryStream())
                {
                    while (true)
                    { //分段加密
                        int readSize = inputStream.Read(buffer, 0, bufferSize);
                        if (readSize <= 0)
                        {
                            break;
                        }

                        var temp = new byte[readSize];
                        Array.Copy(buffer, 0, temp, 0, readSize);
                        var encryptedBytes = rsaProvider.Encrypt(temp, false);
                        outputStream.Write(encryptedBytes, 0, encryptedBytes.Length);
                    }
                    return Convert.ToBase64String(outputStream.ToArray());//转化为字节流方便传输
                }
            }
        }


        public static void T1()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            //生成公钥XML字符串  
            string publicKeyXmlString = rsa.ToXmlString(false);
            //生成私钥XML字符串  
            string privateKeyXmlString = rsa.ToXmlString(true);
            Console.WriteLine("公钥："+publicKeyXmlString );
            Console.WriteLine("私钥："+ privateKeyXmlString);
        }
    }
}
