using System;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using XOG.AppCode.Helpers;
using XOG.Helpers;

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

            // Token Generation
            //var OAuthBearerOptions = new OAuthBearerAuthenticationOptions();
            //app.UseOAuthBearerAuthentication(OAuthOptions);
            //app.UseOAuthAuthorizationServer(OAuthOptions);

            app.UseOAuthBearerTokens(OAuthOptions);
        }
    }
}