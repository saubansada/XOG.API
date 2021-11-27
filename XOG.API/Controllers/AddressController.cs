using Microsoft.AspNet.Identity.Owin;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.AppCode.Mappers;
using XOG.Factories;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Controllers
{
    [RoutePrefix("api/address")]
    public class AddressController : ApiController
    {
        public AddressController() { }
         
        public AddressController(ApplicationUserManager userManager)
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
        public IHttpActionResult List([FromUri] AddressFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();
              
            res.Data = new AddressBL().GetList<AddressViewModel>(filter);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get-select-list")]
        public IHttpActionResult GetSelectListAsync([FromUri] AddressFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new AddressBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public async Task<IHttpActionResult> GetAsync(int id)
        {
            var res = new ReturnObject<AddressViewModel>();

            res.Data = (AddressViewModel)new AddressBL().GetAddressByNameOrId<AddressViewModel>(id);
             
            var userName = HttpContext.Current.User.Identity.Name;

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            if(userId == res.Data.AddressOfUserId || HttpContext.Current.User.IsInRole("Staff") || HttpContext.Current.User.IsInRole("Admin"))
            { 
                res.IsSuccess = true;

                res.Result = ApiResult.Success;

                return Ok(res);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> AddAsync(AddressRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var userName = HttpContext.Current.User.Identity.Name;

            request.AddressOfUserId = (await UserManager.FindByNameAsync(userName)).Id;

            var entity = request.MapToAddressEntity();

            res.Data = await new AddressBL().AddAsync(entity);

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
        public async Task<IHttpActionResult> EditAsync(AddressRequestVM request)
        {
            var userName = HttpContext.Current.User.Identity.Name;

            request.AddressOfUserId = (await UserManager.FindByNameAsync(userName)).Id;

            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToAddressEntity();

            res.Data = await new AddressBL().EditAsync(entity);

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

            res.Data = await new AddressBL().DeleteAsync(id);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Deleted Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                string message = res.Data == DBStatus.Error ? "Error occurred while deleting!" : "Category doesn't exist!";

                return BadRequest(message);
            }

            return Ok(res);
        }
    }
}
