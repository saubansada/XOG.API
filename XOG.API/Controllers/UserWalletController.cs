using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using XOG.Abstracts;
using XOG.AppCode.BLL;
using XOG.AppCode.Mappers;
using XOG.Factories;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.Models.ViewModels.ResponseViewModels;

namespace XOG.Controllers
{
    [RoutePrefix("api/wallet")]
    public class UserWalletController : CrudApiController<UserWalletFilterRequestVM, AddWalletRequestVM>
    {
        public UserWalletController() { }

        public UserWalletController(ApplicationUserManager _userManager)
        {
            UserManager = _userManager;
        }

        private ApplicationUserManager _userManager;

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

        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async override Task<IHttpActionResult> List([FromUri] UserWalletFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            }

            filter = new UserWalletFilterRequestVM();

            filter.UserId = (await UserManager.FindByNameAsync(userName)).Id;

            var isAdmin = await UserManager.IsInRoleAsync(filter.UserId, "Admin");

            if (isAdmin)
            {
                filter.UserId = "";
            }

            res.Data = new UserWalletBL().GetDetailedList<UserWalletViewModel>(filter: filter);

            res.IsSuccess = true;
             
            return Ok(await Task.FromResult(res));
        }

        [HttpGet]
        [Route("get-select-list")]
        public override IHttpActionResult GetSelectListAsync([FromUri] UserWalletFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new UserWalletBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get")]
        public override async Task<IHttpActionResult> GetAsync(long id)
        {
            var res = new ReturnObject<UserWalletInfo>();

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            }

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            res.Data = (UserWalletInfo)new UserWalletBL().GetUserWalletByUserNameOrId<UserWalletInfo>(null, userId);

            res.IsSuccess = true;

            res.Result = ApiResult.Success;

            return Ok(await Task.FromResult(res));
        }

        [HttpPost]
        [Route("add")]
        public override async Task<IHttpActionResult> AddAsync(AddWalletRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToUserWalletEntity();
             
            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            } 

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            res.Data = await new UserWalletBL().AddAsync(entity, userId);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Saved Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                return BadRequest("Error Occurred while saving");
            }

            return Ok(res);
        }

        [HttpPut]
        [Route("edit")]
        public override async Task<IHttpActionResult> EditAsync(AddWalletRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToUserWalletEntity();

            res.Data = await new UserWalletBL().EditAsync(entity);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Saved Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                return BadRequest("Error Occurred while saving");
            }

            return Ok(res);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public override async Task<IHttpActionResult> DeleteAsync(int id)
        {
            var res = new ReturnObject<DBStatus>();

            res.Data = await new UserWalletBL().DeleteAsync(id);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Deleted Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                string message = res.Data == DBStatus.Error ? "Error occurred while deleting!" : "Wallet into doesn't exist!";

                return BadRequest(message);
            }

            return Ok(res);
        }
    }
}