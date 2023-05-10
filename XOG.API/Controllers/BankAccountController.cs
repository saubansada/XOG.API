using Microsoft.AspNet.Identity.Owin;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using XOG.Abstracts;
using XOG.AppCode.BLL;
using XOG.AppCode.Mappers;
using XOG.AppCode.Models.FilterModels;
using XOG.Factories;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Controllers
{
    [RoutePrefix("api/bankaccount")]
    public class BankAccountController : CrudApiController<BankAccountFilterRequestVM, BankAccountRequestVM>
    {
        public BankAccountController() { }
         
        public BankAccountController(ApplicationUserManager _userManager)
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
        public async override Task<IHttpActionResult> List([FromUri] BankAccountFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();
              
            res.Data = new BankAccountBL().GetList<BankAccountViewModel>((IBankAccountFilter)filter);

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }

        [HttpGet]
        [Route("get-select-list")]
        public override IHttpActionResult GetSelectListAsync([FromUri] BankAccountFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new BankAccountBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }
          
        [HttpGet]
        [Route("get/{id}")]
        public async override Task<IHttpActionResult> GetAsync(long id)
        {
            var res = new ReturnObject<BankAccountViewModel>();
              
            res.Data = (BankAccountViewModel)new BankAccountBL().GetBankAccountByNameOrId<BankAccountViewModel>(id);
             
            var userName = HttpContext.Current.User.Identity.Name;

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            if(userId == res.Data.AccountOfUserId || HttpContext.Current.User.IsInRole("Staff") || HttpContext.Current.User.IsInRole("Admin"))
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
        public override async Task<IHttpActionResult> AddAsync(BankAccountRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var userName = HttpContext.Current.User.Identity.Name;

            request.AccountOfUserId = (await UserManager.FindByNameAsync(userName)).Id;

            var entity = request.MapToBankAccountEntity();

            res.Data = await new BankAccountBL().AddAsync(entity);

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
        public override async Task<IHttpActionResult> EditAsync(BankAccountRequestVM request)
        {
            var userName = HttpContext.Current.User.Identity.Name;

            request.AccountOfUserId = (await UserManager.FindByNameAsync(userName)).Id;

            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToBankAccountEntity();

            res.Data = await new BankAccountBL().EditAsync(entity);

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

            res.Data = await new BankAccountBL().DeleteAsync(id);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Deleted Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                string message = res.Data == DBStatus.Error ? "Error occurred while deleting!" : "Bank Account doesn't exist!";

                return BadRequest(message);
            }

            return Ok(res);
        }

    }
}
