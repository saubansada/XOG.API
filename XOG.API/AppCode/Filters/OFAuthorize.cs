using System.Web.Mvc;

namespace XOG.Filters
{
    public sealed class OFAuthorize : AuthorizeAttribute
    {
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            if (!filterContext.HttpContext.User.Identity.IsAuthenticated ||
                    filterContext.HttpContext.User.Identity.Name == null)
            { 
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}
