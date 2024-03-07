using System.Web.Mvc;

namespace XOG.Areas.MyAdmin
{
    public class MyAdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MyAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        { 
            context.MapRoute(
                "Admin_default",
                "MyAdmin/{controller}/{action}/{id}",
                new { Controller = "Dashboard", action = "Index", id = UrlParameter.Optional },
                new[] { "XOG.Areas.MyAdmin.Controllers" }
            );
        }
    }
}
