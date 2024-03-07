using System.Web.Mvc;
using XOG.AppCode.Filters;
using XOG.Filters;

namespace XOG
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute());
            filters.Add(new LanguageSelectorFilter());
        }
    }
}
