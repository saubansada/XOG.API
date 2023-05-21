using Microsoft.AspNet.Identity.Owin;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
using XOG.Models.ViewModels.ResponseViewModels;
using XOG.Util;

namespace XOG.Controllers
{
    [RoutePrefix("api/redeemrequest")]
    public class RedeemRequestController : CrudApiController<RedeemRequestFilterRequestVM, RedeemRequestRequestVM>
    {
        public RedeemRequestController() { }

        public RedeemRequestController(ApplicationUserManager _userManager)
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
        public async override Task<IHttpActionResult> List([FromUri] RedeemRequestFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new RedeemRequestBL().GetList<RedeemRequestViewModel>((IRedeemRequestFilter)filter);

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }

        [HttpGet]
        [Route("get-select-list")]
        public override IHttpActionResult GetSelectListAsync([FromUri] RedeemRequestFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new RedeemRequestBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public async override Task<IHttpActionResult> GetAsync(long id)
        {
            var res = new ReturnObject<RedeemRequestViewModel>();

            res.Data = (RedeemRequestViewModel)new RedeemRequestBL().GetRedeemRequestByNameOrId<RedeemRequestViewModel>(id);

            var userName = HttpContext.Current.User.Identity.Name;

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            if (userId == res.Data.RequestedByUserId || HttpContext.Current.User.IsInRole("Staff") || HttpContext.Current.User.IsInRole("Admin"))
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
        public override async Task<IHttpActionResult> AddAsync(RedeemRequestRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var userName = HttpContext.Current.User.Identity.Name;

            if (request == null) request = new RedeemRequestRequestVM();

            request.RequestedByUserId = (await UserManager.FindByNameAsync(userName)).Id;

            var filter = new UserWalletFilterRequestVM();

            filter.UserId = request.RequestedByUserId;

            var _wallet = new UserWalletBL().GetDetailedList<UserWalletViewModel>(filter: filter);

            double amount = 0;

            var wallet = ((IEnumerable)_wallet).Cast<UserWalletViewModel>().ToList(); //  (List<UserWalletViewModel>);

            wallet.ForEach(item =>
            {
                amount += (item.Amount ?? 0);
            });

            BankAccountViewModel bankAccountData = null;

            if (request.BankAccountId != 0)
            {
                bankAccountData = (BankAccountViewModel)new BankAccountBL().GetBankAccountByNameOrId<BankAccountViewModel>(id: request.BankAccountId);
            }

            request.Amount = amount;

            if (request.Amount == 0)
            {
                res.IsSuccess = res.Data == DBStatus.DoesntExist;

                res.Result = ApiResult.ValidationError;

                res.Message = "No amount in the wallet to redeem!";

            }
            else if (request.BankAccountId == 0 || bankAccountData == null)
            {
                res.IsSuccess = res.Data == DBStatus.DoesntExist;

                res.Result = ApiResult.ValidationError;

                res.Message = request.BankAccountId != 0 && bankAccountData == null ?
                        "Could not find selected bank details" :
                        request.BankAccountId == 0 ? "Please select the bank account details"
                        : "Please add you bank account details to redeem";
            }
            else
            {
                request.BankAccountId = bankAccountData.Id;

                request.BankAccountNumber = bankAccountData.AccountNumber;

                var redeemRequest = request.MapToRedeemRequestEntity();

                res.Data = await new RedeemRequestBL().AddAsync(redeemRequest);

                res.Message = "Redeem request has been creaated, the amount will be credited to your account in 2 to 3 business days!";

                res.IsSuccess = res.Data == DBStatus.Success;

                res.Result = ApiResult.Success;

                if (!res.IsSuccess)
                {
                    res.Result = ApiResult.Failure;

                    return BadRequest("Request couldn't be processed due to techinical error, please try again after or contact support team!");
                }

            }
             
            return Ok(res);
        }

        [HttpPut]
        [Route("edit")]
        public override async Task<IHttpActionResult> EditAsync(RedeemRequestRequestVM request)
        {
            var userName = HttpContext.Current.User.Identity.Name;

            request.RequestedByUserId = (await UserManager.FindByNameAsync(userName)).Id;

            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToRedeemRequestEntity();

            res.Data = await new RedeemRequestBL().EditAsync(entity);

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

            res.Data = await new RedeemRequestBL().DeleteAsync(id);

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
