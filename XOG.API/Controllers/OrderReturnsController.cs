using System.Threading.Tasks;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.AppCode.Mappers;
using XOG.Factories;
using System.Net.Http;
using Microsoft.AspNet.Identity.Owin;
using System.Web;
using System.Collections.Generic;
using Razorpay.Api;
using System.Net;
using System;
using XOG.AppCode.Models.FilterModels;
using System.Linq;

namespace XOG.Controllers
{
    [RoutePrefix("api/order-returns")]
    public class OrderReturnsController : ApiController
    {
        public const string KEY = "rzp_test_jOS35pftXDE8SC";

        public const string SECRET = "RCyqFn0fCH7StkappVN7tiFw";

        public OrderReturnsController() { }

        public OrderReturnsController(ApplicationUserManager _userManager)
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
         
         
        [HttpPost]
        [Route("initiate-return")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> InitiateReturnOrder([FromBody] OrderReturnRequestViewModel request)
        {
            var res = new ReturnObject<Dictionary<string, object>>();

            RazorpayClient client = new RazorpayClient(KEY, SECRET);

            var ordersBL = new OrderBL();

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            }

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            var entity = request.MapToOrderReturnEntity();

            res.Data = await ordersBL.ReturnOrder(entity);

            res.IsSuccess = (DBStatus)res.Data["DBStatus"] == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = (string)res.Data["Message"];

            return Ok(res);
        }
    }
}
