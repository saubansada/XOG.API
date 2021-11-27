using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using XOG.Factories;

namespace XOG.AppCode.Filters
{
    public sealed class TwoFactorAhorize : AuthorizeAttribute
    {
        public override async Task OnAuthorizationAsync(HttpActionContext actionContext, System.Threading.CancellationToken cancellationToken)
        {
            #region Get userManager
            var userManager = HttpContext.Current.GetOwinContext().Get<ApplicationUserManager>();
            if (userManager == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, new ResponseData
                {
                    Code = 100,
                    Message = "Failed to authenticate user."
                });
                return;
            }
            #endregion

            var principal = actionContext.RequestContext.Principal as ClaimsPrincipal;

            #region Get current user
            var user = await userManager.FindByNameAsync(principal?.Identity?.Name);
            if (user == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, new ResponseData
                {
                    Code = 100,
                    Message = "Failed to authenticate user."
                });
                return;
            }
            #endregion

            #region Validate Two-Factor Authentication
            if (user.TwoFactorEnabled)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, new ResponseData
                {
                    Code = 101,
                    Message = "User must be authenticated using Two-Factor Authentication."
                });
            }
            #endregion

            return;
        }
    }

    public class ResponseData
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }

}