//using System.Linq;
//using System.Security.Claims;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Optimization;
//using System.Web.Routing;
//using System.Collections.Generic;
//using XOG.Factories;
//using XOG.Helpers;
//using XOG.SettingsHelpers;
//using XOG.Util;

//namespace XOG.Abstracts
//{
//    public abstract class AppViewPage<TModel> : WebViewPage<TModel>
//    {
//        protected AppUserPrincipal CurrentUser
//        {
//            get
//            {
//                return new AppUserPrincipal(this.User as ClaimsPrincipal);
//            }
//        }

//        protected string Direction
//        {
//            get
//            {
//                return CookiesHelper.GetCookie(Constants.Keys.CurrentCultureDirectionCookieKey);
//            }
//        }

//        protected string Locale
//        {
//            get
//            {
//                return CookiesHelper.GetCookie(Constants.Keys.CurrentCultureCookieKey);
//            }
//        }

//        protected string LocaleName
//        {
//            get
//            {
//                return LanguageHelper.GetLanguages().FirstOrDefault(c => c.Locale == Locale)?.Name;
//            }
//        }

//        protected string Theme
//        {
//            set
//            {
//                Session["Theme"] = value;
//                Layout = ThemeHelper.GetTheme(value);
//            }
//        }

//        protected string LogoUrl
//        {
//            get
//            {
//                return Url.Content(AppConfig.LogoRelativeURL);
//            }
//        }

//        public string GetGraphics(string path)
//        {
//            return Url.Content(AppConfig.GetContentGraphics("Graphics", Session["Theme"].ToString()) + "/" + path);
//        }


//        protected static string Language(string key)
//        {
//            return LanguageHelper.GetKey(key);
//        }

//        protected static string Language(string key, string locale)
//        {
//            return LanguageHelper.GetKey(key, locale);
//        }

//        protected static IHtmlString ScriptRender(string bundleName)
//        {
//            return Scripts.Render($"~/Script_{bundleName}");// + ThemeHelper.GetCurrentBundleVersion());
//        }

//        protected static IHtmlString StyleRender(string theme)
//        {
//            return Styles.Render($"~/Theme_{theme}");// + ThemeHelper.GetCurrentBundleVersion());
//        }

//        protected static string CompareAndGet(string text, string compareText, string returnText)
//        {
//            return text.Equals(compareText) ? returnText : "";
//        }

//        protected static bool isFromApp(HttpRequestBase request)
//        {
//            bool formCriteria = request.Form["isRequestFromApp"] != null && request.Form["isRequestFromApp"] == "true";
//            bool queryCrietera = request.QueryString["isRequestFromApp"] != null && request.QueryString["isRequestFromApp"] == "true";
//            return formCriteria || queryCrietera;
//        }

//    }

//    public static class PageExtensions
//    {
//        public static RouteValueDictionary ToAdminRouteDictionary(this object obj, params string[] routeValues)
//        {
//            return obj.ToAdminRouteDictionary(-1, routeValues);
//        }

//        public static RouteValueDictionary ToAdminRouteDictionary(this object obj, long currentPage, params string[] routeValues)
//        {
//            List<string> list = new List<string>(routeValues);

//            list.Add("Area:Admin");

//            if (currentPage > -1)
//            {
//                list.Add("CurrentPage:" + currentPage);
//            }

//            return obj.ToRouteValueDictionary(list.ToArray());
//        }
//    }

//    public abstract class AppViewPage : AppViewPage<dynamic>
//    {
//    }
//}
