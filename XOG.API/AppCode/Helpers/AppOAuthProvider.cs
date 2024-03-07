using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using XOG.Factories;

namespace XOG.AppCode.Helpers
{
    /// <summary>  
    /// Application OAUTH Provider class.  
    /// </summary>  
    public class AppOAuthProvider : OAuthAuthorizationServerProvider
    {
        #region Private Properties  

        /// <summary>  
        /// Public client ID property.  
        /// </summary>  
        private readonly string _publicClientId;

        /// <summary>  
        /// Database Store property.  
        /// </summary>  
        //private UserManager databaseManager = new UserManager();

        #endregion

        #region Default Constructor method.  

        /// <summary>  
        /// Default Constructor method.  
        /// </summary>  
        /// <param name="publicClientId">Public client ID parameter</param>  
        public AppOAuthProvider(string publicClientId)
        {
            //TODO: Pull from configuration  
            if (publicClientId == null)
            {
                throw new ArgumentNullException(nameof(publicClientId));
            }

            // Settings.  
            _publicClientId = publicClientId;
        }

        #endregion

        #region Grant resource owner credentials override method.  

        /// <summary>  
        /// Grant resource owner credentials overload method.  
        /// </summary>  
        /// <param name="context">Context parameter</param>  
        /// <returns>Returns when task is completed</returns>  
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            string usernameVal = context.UserName;

            string passwordVal = context.Password;

            using (ApplicationUserManager userManager = context.OwinContext.GetUserManager<ApplicationUserManager>())
            {
                ApplicationUser user = await userManager.FindByNameAsync(context.UserName);

                bool twoFactorEnabled = false;

                if (user != null)
                {
                    context.Request.Context.Authentication.SignOut();

                    twoFactorEnabled = await userManager.GetTwoFactorEnabledAsync(user.Id);
                }
                else if (user == null && passwordVal == "")
                {
                    var res = await userManager.CreateAsync(new ApplicationUser { UserName = usernameVal, Email = usernameVal + "@xog.com" });

                    if (res.Succeeded)
                    {
                        user = await userManager.FindByNameAsync(context.UserName);

                        await userManager.AddToRoleAsync(user.Id, "User");
                    }
                    else
                    {
                        context.SetError("Failed to Create User");
                    }
                }

                if (passwordVal == "" || twoFactorEnabled)
                {
                    await userManager.SetTwoFactorEnabledAsync(user.Id, true);

                    var code = await userManager.GenerateTwoFactorTokenAsync(user.Id, "PhoneCode");

                    IdentityResult notificationResult = await userManager.NotifyTwoFactorTokenAsync(user.Id, "PhoneCode", code);

                    if (!notificationResult.Succeeded)
                    {
                        context.SetError("Failed to send OTP");
                    }
                }
                else
                {
                    user = await userManager.FindAsync(usernameVal, passwordVal);

                    if (user == null)
                    {
                        context.SetError("invalid_grant", "The user name or password is incorrect.");

                        return;
                    }
                }

                var claims = new List<Claim>();

                var userInfo = user;

                claims.Add(new Claim(ClaimTypes.Name, userInfo.UserName));

                ClaimsIdentity oAuthClaimIdentity = new ClaimsIdentity(claims, OAuthDefaults.AuthenticationType);

                ClaimsIdentity cookiesClaimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationType);

                var roles_ = userManager.GetRoles(user.Id);

                if(roles_.Count == 0)
                {
                    await userManager.AddToRoleAsync(user.Id, "User");
                    roles_ = userManager.GetRoles(user.Id);
                }

                AuthenticationProperties properties = CreateProperties(userInfo, string.Join(",", roles_));

                AuthenticationTicket ticket = new AuthenticationTicket(oAuthClaimIdentity, properties);

                context.Validated(ticket);

                context.Request.Context.Authentication.SignIn(oAuthClaimIdentity);

                context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            }
        }

        #endregion

        #region Token endpoint override method.  

        /// <summary>  
        /// Token endpoint override method  
        /// </summary>  
        /// <param name="context">Context parameter</param>  
        /// <returns>Returns when task is completed</returns>  
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            foreach (KeyValuePair<string, string> property in context.Properties.Dictionary)
            {
                // Adding.  
                context.AdditionalResponseParameters.Add(property.Key, property.Value);
            }

            // Return info.  
            return Task.FromResult<object>(null);
        }

        #endregion

        #region Validate Client authntication override method  

        /// <summary>  
        /// Validate Client authntication override method  
        /// </summary>  
        /// <param name="context">Contect parameter</param>  
        /// <returns>Returns validation of client authentication</returns>  
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            // Resource owner password credentials does not provide a client ID.  
            if (context.ClientId == null)
            {
                // Validate Authoorization.  
                context.Validated();
            }

            // Return info.  
            return Task.FromResult<object>(null);
        }

        #endregion

        #region Validate client redirect URI override method  

        /// <summary>  
        /// Validate client redirect URI override method  
        /// </summary>  
        /// <param name="context">Context parmeter</param>  
        /// <returns>Returns validation of client redirect URI</returns>  
        public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
        {
            // Verification.  
            if (context.ClientId == _publicClientId)
            {
                // Initialization.  
                Uri expectedRootUri = new Uri(context.Request.Uri, "/");

                // Verification.  
                if (expectedRootUri.AbsoluteUri == context.RedirectUri)
                {
                    // Validating.  
                    context.Validated();
                }
            }

            // Return info.  
            return Task.FromResult<object>(null);
        }

        #endregion

        #region Create Authentication properties method.  

        /// <summary>  
        /// Create Authentication properties method.  
        /// </summary>  
        /// <param name="userName">User name parameter</param>  
        /// <returns>Returns authenticated properties.</returns>  
        public static AuthenticationProperties CreateProperties(ApplicationUser user, string roles)
        {

            string dateTime = DateTime.Now.ToString();
            // Settings.  
            IDictionary<string, string> data = new Dictionary<string, string>
                                               {
                                                   { "userId", user.Id },
                                                   { "requireOTP" , user.TwoFactorEnabled.ToString() },
                                                   { "userName", user.UserName },
                                                   { "roles", roles },
                                                   { "logged_in", dateTime }
                                               };
            // Return info.  
            return new AuthenticationProperties(data);
        }

        #endregion
    }
}