using System.Threading.Tasks;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.AppCode.Mappers;
using XOG.Abstracts;
using System.Web;

namespace XOG.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : CrudApiController<UserFiltersRequestVM, UserRequestVM>
    {
        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async override Task<IHttpActionResult> List([FromUri] UserFiltersRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new UserBL().GetList<UserViewModel>(filter);

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }

        [HttpGet]
        [Route("get-select-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public override IHttpActionResult GetSelectListAsync([FromUri] UserFiltersRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new UserBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public IHttpActionResult Get(string id)
        {
            var res = new ReturnObject<UserViewModel>();

            if(id == "current")
            {
                id = HttpContext.Current.User.Identity.Name;
            }

            res.Data = new UserBL().GetUserByNameOrId<UserViewModel>(id: id);

            res.IsSuccess = true;

            res.Result = ApiResult.Success;

            return Ok(res);
        }

        [HttpPost]
        [Route("add")]
        public override async Task<IHttpActionResult> AddAsync(UserRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToAspNetUserEntity();

            res.Data = await new UserBL().AddAsync(entity);

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
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public override async Task<IHttpActionResult> EditAsync(UserRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();
             
            var userInfo = new UserBL().GetUserByNameOrId<UserViewModel>(id: request.UserName);

            var entity = request.MapToAspNetUserEntity(userInfo);

            res.Data = await new UserBL().EditAsync(entity);

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
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> DeleteAsync(string id)
        {
            var res = new ReturnObject<DBStatus>();

            res.Data = await new UserBL().DeleteAsync(id);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Deleted Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                string message = res.Data == DBStatus.Error ? "Error occurred while deleting!" : "User doesn't exist!";

                return BadRequest(message);
            }

            return Ok(res);
        }

        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async override Task<IHttpActionResult> GetAsync(long id)
        {
            await Task.FromResult(0);
            throw new System.NotImplementedException();
        }

        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public override Task<IHttpActionResult> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}