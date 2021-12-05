using System.Threading.Tasks;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.AppCode.Mappers;
using XOG.Models.ViewModels.ResponseViewModels;
using XOG.Factories;
using System.Net.Http;
using Microsoft.AspNet.Identity.Owin;
using System.Web;

namespace XOG.Controllers
{
    [RoutePrefix("api/order")]
    public class OrderController : ApiController
    {
        public OrderController() { }

        public OrderController(ApplicationUserManager _userManager)
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
        [Route("place-order")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> PlaceOrder([FromBody] OrderRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var ordersBL = new OrderBL();

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            }

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            using (var context = ordersBL.GetXOGContext())
            {
                var entity = request.MapToOrderEntity(context);

                res.Data = await ordersBL.PlaceOrder(context, entity);

                res.IsSuccess = res.Data == DBStatus.Success;

                res.Result = ApiResult.Success;

                res.Message = "Saved Successfully!";
            }

            return Ok(res);
        }

    }
}
