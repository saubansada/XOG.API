using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using XOG.Factories;

namespace XOG.Controllers
{
    [AllowAnonymous]
    public class HomeController : XOG.Abstracts.AuthController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }
        
        [AllowAnonymous]
        public async Task<ActionResult> Init()
        {
            var status = "Initializing - ";

            status += "<br/><br>" + await InitUser(UserRole.Admin.ToString(), "admin", "admin@xog.com", "8867177465", "xog@123");

            status += "<br/><br>" + await InitUser("Developer", "developer", "sadasauban123@gmail.com", "9049737042", "Sauban@123");

            status += "<br/><br>" + await InitUser("SubAdmin", "subadmin", "sadasauban123@subgmail.com", "5698423689", "Sauban@123");

            status += "<br/><br>" + await InitUser(UserRole.Staff.ToString());

            status += "<br/><br>" + await InitUser(UserRole.User.ToString());

            return PartialView("init", status);
        }

        public async Task<string> InitUser(string _role, string username = "", string email = "", string mobile = "", string password = "")
        {
            string status = "For -- " + _role + ". ";

            if (_role == "")
            {
                return status += ", role passed empty.";
            }

            if (username == "")
            {
                if (!await RoleManager.RoleExistsAsync(_role))
                {
                    var role = new IdentityRole { Name = _role };

                    var rr = await RoleManager.CreateAsync(role);

                    if (rr.Succeeded)
                    {
                        status += _role + " Role Created Successfully";
                    }
                    else
                    {
                        status += _role + " Role Create Failed, Not Initialized.";
                    }
                }
                else
                {
                    status += _role + " Role Already Exists";
                }

                return status;

            }

            var user = UserManager.Users.FirstOrDefault(c => c.UserName == username);

            if (user != null)
            {
                status = "User Exists, ";

                var roleExists = await RoleManager.RoleExistsAsync(_role);

                if (roleExists)
                {
                    status += "Role Exists, ";

                    var inRole = await UserManager.IsInRoleAsync(user.Id, _role);

                    if (inRole)
                    {
                        status += "User Already In Role, Initialized.";
                    }
                    else
                    {
                        status += "Adding User To Role, ";

                        var idr = await UserManager.AddToRoleAsync(user.Id, "Admin");

                        if (idr.Succeeded)
                        {
                            status += "User Added To The Role, Initialized.";
                        }
                        else
                        {
                            status += "User Add To Role Failed, Not Initialized.";
                        }
                    }
                }
                else
                {
                    status += _role + " Role Missing, Creating Role, ";

                    var role = new IdentityRole { Name = _role };

                    var rr = await RoleManager.CreateAsync(role);

                    if (rr.Succeeded)
                    {
                        status += _role + " Role Created Successfully, Adding User To Role, ";

                        var idr = await UserManager.AddToRoleAsync(user.Id, "Admin");

                        if (idr.Succeeded)
                        {
                            status += "User Added To The Role, Initialized.";
                        }
                        else
                        {
                            status += "User Add To Role Failed, Not Initialized.";
                        }
                    }
                    else
                    {
                        status += _role + " Role Create Failed, Not Initialized.";
                    }


                }

            }
            else
            {
                status = "Not Initialized, User Missing, ";

                var usr = new ApplicationUser
                {
                    UserName = username,
                    Email = email,
                    UserType = UserType.Admin.ToString(),
                    PhoneNumber = mobile,
                };

                var result = await UserManager.CreateAsync(usr, password);

                if (result.Succeeded)
                {
                    status += "User Created, ";

                    var exists = await RoleManager.RoleExistsAsync(_role);

                    if (exists)
                    {
                        status += _role + " Role Exists, ";

                        var inRole = await UserManager.IsInRoleAsync(usr.Id, _role);

                        if (inRole)
                        {
                            status += "User Already In Role, Initialized.";
                        }
                        else
                        {
                            status += "Adding User To Role, ";

                            var idr = await UserManager.AddToRoleAsync(usr.Id, _role);

                            if (idr.Succeeded)
                            {
                                status += "User Added To The Role, Initialized.";
                            }
                            else
                            {
                                status += "User Add To Role Failed, Not Initialized.";
                            }
                        }
                    }
                    else
                    {
                        status += _role + " Role Missing, Creating Role, ";

                        var role = new IdentityRole { Name = _role };

                        var rr = await RoleManager.CreateAsync(role);

                        if (rr.Succeeded)
                        {
                            status += _role + " Role Created Successfully, Adding User To Role, ";

                            var idr = await UserManager.AddToRoleAsync(usr.Id, _role);

                            if (idr.Succeeded)
                            {
                                status += "User Added To The Role, Initialized.";
                            }
                            else
                            {
                                status += "User Add To Role Failed, Not Initialized.";
                            }
                        }
                        else
                        {
                            status += _role + " Role Create Failed, Not Initialized.";
                        }
                    }
                }
                else
                {
                    status += "User Create Failed, Not Initialized.";
                }
            }

            return status;
        }

    }
}