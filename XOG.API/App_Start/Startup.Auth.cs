using System;
using System.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using IdentityServer3.AccessTokenValidation;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.OAuth;
using Owin;
using XOG.AppCode.Helpers;
using XOG.Factories;
using XOG.Helpers;
using XOG.Models;

namespace XOG
{
    public partial class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }
         
        public static string PublicClientId { get; private set; }
        
        public void ConfigureAuth(IAppBuilder app)
        {
            StartupHelper.CreateAppDBContext(app);
            StartupHelper.CreateApplicationUserManager(app);
            StartupHelper.CreateApplicationSignInManager(app);
            StartupHelper.CreateApplicationRoleManager(app);
            StartupHelper.UseCookieAuthentication(app);
            StartupHelper.UseExternalSignInCookie(app);
            StartupHelper.UseTwoFactorSignInCookie(app);
            StartupHelper.UseTwoFactorRememberBrowserCookie(app);
            StartupHelper.UseMicrosoftAccountAuthentication(app);
            StartupHelper.UseTwitterAuthentication(app);

            PublicClientId = "self";
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                TokenEndpointPath = new PathString("/token"),
                Provider = new AppOAuthProvider(PublicClientId),
                AuthorizeEndpointPath = new PathString("/Account/ExternalLogin"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(4),
                AllowInsecureHttp = true 
            };

            app.UseOAuthBearerTokens(OAuthOptions);
        }
    }
}