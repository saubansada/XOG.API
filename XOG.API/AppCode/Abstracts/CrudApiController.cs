using Microsoft.AspNet.Identity;
using XOG.Factories;
using XOG.Helpers;
using XOG.SettingsHelpers;
using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;
using System.Web.Http;
using XOG.AppCode.Models.FilterModels;
using System.Threading.Tasks;
using XOG.AppCode.Models;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Abstracts
{
    public abstract class CrudApiController<T1, T2> : ApiController 
    { 
        public abstract IHttpActionResult List([FromUri] T1 filter);

        public abstract IHttpActionResult GetSelectListAsync([FromUri] T1 filter);

        public abstract IHttpActionResult Get(int id);

        public abstract Task<IHttpActionResult> AddAsync(T2 request);

        public abstract Task<IHttpActionResult> EditAsync(T2 request);

        public abstract Task<IHttpActionResult> DeleteAsync(int id);

        //protected string Direction
        //{
        //    get
        //    {
        //        return CookiesHelper.GetCookie(Constants.Keys.CurrentCultureDirectionCookieKey);
        //    }
        //}

        //protected string Locale
        //{
        //    get
        //    {
        //        return CookiesHelper.GetCookie(Constants.Keys.CurrentCultureCookieKey);
        //    }
        //}

        //protected string LocaleName
        //{
        //    get
        //    {
        //        return LanguageHelper.GetLanguages().FirstOrDefault(c => c.Locale == Locale)?.Name;
        //    }
        //}

        //protected void AddErrors(IdentityResult result)
        //{
        //    foreach (var error in result.Errors)
        //    {
        //        ModelState.AddModelError("", error);
        //    }
        //}

        //protected static string Language(string key)
        //{
        //    return LanguageHelper.GetKey(key);
        //}

        //protected static string Language(string key, string locale)
        //{
        //    return LanguageHelper.GetKey(key, locale);
        //}

        //protected ActionResult RedirectToLocal(string url = "", string action = "Index", string controller = "Home")
        //{
        //    return Redirect(GetRedirectUrl(url, action, controller));
        //} 


    }
}