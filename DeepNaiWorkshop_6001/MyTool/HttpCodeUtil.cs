using DeepNaiWorkshop_6001.MyTool.HttpCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DeepNaiWorkshop_6001.MyTool
{
    class HttpCodeUtil
    {
        private static string userAgent = UserAgent.randomUserAgent();
        //TODO 测试此方法，如果404会弹什么
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
                    Cookie = string.IsNullOrWhiteSpace(cookie)?string.Empty:cookie,
                    Allowautoredirect = true,
                    ContentType = "application/x-www-form-urlencoded"
                });
                reString = httpResults.Html;
                
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
    }
}
