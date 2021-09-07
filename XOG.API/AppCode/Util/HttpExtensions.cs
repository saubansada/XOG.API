using System;
using System.Web;

namespace XOG.Util
{
    public static class HttpExtensions
    {
        public static string GetAbsolutePathWithQuery(this HttpRequestBase request)
        {
            return GetAbsolutePathWithQuery(request.Url);
        }

        public static string GetAbsolutePathWithQuery(this Uri requestUrl)
        {
            return  requestUrl.AbsolutePath + requestUrl.Query;
        }

        public static string GetReturnUrl(this HttpRequestBase request, string fallBackUrl)
        {
            return  "/" + request.QueryString["returnUrl"] != null ? request.QueryString["returnUrl"] : fallBackUrl; 
        }
    }
}