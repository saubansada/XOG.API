using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using XOG.Factories;
using XOG.Models.ViewModels.RequestViewModels.Data;

namespace XOG.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthenticationController : ApiController
    { 
        protected const string XsrfKey = "XsrfId";
        public ApplicationRoleManager _roleManager;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;

        public AuthenticationController()
        { }

        public AuthenticationController(ApplicationUserManager userManager, ApplicationSignInManager signInManager, ApplicationRoleManager roleManager)
        {
            RoleManager = _roleManager;
            SignInManager = _signInManager;
            UserManager = _userManager;
        }
         

        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationRoleManager RoleManager
        {
            get
            {
                return _roleManager ?? HttpContext.Current.GetOwinContext().Get<ApplicationRoleManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        [Authorize]
        [HttpGet]
        public IHttpActionResult GetSuggestion(string search)
        {
            List<String> obj = null;
            return Json(obj);
        }

        [HttpPost]
        [Route("logout")]
        public async Task<IHttpActionResult> LogoutAsync()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userName = HttpContext.Current.User.Identity.Name;
                var userId = (await UserManager.FindByNameAsync(userName)).Id;
                await UserManager.SetTwoFactorEnabledAsync(userId, true);
            }
            return Ok();
        }

        [HttpGet]
        [Authorize]
        [Route("verify-otp/{code}")]
        public async Task<IHttpActionResult> VerifyOtp(string code)
        {
            try
            {
                var userName = HttpContext.Current.User.Identity.Name;
                var userId = (await UserManager.FindByNameAsync(userName)).Id;
                bool verified = await UserManager.VerifyTwoFactorTokenAsync(userId, "PhoneCode", code);
                if (!verified)
                    return BadRequest($"{code} is not a valid OTP, please verify and try again.");

                List<string> errors = new List<string>();

                var result = await UserManager.SetTwoFactorEnabledAsync(userId, false);
                if (!result.Succeeded)
                {
                    foreach (string error in result.Errors)
                        errors.Add(error);

                    return BadRequest(errors[0]);
                }
                return Ok("OTP verified successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest("Error occurred in the server");
            }
        }

        [Authorize]
        //[AllowAnonymous]
        [HttpGet]
        [Route("getuser")]
        public IHttpActionResult GetUser()
        {
            var identity = (ClaimsIdentity)User.Identity;
            using (var app = new AppDbContext())
            {
                var roles = identity.Claims
                        .Where(c => c.Type == ClaimTypes.Role).Select(c => c.Value);
                var LogTime = identity.Claims
                            .FirstOrDefault(c => c.Type == "LoggedOn").Value;


                try
                {
                    var user = app.Users.Where(i => i.Email == User.Identity.Name).FirstOrDefault();

                    return Ok(new
                    {
                        id = user.Id,
                        username = user.Email,
                        role = "staff",
                    });
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
        }
    }
}
