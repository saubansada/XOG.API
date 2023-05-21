using System.Threading.Tasks;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.AppCode.Mappers;
using XOG.Factories;
using System.Net.Http;
using Microsoft.AspNet.Identity.Owin;
using System.Web;
using System.Collections.Generic;
using Razorpay.Api;
using System.Net;
using XOG.Abstracts;

namespace XOG.Controllers
{
    [RoutePrefix("api/offer")]
    public class OfferController : CrudApiController<OfferFilterRequestVM, OfferRequestVM>
    {
        public const string KEY = "rzp_test_jOS35pftXDE8SC";

        public const string SECRET = "RCyqFn0fCH7StkappVN7tiFw";

        public OfferController() { }

        public OfferController(ApplicationUserManager _userManager)
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
        public override async Task<IHttpActionResult> List([FromUri] OfferFilterRequestVM filter)
        {
            ReturnObject<object> result = new ReturnObject<object>();

            OfferFilterRequestVM offerFilter = filter ?? new OfferFilterRequestVM();
              
            result.Data = (object)new OfferBL().GetList<OfferViewModel>(offerFilter);


            if (result.Data == null)
            {
                result.IsSuccess = false;
                result.Message = "Offers not found!";
            }

            return await Task.FromResult(Ok(result));
        }

        [HttpGet]
        [Route("get/{id}")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public override async Task<IHttpActionResult> GetAsync(long id)
        {
            ReturnObject<OfferViewModel> result = new ReturnObject<OfferViewModel>();

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            }

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            var offer = (OfferViewModel)await new OfferBL().GetOffer<OfferViewModel>(id, userId);

            result.Data = offer;

            result.IsSuccess = result.Data != null;

            if (!result.IsSuccess)
            {
                result.Message = "Offer not found!";
            }

            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public override async Task<IHttpActionResult> AddAsync([FromBody] OfferRequestVM request)
        {
            var res = new ReturnObject<Dictionary<string, object>>(); 

            var offersBL = new OfferBL();
              
            var entity = request.MapToOfferEntity();

            res.Data = await offersBL.AddOffer(entity);

            res.IsSuccess = (DBStatus)res.Data["DBStatus"] == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = (string)res.Data["Message"];
            
            return Ok(res);
        }
        
        [HttpPut]
        [Route("edit")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public override async Task<IHttpActionResult> EditAsync([FromBody] OfferRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var offer = request.MapToOfferEntity();

            var result = await new OfferBL().UpdateAsync(offer);

            res.IsSuccess = (DBStatus)result["DBStatus"] == DBStatus.Success;

            res.Message = res.IsSuccess ? (string)result["Message"] : (string)result["DetailedError"];

            res.Result = ApiResult.Success;

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                return BadRequest("Error Occurred while saving");
            }

            return Ok(res);
        }
         
        public override IHttpActionResult GetSelectListAsync([FromUri] OfferFilterRequestVM filter)
        {
            throw new System.NotImplementedException();
        }


        [HttpDelete]
        [Route("delete/{id}")]
        public override async Task<IHttpActionResult> DeleteAsync(int id)
        {
            var res = new ReturnObject<DBStatus>();

            res.Data = await new OfferBL().DeleteAsync(id);

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
