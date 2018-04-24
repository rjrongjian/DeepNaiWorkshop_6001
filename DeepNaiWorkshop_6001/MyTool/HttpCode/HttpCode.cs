﻿/* 
 * 主版本号:v3.9
 * 次版本号: 16.10.24(更新日期)
 * 当前版本:v3.9.16.10.24
 * 玄机网C# 基类库 Http请求类
 * 基础功能1:基于HttpWebRequest方式 同步/异步 提交数据 包含(Get/Post)
 * 基础功能2:基于Wininet系统API方式提交数据 包含(Get/Post)
 * 基础功能3:集合常用处理方法.处理页面结果/HTML数据更快捷
 * 
 * 
 * 使用HttpCode时,请先引用 System.Web 
 * 如需使用系统自带的Json转换类库,则需要引用  System.Web.Extensions( Framework 2.0不需要 )   具体方法请参考下文链接 与注释
 * http://bbs.msdn5.com/thread-11-1-1.html 
 * 
 * 修正长度为0时的编码解析错误. 
 * 增加HttpItems中 AutoRedirectMax 如果返回内容为 : 如提示"尝试自动重定向的次数太多" 请设置本属性为true
 * 更改默认UserAgent为 Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.9 Safari/537.36
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.IO.Compression;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Security.Cryptography;
//using System.Web.Script.Serialization; //Framework 2.0 下无效可删除  4.0需要本功能请自行开放.
/*    
    使用系统自带的Json转换C#实体类功能时
    请手动再"引用"功能中加入   System.Web.Extensions
 */
namespace DeepNaiWorkshop_6001.MyTool.HttpCode
{
    /// <summary>
    /// Http请求操作类 
    /// </summary>
    public class HttpHelpers
    {
        #region 私有变量
        /// <summary>
        /// HttpWebRequest对象用来发起请求
        /// </summary>
        private HttpWebRequest request = null;
        /// <summary>
        /// 获取响应流的数据对象
        /// </summary>
        private HttpWebResponse response = null;
        /// <summary>
        /// 结果参数
        /// </summary>
        private HttpResults result = new HttpResults();
        /// <summary>
        /// 应答结果承载的内存流
        /// </summary>
        private MemoryStream _stream;
        /// <summary>
        /// 承载读取数据流
        /// </summary>
        private byte[] RawResponse;
        #endregion

        #region 同步方法
        /// <summary>
        /// 采用httpwebrequest方式访问网络,根据传入的URl地址，得到响应的数据字符串。
        /// </summary>
        /// <param name="objHttpItems">参数列表</param>
        /// <param name="cookie">自动维护的字符串cookie</param>
        /// <returns>HttpResults 为返回结果</returns>
        public HttpResults GetHtml(HttpItems objHttpItems, ref string cookie)
        {
            //调用专门读取数据的类
            HttpResults res = GetHttpRequestData(objHttpItems);
            cookie = new XJHTTP().UpdateCookie(cookie, res.Cookie);
            res.Cookie = cookie;
            return res;
        }

        ///<summary>
        ///采用httpwebrequest方式访问网络,根据传入的URl地址，得到响应的数据字符串。
        ///</summary>
        ///<param name="objHttpItems">参数列表</param>
        ///<returns>HttpResults 为返回结果</returns>
        public HttpResults GetHtml(HttpItems objHttpItems)
        {
            //调用专门读取数据的类
            return GetHttpRequestData(objHttpItems);
        }
        /// <summary>
        /// 根据传入的数据，得到相应页面数据
        /// </summary>
        /// <param name="objHttpItems">请求设置参数</param>
        /// <returns>请求结果</returns>
        private HttpResults GetHttpRequestData(HttpItems objHttpItems)
        {

            try
            {
                #region 设置请求参数
                SetRequest(objHttpItems);
                #endregion

                #region 获得应答结果
                response = (HttpWebResponse)request.GetResponse();
                return GetResponesInfo(ref objHttpItems);
                #endregion
            }
            catch (WebException ex)
            {
                #region 获取异常数据与结果
                result.Html = ex.Message;
                response = (HttpWebResponse)ex.Response;
                if (response != null)
                {
                    result.StatusCode = response.StatusCode;
                    result.StatusDescription = ex.Message;
                    try
                    {
                        return GetResponesInfo(ref objHttpItems);
                    }
                    catch
                    {
                        return result;
                    }

                }
                else
                {
                    result.StatusCode = HttpStatusCode.NotFound;
                    result.StatusDescription = ex.Message;
                }
                #endregion
            }

            return result;
        }
        #endregion

        #region 解析数据与处理数据

        /// <summary>
        /// 处理响应结果
        /// </summary>
        /// <param name="objHttpItems">请求设置参数</param>
        /// <returns></returns>
        private HttpResults GetResponesInfo(ref HttpItems objHttpItems)
        {

            #region 设置返回结果
            result.StatusCode = response.StatusCode;
            result.StatusDescription = response.StatusDescription;
            result.Header = response.Headers;
            if (response.Cookies != null)
            {
                result.CookieCollection = response.Cookies;
            }
            if (response.ResponseUri != null)
            {
                result.ResponseUrl = response.ResponseUri.ToString();
            }
            if (response.Headers["set-cookie"] != null)
            {
                //清理垃圾Cookie信息
                result.Cookie = new XJHTTP().ClearCookie(response.Headers["set-cookie"]);
                result.RawCookie = response.Headers["set-cookie"];

            }
            //处理返回值Container
            result.Container = objHttpItems.Container;
            #endregion

            #region 急速请求,不解析结果数据

            if (objHttpItems.ResultType == ResultType.So)
            {
                return result;
            }
            #endregion

            #region 应答结果转换为内存数据

            using (_stream = new MemoryStream())
            {
                //GZIIP处理
                if (response.ContentEncoding != null && response.ContentEncoding.Equals("gzip", StringComparison.InvariantCultureIgnoreCase))
                {
                    _stream = GetMemoryStream(new GZipStream(response.GetResponseStream(), CompressionMode.Decompress));
                }
                else
                {
                    _stream = GetMemoryStream(response.GetResponseStream());

                }
                //获取Byte
                RawResponse = _stream.ToArray();
            }
            #endregion

            #region 如果设置返回结果类型则返回Byte数据

            if (objHttpItems.ResultType == ResultType.Byte)
            {
                result.ResultByte = RawResponse;
                return result;
            }
            #endregion

            #region 处理编码结果

            if (objHttpItems.Encoding == null)//如果用户没有指定编码格式
            {
                try
                {
                    GetEncodingNew(ref objHttpItems);
                }
                catch
                {
                    //从流中识别
                    Encoding ed = StreamEncoder.GetEncodingFromBytes(RawResponse);
                    if (ed != null)
                    {
                        objHttpItems.Encoding = ed;
                    }
                    else
                    {
                        //强制UTF8
                        objHttpItems.Encoding = Encoding.UTF8;
                    }
                }

            }
            //得到返回的HTML
            try
            {
                if (RawResponse.Length > 0)
                {
                    result.Html = objHttpItems.Encoding.GetString(RawResponse);
                }
                else
                {
                    result.Html = "HttpCode接收数据长度为0.请检查数据包.当前状态码:" + result.StatusCodeNum.ToString() + result.Html;
                }
                response.Close();
            }
            catch
            {
                result.Html = "HttpCode接收数据出现异常..请检查数据包.当前状态码:" + result.StatusCodeNum.ToString() + result.Html;
            }

            #endregion
            return result;
        }
        /// <summary>
        /// 识别编码
        /// </summary>
        /// <param name="objHttpItems"></param>
        private void GetEncodingNew(ref HttpItems objHttpItems)
        {
            string temp = Encoding.Default.GetString(RawResponse, 0, RawResponse.Length);
            Match meta = Regex.Match(temp, "<meta([^<]*)charset=([^<]*)[\"']", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            string charter = (meta.Groups.Count > 2) ? meta.Groups[2].Value : string.Empty;
            if (charter.IndexOf("\"") > 0)
            {
                charter = charter.Split('\"')[0];
            }
            if (charter.IndexOf(" ") > 0)
            {
                charter = charter.Split(' ')[0];
            }
            charter = charter.Replace("\"", string.Empty).Replace("'", string.Empty).Replace(";", string.Empty);
            if (charter.Length > 0)
            {
                charter = charter.ToLower().Replace("iso-8859-1", "gbk");
                if (string.IsNullOrEmpty(response.CharacterSet.Trim()) || response.CharacterSet.Trim().Contains("utf"))
                {
                    objHttpItems.Encoding = Encoding.UTF8;
                }
                else
                {
                    Encoding ed = StreamEncoder.GetEncodingFromBytes(RawResponse);
                    if (ed != null)
                    {
                        objHttpItems.Encoding = ed;
                    }
                    else
                    {
                        //强制UTF8
                        objHttpItems.Encoding = Encoding.UTF8;
                    }

                }
            }
            else
            {

                if (response.CharacterSet != null)
                {
                    if (response.CharacterSet.ToLower().Trim() == "iso-8859-1")
                    {
                        // encoding = Encoding.GetEncoding("gbk"); 直接改为UTF8编码
                        objHttpItems.Encoding = Encoding.GetEncoding("gbk");//Encoding.UTF8;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(response.CharacterSet.Trim()) || response.CharacterSet.Trim().Contains("utf"))
                        {
                            objHttpItems.Encoding = Encoding.UTF8;
                        }
                        else
                        {
                            objHttpItems.Encoding = Encoding.GetEncoding(response.CharacterSet);
                        }
                    }
                }
                else
                {
                    Encoding ed = StreamEncoder.GetEncodingFromBytes(RawResponse);
                    if (ed != null)
                    {
                        objHttpItems.Encoding = ed;
                    }
                    else
                    {
                        //强制UTF8
                        objHttpItems.Encoding = Encoding.UTF8;
                    }
                }
            }
        }

        #endregion

        #region 异步方法

        /// <summary>
        /// 采用异步方式访问网络,根据传入的URl地址，得到响应的数据字符串。
        /// </summary>
        /// <param name="objHttpItems">参数列表</param>
        /// <param name="callBack">完成后的回调函数</param>
        public void AsyncGetHtml(HttpItems objHttpItems, Action<HttpResults> callBack)
        {
            //调用专门读取数据的类
            AsyncGetHttpRequestData(objHttpItems, callBack);
        }
        /// <summary>
        /// 异步获取响应数据
        /// </summary>
        /// <param name="result"></param>
        private void AsyncResponseData(IAsyncResult result)
        {
            AsyncHttpItem hrt = result.AsyncState as AsyncHttpItem;
            if (System.Threading.Interlocked.Increment(ref hrt.atomLock) != 1)
                return;
            try
            {
                response = (HttpWebResponse)hrt.request.EndGetResponse(result);
                hrt.result = GetResponesInfo(ref hrt.objHttpCodeItem);
                hrt.result.Cookie = new XJHTTP().UpdateCookie(hrt.objHttpCodeItem.Cookie, hrt.result.Cookie);

            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
                hrt.result.Html = ex.Message;
                if (response != null)
                {
                    hrt.result.StatusCode = response.StatusCode;
                    hrt.result.StatusDescription = ex.Message;
                    try
                    {
                        hrt.result = GetResponesInfo(ref hrt.objHttpCodeItem);
                    }
                    catch
                    {

                    }

                }
                else
                {
                    hrt.result.StatusCode = HttpStatusCode.NotFound;
                    hrt.result.StatusDescription = ex.Message;
                }

            }
            hrt.callBack.Invoke(hrt.result);
        }

        /// <summary>
        ///  根据传入的参数,来异步发起请求
        /// </summary>
        /// <param name="objItems">请求设置参数</param>
        /// <param name="callBack">回调函数</param>
        private void AsyncGetHttpRequestData(HttpItems objItems, Action<HttpResults> callBack)
        {
            AsyncHttpItem hrt = new AsyncHttpItem();
            SetRequest(objItems);
            hrt.objHttpCodeItem = objItems;
            hrt.request = request;
            hrt.callBack = callBack;
            try
            {
                IAsyncResult m_ar = hrt.request.BeginGetResponse(AsyncResponseData, hrt);
                System.Threading.ThreadPool.RegisterWaitForSingleObject(m_ar.AsyncWaitHandle,
                    TimeoutCallback, hrt, objItems.Timeout, true);
            }
            catch
            {
                hrt.result.Html = "TimeOut";
            }
        }
        /// <summary>
        /// 超时回调
        /// </summary>
        /// <param name="state">HttpRequest对象</param>
        /// <param name="timedOut">超时判断</param>
        void TimeoutCallback(object state, bool timedOut)
        {
            AsyncHttpItem pa = state as AsyncHttpItem;
            if (timedOut)
            {
                if (System.Threading.Interlocked.Increment(ref pa.atomLock) == 1)
                {
                    pa.result.Html = "TimeOut";
                    pa.callBack.Invoke(pa.result);
                }
            }
        }
        #endregion

        #region 通用数据方法
        /// <summary>
        /// 获取流中的数据转换为内存流处理
        /// </summary>
        /// <param name="streamResponse">流</param>
        private MemoryStream GetMemoryStream(Stream streamResponse)
        {
            MemoryStream _stream = new MemoryStream();
            int Length = 256;
            Byte[] buffer = new Byte[Length];
            int bytesRead = streamResponse.Read(buffer, 0, Length);
            while (bytesRead > 0)
            {
                _stream.Write(buffer, 0, bytesRead);
                bytesRead = streamResponse.Read(buffer, 0, Length);
            }
            return _stream;
        }
        /// <summary>
        /// 反射修改useUnsafeHeaderParsing
        /// </summary>
        /// <param name="useUnsafe">设置的参数值</param>
        /// <returns></returns>
        private bool SetAllowUnsafeHeaderParsing20(bool useUnsafe)
        {
            System.Reflection.Assembly aNetAssembly = System.Reflection.Assembly.GetAssembly(typeof(System.Net.Configuration.SettingsSection));
            if (aNetAssembly != null)
            {

                Type aSettingsType = aNetAssembly.GetType("System.Net.Configuration.SettingsSectionInternal");
                if (aSettingsType != null)
                {

                    object anInstance = aSettingsType.InvokeMember("Section",
                      System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.NonPublic, null, null, new object[] { });

                    if (anInstance != null)
                    {
                        System.Reflection.FieldInfo aUseUnsafeHeaderParsing = aSettingsType.GetField("useUnsafeHeaderParsing", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                        if (aUseUnsafeHeaderParsing != null)
                        {
                            aUseUnsafeHeaderParsing.SetValue(anInstance, useUnsafe);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// 为请求准备参数
        /// </summary>
        ///<param name="objHttpItems">参数列表</param> 
        private void SetRequest(HttpItems objHttpItems)
        {
            #region 处理服务器提交协议错误
            if (objHttpItems.UseUnsafe)
            {
                SetAllowUnsafeHeaderParsing20(objHttpItems.UseUnsafe);
            }
            #endregion

            #region 设置证书
            SetCer(objHttpItems);
            #endregion

            #region 设置Header参数 如果有则添加,如果失败,则重置数据
            if (objHttpItems.Header.Count > 0)
            {
                try
                {
                    request.Headers = objHttpItems.Header;
                }
                catch
                {
                    request.Headers = new WebHeaderCollection();
                }
            }
            #endregion
            if (objHttpItems.AutoRedirectMax)
            {
                request.MaximumAutomaticRedirections = 9999;
            }
           
            #region 添加 Ajax数据头

            if (objHttpItems.IsAjax)
            {
                request.Headers.Add("x-requested-with: XMLHttpRequest");
            }
            #endregion

            #region 设置代理

            SetProxy(objHttpItems);
            #endregion

            #region 通用属性设置
            //请求方式Get或者Post
            request.Method = objHttpItems.Method;
            request.Timeout = objHttpItems.Timeout;
            request.ReadWriteTimeout = objHttpItems.ReadWriteTimeout;
            //Accept
            request.Accept = objHttpItems.Accept;
            //ContentType返回类型
            request.ContentType = objHttpItems.ContentType;
            //UserAgent客户端的访问类型，包括浏览器版本和操作系统信息
            request.UserAgent = objHttpItems.UserAgent;


            // 如果设置编码,则从设置结果读取
            SetEncoding(objHttpItems);
            //设置Cookie
            SetCookie(objHttpItems);
            //来源地址
            request.Referer = objHttpItems.Referer;
            //是否执行跳转功能 
            request.AllowAutoRedirect = objHttpItems.Allowautoredirect;
            //设置最大连接
            if (objHttpItems.Connectionlimit > 0)
            {
                request.ServicePoint.ConnectionLimit = objHttpItems.Connectionlimit;
                System.Net.ServicePointManager.DefaultConnectionLimit = 1024;
            }
            //设置 post数据在大于1024时是否分包
            request.ServicePoint.Expect100Continue = objHttpItems.Expect100Continue;
            #endregion

            #region 如果当前为Post则设置并提交数据
            SetPostData(objHttpItems);
            #endregion
        }
        /// <summary>
        /// 设置证书
        /// </summary>
        /// <param name="objHttpItems">请求设置参数</param>
        private void SetCer(HttpItems objHttpItems)
        {
            if (!string.IsNullOrEmpty(objHttpItems.CerPath))
            {
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(CheckValidationResult);
                if (objHttpItems.IsEOFError)
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                }
                //初始化对像，并设置请求的URL地址
                request = (HttpWebRequest)WebRequest.Create(GetUrl(objHttpItems.URL));
                //创建证书文件
                X509Certificate objx509 = new X509Certificate(objHttpItems.CerPath);
                //添加到请求里
                request.ClientCertificates.Add(objx509);
            }
            else
            {
                //初始化对像，并设置请求的URL地址
                try
                {
                    request = (HttpWebRequest)WebRequest.Create(GetUrl(objHttpItems.URL));
                }
                catch
                {
                   // throw new Exception("请检查输入的网址!");
                }
            }
        }
        /// <summary>
        /// 设置编码
        /// </summary>
        /// <param name="objHttpItems">Http参数</param>
        private void SetEncoding(HttpItems objHttpItems)
        {
            if (!string.IsNullOrEmpty(objHttpItems.EncodingStr))
            {
                //读取数据时的编码方式
                objHttpItems.Encoding = System.Text.Encoding.GetEncoding(objHttpItems.EncodingStr);
            }
        }
        /// <summary>
        /// 设置Cookie
        /// </summary>
        /// <param name="objHttpItems">Http参数</param>
        private void SetCookie(HttpItems objHttpItems)
        {

            if (!string.IsNullOrEmpty(objHttpItems.Cookie))
            {
                //字符串方式
                request.Headers[HttpRequestHeader.Cookie] = objHttpItems.Cookie;
            }
            if (objHttpItems.CookieCollection != null)
            {
                //CookieCollection方式
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(objHttpItems.CookieCollection);
            }
            if (objHttpItems.Container != null)
            {
                //CookieContainer方式
                request.CookieContainer = objHttpItems.Container;
            }
        }

        /// <summary>
        /// 设置Post数据
        /// </summary>
        /// <param name="objHttpItems">Http参数</param>
        private void SetPostData(HttpItems objHttpItems)
        {
            //验证在得到结果时是否有传入数据
            if (request.Method.Trim().ToLower() == "post")
            {
                //写入Byte类型
                if (objHttpItems.PostDataType == PostDataType.Byte)
                {
                    //验证在得到结果时是否有传入数据
                    if (objHttpItems.PostdataByte != null && objHttpItems.PostdataByte.Length > 0)
                    {
                        request.ContentLength = objHttpItems.PostdataByte.Length;
                        request.GetRequestStream().Write(objHttpItems.PostdataByte, 0, objHttpItems.PostdataByte.Length);
                    }
                }//写入文件
                else if (objHttpItems.PostDataType == PostDataType.FilePath)
                {
                    using (StreamReader r = new StreamReader(objHttpItems.Postdata, objHttpItems.Encoding))
                    {
                        byte[] buffer = objHttpItems.PostEncoding.GetBytes(r.ReadToEnd());
                        request.ContentLength = buffer.Length;
                        request.GetRequestStream().Write(buffer, 0, buffer.Length);
                    }

                }
                else
                {
                    if (!string.IsNullOrEmpty(objHttpItems.Postdata))
                    {
                        //写入字符串数据.如果希望修改提交时的编码.请修改objHttpItems.PostEncoding
                        byte[] buffer = objHttpItems.PostEncoding.GetBytes(objHttpItems.Postdata);
                        request.ContentLength = buffer.Length;
                        request.GetRequestStream().Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
        /// <summary>
        /// 设置代理
        /// </summary>
        /// <param name="objHttpItems">参数对象</param>
        private void SetProxy(HttpItems objHttpItems)
        {
            if (!string.IsNullOrEmpty(objHttpItems.ProxyIp))
            {
                WebProxy myProxy;
                //设置代理服务器
                if (objHttpItems.ProxyIp.Contains(":"))
                {
                    string[] plist = objHttpItems.ProxyIp.Split(':');
                    myProxy = new WebProxy(plist[0].Trim(), Convert.ToInt32(plist[1].Trim()));
                }
                else
                {
                    myProxy = new WebProxy(objHttpItems.ProxyIp, false);
                }
                if (!string.IsNullOrEmpty(objHttpItems.ProxyUserName) && !string.IsNullOrEmpty(objHttpItems.ProxyPwd))
                {
                    myProxy.Credentials = new NetworkCredential(objHttpItems.ProxyUserName, objHttpItems.ProxyPwd);
                }
                request.Proxy = myProxy;
                //设置安全凭证
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
            }
            else
            {
                request.Proxy = null;

            }
        }
        /// <summary>
        /// 回调验证证书问题
        /// </summary>
        /// <param name="sender">流对象</param>
        /// <param name="certificate">证书</param>
        /// <param name="chain">X509Chain</param>
        /// <param name="errors">SslPolicyErrors</param>
        /// <returns>bool</returns>
        public bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            // 总是接受    
            return true;
        }

        /// <summary>
        /// 传入一个正确或不正确的URl，返回正确的URL
        /// </summary>
        /// <param name="URL">url</param>
        /// <returns>
        /// </returns>
        public string GetUrl(string URL)
        {
            if (!(URL.Contains("http://") || URL.Contains("https://")))
            {
                URL = "http://" + URL;
            }
            return URL;
        }

        /// <summary>
        /// 读取返回对象中数据,并返回Image格式图片
        /// </summary>
        /// <param name="hr">GetHtml后的请求结果</param>
        /// <returns></returns>
        public Image GetImg(HttpResults hr)
        {
            return byteArrayToImage(hr.ResultByte);
        }
        /// <summary>
        /// 字节数组生成图片
        /// </summary>
        /// <param name="Bytes">字节数组</param>
        /// <returns>图片</returns>
        public Image byteArrayToImage(byte[] Bytes)
        {
            if (Bytes == null)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream(Bytes))
            {
                Image outputImg = Image.FromStream(ms);
                return outputImg;
            }

        }

        #endregion
    }
   
    /// <summary>
    /// 异步实体类
    /// </summary>
    class AsyncHttpItem
    {
        /// <summary>
        /// 请求结果类
        /// </summary>
        public HttpResults result = new HttpResults();
        /// <summary>
        ///  HttpWebRequest对象用来发起请求
        /// </summary>
        public HttpWebRequest request = null;
        /// <summary>
        /// 异步回调函数
        /// </summary>
        public Action<HttpResults> callBack;
        /// <summary>
        /// 基础请求设置类
        /// </summary>
        public HttpItems objHttpCodeItem;
        /// <summary>
        /// 原子锁
        /// </summary>
        public int atomLock = 0;
    }
}
