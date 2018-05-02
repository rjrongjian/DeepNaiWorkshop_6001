using DeepNaiWorkshop_6001.MyTool.HttpCode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    class HttpCodeUtil
    {
        private static string userAgent = UserAgent.randomUserAgent();
        /// <summary>
        /// 404的情况或者无法连接服务器会返回正常提示
        /// </summary>
        /// <param name="url"></param>
        /// <param name="cookie"></param>
        /// <returns></returns>
        public static string GetRequest(string url,string cookie)
        {
            try
            {
                HttpHelpers httpHelpers = new HttpHelpers();
                HttpResults httpResults = new HttpResults();
                string reString = string.Empty;
                string uRL = url;
                httpResults = httpHelpers.GetHtml(new HttpItems
                {
                    URL = uRL,
                    UserAgent = userAgent,
                    Cookie = string.IsNullOrWhiteSpace(cookie) ? string.Empty : cookie,
                    Allowautoredirect = true,
                    ContentType = "text/html;charset=UTF-8",
                    Encoding = Encoding.UTF8 //这个必须和所有服务器统一，要不读过来的数据最开头会多一个不可解析的字符
                });
                reString = httpResults.Html;
                //Console.WriteLine("获取的原始信息："+ reString);
                return reString;
            }
            catch (Exception)
            {

                return null;
            }
            
        }

        public static string GetRequestHeader(string url,string headerName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "HEAD";
            request.AllowAutoRedirect = false;
            HttpWebResponse reponse = (HttpWebResponse)request.GetResponse();
            string value = reponse.GetResponseHeader(headerName);
            return value;
        }

/*
        private string HttpPost(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            request.CookieContainer = cookie;
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            response.Cookies = cookie.GetCookies(response.ResponseUri);
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }
*/
        /// <summary>
        /// 只能用此方法获取加密数据，上面的方法会在响应开头增加一个不能识别的字符？
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="postDataStr"></param>
        /// <returns></returns>
        public static string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream myResponseStream = response.GetResponseStream())
            {
                using (StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8")))
                {
                    string retString = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();
                    return retString;
                }
            }
        }
    }
}
