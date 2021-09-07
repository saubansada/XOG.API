using System.Web.Mvc;
using System.Web.Routing;

namespace XOG
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "default",
                url: "MyAdmin/{*url}",
                defaults: new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "admin",
                url: "admin/{*url}",
                defaults: new { controller = "Home", action = "Admin", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "init",
               url: "init",
               defaults: new { controller = "Home", action = "Init", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "angualr",
               url: "{*url}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }

    }
}
