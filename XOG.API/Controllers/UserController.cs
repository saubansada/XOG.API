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

namespace XOG.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : CrudApiController<UserFiltersRequestVM, UserRequestVM>
    {
        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public override IHttpActionResult List([FromUri] UserFiltersRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new UserBL().GetList<UserViewModel>(filter);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get-select-list")]
        public override IHttpActionResult GetSelectListAsync([FromUri] UserFiltersRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new UserBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public IHttpActionResult Get(string id)
        {
            var res = new ReturnObject<UserViewModel>();

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
        public override async Task<IHttpActionResult> EditAsync(UserRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToAspNetUserEntity();

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

        public override IHttpActionResult Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public override Task<IHttpActionResult> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}