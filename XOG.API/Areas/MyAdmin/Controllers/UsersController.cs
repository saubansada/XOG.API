//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using System;
//using System.Data.Entity;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Transactions;
//using System.Web.Mvc;
//using XOG.Abstracts;
//using XOG.AppCode.BLL;
//using XOG.AppCode.DAL;
//using XOG.AppCode.Helpers;
//using XOG.AppCode.Models.FilterModels;
//using XOG.AppCode.OFrame;
//using XOG.Areas.MyAdmin.Models.ViewModels;
//using XOG.Factories;
//using XOG.Filters;
//using XOG.Helpers;
//using XOG.Models;
//using XOG.Util;

//namespace XOG.Areas.MyAdmin.Controllers
//{
//    [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
//    public class UsersController : AuthController
//    {
//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        public ActionResult Index(PagerArgs args = null, UserFilter filter = null, string detailId = "")
//        {
//            args = args ?? new PagerArgs();

//            var pageModel = new UsersPageViewModel
//            {
//                filter = filter ?? new UserFilter()
//            };

//            pageModel.filter.Enabled = false;

//            args.PageSize = pageModel.filter.PageSize.ToString();

//            pageModel.gridModel = Utilities.GetGridModel(args, "Id");

//            using (var context = ProductBL.GetXOGContext())
//            {
//                //pageModel.gridModel.ListData = UsersBL.GetTList(context, pageModel.filter, ModelType.AdminView, ListingType.GridList, "", pageModel.gridModel);

//                //if (!string.IsNullOrWhiteSpace(detailId))
//                //{
//                //    pageModel.detailModel = (UserAdminVM)UsersBL.GetUserInfo(detailId, context);
//                //}
//            }

//            return View(pageModel);
//        }

//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        public ActionResult CreateUser()
//        {
//            UserAdminVM model = new UserAdminVM
//            {
//                //UserRoles = UsersBL.GetRoles(userType: CurrentUser.UserType).ToSelectList(takeValues: false)
//            };

//            return View(model);
//        }


//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<JsonResult> CreateUserAsync(UserAdminVM model)
//        {
//            if (!ModelState.IsValid)
//            {
//                return Json(new { InvalidData = true });
//            }

//            if ((CurrentUser.UserType == UserType.Admin.ToString() || CurrentUser.UserType == UserType.Developer.ToString()) && (model.UserType == UserType.Admin.ToString()) ||
//                CurrentUser.UserType == UserType.SubAdmin.ToString() && (model.UserType == UserType.SubAdmin.ToString() || model.UserType == UserType.Admin.ToString() || model.UserType == UserType.Developer.ToString()))
//            {
//                return Json(new { InValidData = true });
//            }

//            var mob = model.Mobile;

//            while (UserManager.Users.FirstOrDefault(c => c.PhoneNumber == model.Mobile || c.Email == model.Email) != null)
//            {
//                return Json(new { IsSuccess = false, IsError = true, Message = "Phone Number or email Already Exist" });
//            }

//            var _userType = model.UserType;

//            var user = new ApplicationUser
//            {
//                UserName = model.Mobile,
//                Email = model.Email,
//                UserType = _userType,
//                PhoneNumber = model.Mobile
//            };

//            using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
//            {
//                var result = await UserManager.CreateAsync(user, model.Password);

//                if (result.Succeeded)
//                {
//                    roleexists:

//                    var roleExists = await RoleManager.RoleExistsAsync(_userType);

//                    if (roleExists)
//                    {
//                        var uarir = await UserManager.AddToRoleAsync(user.Id, _userType);

//                        if (uarir.Succeeded)
//                        {
//                            try
//                            {
//                                var obj = new object(); ;

//                                if (model.UserType.Equals((byte)UserRole.User))
//                                {
//                                    AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);

//                                    await SignInManager.SignInAsync(user, false, false);

//                                    if (!string.IsNullOrWhiteSpace(model.Email))
//                                    {
//                                        await MailHelper.SendUsingSendGridAsync(new IdentityMessage
//                                        {
//                                            Destination = user.Email,
//                                            Subject = AppConfig.SiteName + " - " + "Welcome To XOG",
//                                            Body = EMailBuilder.Build(await MailHelper.GetEmailTemplateFromDataBaseAsync(EmailType.WelcomeEmail))
//                                        });

//                                        var code = Utilities.Base64Encode(await UserManager.GenerateEmailConfirmationTokenAsync(user.Id));
//                                        var callbackUrl = Url.Action("ConfirmEmail", "Authentication", new { userId = user.Id, code }, Request.Url.Scheme);

//                                        await MailHelper.SendUsingSendGridAsync(new IdentityMessage
//                                        {
//                                            Destination = user.Email,
//                                            Subject = AppConfig.SiteName + " - " + "Verify Email",
//                                            Body = EMailBuilder.Build(await MailHelper.GetEmailTemplateFromDataBaseAsync(EmailType.EmailVerification),
//                                                                       Substitution.Get("UserName", model.Mobile),
//                                                                       Substitution.Get("link", callbackUrl))
//                                        });
//                                    }

//                                }

//                                using (var context = new XOGEntities())
//                                {
//                                    var _user = context.AspNetUsers.Where(i => i.PhoneNumber.Equals(user.PhoneNumber)).FirstOrDefault();

//                                    _user.FirstName = model.FirstName;
//                                    _user.LastName = model.LastName;
//                                    _user.AlternateMobileNumber = model.AlternateMobileNumber;
//                                    _user.LockoutEnabled = false;

//                                    context.AspNetUsers.Attach(_user);

//                                    context.Entry(_user).State = EntityState.Modified;

//                                    await context.SaveChangesAsync();

//                                    if (model.UserType.Equals((byte)UserRole.User))
//                                    {
//                                       // obj = new { User = await UsersBL.GetUserInfoAsync(user.Id, context) };

//                                    }
//                                }

//                                ts.Complete();

//                                return Json(new { IsSuccess = true, Message = "User Created Successfully", Object = obj });
//                            }
//                            catch (Exception ex)
//                            {
//                                ErrorLogger.LogError(ex);
//                            }
//                        }
//                        else
//                        {
//                            AddErrors(uarir);
//                        }
//                    }
//                    else
//                    {
//                        var role = new IdentityRole { Name = _userType };

//                        var rair = await RoleManager.CreateAsync(role);

//                        if (rair.Succeeded)
//                        {
//                            goto roleexists;
//                        }
//                        else
//                        {
//                            AddErrors(rair);
//                        }
//                    }
//                }
//                else
//                {
//                    AddErrors(result);
//                }
//            }

//            return Json(new { IsError = true, Message = "Some error occurred in the server while creating User" });
//        }


//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> UserRoleUpdated(string userId, string roles)
//        {
//            var jc = new JSONConfirmation
//            {
//                IsError = false,
//                IsSuccess = true,
//                Message = "User's roles updated successfully"
//            };

//            string[] _roles = roles.Substring(0, roles.Length - 1).Split(',');

//            string[] toRemove = _roles.Where(i => i.Contains("false")).Select(v => v.Substring(0, v.IndexOf(":"))).ToArray();

//            string[] toAdd = _roles.Where(i => i.Contains("true")).Select(v => v.Substring(0, v.IndexOf(":"))).ToArray();

//            try
//            {
//                ApplicationUser user = UserManager.FindById(userId);

//                if (toAdd.Contains(UserType.Developer.ToString()))
//                {
//                    user.UserType = UserType.Developer.ToString();
//                }
//                else if (toAdd.Contains(UserType.Admin.ToString()))
//                {
//                    user.UserType = UserType.Admin.ToString();
//                }
//                else if (toAdd.Contains(UserType.SubAdmin.ToString()))
//                {
//                    user.UserType = UserType.SubAdmin.ToString();
//                }
//                else if (toAdd.Contains(UserType.Staff.ToString()))
//                {
//                    user.UserType = UserType.Staff.ToString();
//                }
//                else
//                {
//                    user.UserType = UserType.Customer.ToString();
//                }

//                foreach (var role in toRemove)
//                {

//                    await UserManager.RemoveFromRoleAsync(userId, role);
//                }

//                foreach (var role in toAdd)
//                {
//                    await UserManager.AddToRoleAsync(userId, role);
//                }

//                await UserManager.UpdateAsync(user);

//            }
//            catch (Exception ex)
//            {
//                jc.IsSuccess = false;
//                jc.IsError = true;
//                jc.Message = ex.Message;

//            }

//            return Json(jc);
//        }
//    }

//}