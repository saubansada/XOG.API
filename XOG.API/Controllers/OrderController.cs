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
    [RoutePrefix("api/order")]
    public class OrderController : ApiController
    {
        public const string KEY = "rzp_test_jOS35pftXDE8SC";

        public const string SECRET = "RCyqFn0fCH7StkappVN7tiFw";

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

        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> List([FromUri] OrderFilterRequestVM filter)
        {
            ReturnObject<List<OrderViewModel>> result = new ReturnObject<List<OrderViewModel>>();

            OrderFilterRequestVM orderFilter = filter ?? new OrderFilterRequestVM();

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            }

            string userId = (await UserManager.FindByNameAsync(userName)).Id;

            orderFilter.userIds = userId;

            orderFilter.IsAdminRequest = (await UserManager.IsInRoleAsync(userId, "Admin")) || (await UserManager.IsInRoleAsync(userId, "Staff"))
                    || (await UserManager.IsInRoleAsync(userId, "Developer")); ;

            var order = (List<OrderViewModel>)new OrderBL().GetList<OrderViewModel>(orderFilter);

            result.Data = order;

            result.IsSuccess = result.Data != null;

            if (!result.IsSuccess)
            {
                result.Message = "Orders not found!";
            }

            return await Task.FromResult(Ok(result));
        }

        [HttpGet]
        [Route("get/{id}")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> Get(long id, bool isReturnedOrder)
        {
            ReturnObject<OrderViewModel> result = new ReturnObject<OrderViewModel>();

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            }

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            var order = (OrderViewModel)await new OrderBL().GetOrder<OrderViewModel>(id, isReturnedOrder, userId);

            result.Data = order;

            result.IsSuccess = result.Data != null;

            if (!result.IsSuccess)
            {
                result.Message = "Order not found!";
            }

            return Ok(result);
        }

        [HttpPost]
        [Route("initiate-order")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> InitiateOrder([FromBody] OrderInitiateRequestVM request)
        {
            var res = new ReturnObject<Dictionary<string, object>>();

            var userName = HttpContext.Current.User.Identity.Name;

            var ordersBL = new OrderBL();

            if (userName == null)
            {
                return Unauthorized();
            }

            try
            {
                var userId = (await UserManager.FindByNameAsync(userName)).Id;

                double amount = 0;

                using (var context = ordersBL.GetXOGContext())
                {
                    CartBL bl = new CartBL();

                    await bl.DeleteMultipleAsync(new CartFilterRequestVM
                    {
                        UserId = userId
                    }, context);

                    var list = request.CartList.MapToCartEntityList(userId);

                    bl.AttachList(list, context);

                    OrderRequestVM vm = new OrderRequestVM
                    {
                        UserId = userId,
                        Purchases = list.Select(i => new OrderDetailRequestVM
                        {
                            ProductVariantId = i.ProductVariantId ?? -1,
                            Quantity = i.Quantity ?? 0
                        }).ToList()
                    };

                    amount = vm.MapToOrderEntity(context).TotalAmount;
                }

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                RazorpayClient client = new RazorpayClient(KEY, SECRET);

                Dictionary<string, object> input = new Dictionary<string, object>();

                res.Data = new Dictionary<string, object>();

                var wholeAmount = Int32.Parse(Math.Floor(amount) + "" + Math.Round((amount - (Math.Floor(amount))) * 100));

                input.Add("amount", wholeAmount);

                input.Add("currency", "INR");

                input.Add("payment_capture", 1);

                Order order = client.Order.Create(input);

                res.Data.Add("RazorPayOrderId", order["id"].ToString());

                res.Message = "";

                res.IsSuccess = true;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;

                res.Message = ex.Message;
            }
            return Ok(res);
        }

        [HttpPost]
        [Route("place-order")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> PlaceOrder([FromBody] OrderRequestVM request)
        {
            var res = new ReturnObject<Dictionary<string, object>>();

            RazorpayClient client = new RazorpayClient(KEY, SECRET);

            var ordersBL = new OrderBL();

            var userName = HttpContext.Current.User.Identity.Name;

            if (userName == null)
            {
                return Unauthorized();
            }

            if (request.PaymentMode == PaymentType.OnlinePayment)
            {
                VerifyPayment(request.PaymentId, request.PaymentOrderId, request.PaymentSignature);
            }

            var userId = (await UserManager.FindByNameAsync(userName)).Id;

            using (var context = ordersBL.GetXOGContext())
            {
                Payment payment = null;

                if (request.PaymentMode == PaymentType.OnlinePayment)
                {
                    CartBL cartBL = new CartBL();

                    CartFilterRequestVM filter = new CartFilterRequestVM() { UserId = userId };

                    var userCartList = ((List<Object>)cartBL.GetList<CartViewModel>(context, filter)).Select(i => (CartViewModel)i);

                    request.Purchases = userCartList.Select(i => new OrderDetailRequestVM
                    {
                        ProductVariantId = i.ProductVariantId,
                        Quantity = i.Quantity
                    }).ToList();

                    payment = client.Payment.Fetch(request.PaymentId);
                }

                request.UserId = userId;

                var entity = request.MapToOrderEntity(context);

                var wholeAmount = Int32.Parse(Math.Floor(entity.TotalAmount) + "" + Math.Round((entity.TotalAmount - (Math.Floor(entity.TotalAmount))) * 100));

                if (request.PaymentMode == PaymentType.CashOnDelivery || (payment != null && payment["amount"] == wholeAmount))
                {
                    res.Data = await ordersBL.PlaceOrder(context, entity);

                    res.IsSuccess = (DBStatus)res.Data["DBStatus"] == DBStatus.Success;

                    res.Result = ApiResult.Success;

                    res.Message = (string)res.Data["Message"];
                }
                else
                {
                    res.IsSuccess = false;

                    res.Message = "Payment does not match";
                }
            }

            return Ok(res);
        }

        public void VerifyPayment(string paymentId, string paymentOrderId, string paymentSignature)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Dictionary<string, string> attributes = new Dictionary<string, string>();

            attributes.Add("razorpay_payment_id", paymentId);

            attributes.Add("razorpay_order_id", paymentOrderId);

            attributes.Add("razorpay_signature", paymentSignature);

            Utils.verifyPaymentSignature(attributes);
        }

        //[HttpPost]
        //[Route("confirm-return-order")]
        //[OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        //public async Task<IHttpActionResult> ConfirmReturnOrder([FromBody] OrderReturnRequestViewModel request)
        //{
        //    return Ok();
        //}

        [HttpPost]
        [Route("update-order-status")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> UpdateOrderStatus([FromBody] OrderRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();
              
            var result = await new OrderBL().UpdateOrderStatus(request.Id, request.OrderState);

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


        [HttpPost]
        [Route("update-order-return-status")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async Task<IHttpActionResult> UpdateOrderReturnStatus([FromBody] OrderRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();
             
            var result = await new OrderBL().UpdateOrderReturnStatus(request.ReturnId, request.OrderState);

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
    }
}
