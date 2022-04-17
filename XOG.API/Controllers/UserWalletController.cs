using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.AppCode.Mappers;
using XOG.Factories;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Controllers
{
    [RoutePrefix("api/wallet")]
    public class UserWalletController : ApiController
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
        public IHttpActionResult List([FromUri] UserWalletFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new UserWalletBL().GetList<UserWalletFilterRequestVM>(filter: filter);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get-select-list")]
        public IHttpActionResult GetSelectListAsync([FromUri] UserWalletFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new UserWalletBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public IHttpActionResult Get(int id)
        {
            var res = new ReturnObject<UserWalletFilterRequestVM>();

            res.Data = (UserWalletFilterRequestVM)new UserWalletBL().GetUserWalletByNameOrId<UserWalletFilterRequestVM>(null, id);

            res.IsSuccess = true;

            res.Result = ApiResult.Success;

            return Ok(res);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> AddAsync(AddWalletRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToUserWalletEntity();

            res.Data = await new UserWalletBL().AddAsync(entity);

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
        public async Task<IHttpActionResult> EditAsync(AddWalletRequestVM request)
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
        public async Task<IHttpActionResult> DeleteAsync(int id)
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