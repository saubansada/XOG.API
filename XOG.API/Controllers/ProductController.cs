using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.AppCode.Helpers;
using XOG.AppCode.Mappers;
using XOG.AppCode.Models.FilterModels;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public IHttpActionResult List([FromUri] ProductFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new ProductBL().GetList<ProductViewModel>(filter);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get-select-list")]
        public IHttpActionResult GetSelectListAsync([FromUri] ProductFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new ProductBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public IHttpActionResult GetProduct(int id)
        {
            var res = new ReturnObject<ProductViewModel>();

            res.Data = (ProductViewModel)new ProductBL().GetProductByNameOrId<ProductViewModel>(id);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> AddAsync(ProductRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToProductEntity();

            res.Data = await new ProductBL().AddAsync(entity);

            res.IsSuccess = res.Data == DBStatus.Success;

            if (!res.IsSuccess)
            {
                return BadRequest("Error Occurred while saving");
            }

            return Ok(res);
        }

        [HttpPut]
        [Route("edit")]
        public async Task<IHttpActionResult> EditAsync(ProductRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToProductEntity();

            res.Data = await new ProductBL().EditAsync(entity);

            res.IsSuccess = res.Data == DBStatus.Success;

            if (!res.IsSuccess)
            {
                return BadRequest("Error Occurred while saving");
            }

            return Ok(res);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IHttpActionResult> DeleteAsync(int id)
        {
            var res = new ReturnObject<DBStatus>();

            res.Data = await new ProductBL().DeleteAsync(id);

            res.IsSuccess = res.Data == DBStatus.Success;

            if (!res.IsSuccess)
            {
                string message = res.Data == DBStatus.Error ? "Error occurred while deleting!" : "Category doesn't exist!";

                return BadRequest(message);
            }

            return Ok(res);
        }
    }

    //[HttpPost]
    //public object LoadOrUpdateCart(CartListObject cartListObj)
    //{
    //    var jc = new JSONConfirmation();

    //    if (User.Identity.IsAuthenticated)
    //    {
    //        try
    //        {

    //            //if (cartList != null)
    //            //{
    //            //    List<Cart> modelList = new List<Cart>();

    //            //    cartList.ForEach(m =>
    //            //    {
    //            //        modelList.Add(new Cart()
    //            //        {
    //            //            Id = m.Id,
    //            //            ProductId = m.ProductId,
    //            //            AddedByUserId = User.Identity.GetUserId(),
    //            //            Quantity = m.CartCount
    //            //        });
    //            //    });

    //            //    jc.IsSuccess = CartBL.AttachList(modelList) == DBStatus.Success;

    //            //}

    //            //if (jc.IsSuccess || cartList == null)
    //            //{

    //            var cartObject = CartHolder.ReadOrUpdateCart(User.Identity.GetUserId(), cartListObj.CartList);

    //            jc.Object = cartObject;

    //            jc.IsSuccess = true;

    //        }
    //        catch (Exception)
    //        {
    //            jc.IsError = true;
    //            jc.IsSuccess = false;
    //            jc.Message = "Error in Cart Operation";
    //        }
    //        //CartBL.GetTList(filter: new CartFilters() { UserId = User.Identity.GetUserId() }, type: ModelType.UserView, listType: ListingType.List);
    //        //}
    //    }
    //    return Json(jc);
    //} 

    public class CartListObject
    {
        public string CartList { get; set; }
    }


    public static class CartHolder
    {
        private static readonly Dictionary<string, string> cartList = new Dictionary<string, string>();

        private static readonly string key = "__cart_info__";

        public static string ReadOrUpdateCart(string userId, string cartObject = null)
        {
            string _key = userId + "_" + key;

            if (cartObject == "null")
            {
                userId = userId.Replace("-", "_");

                if (cartList.ContainsKey(_key))
                {
                    return cartList[_key];
                }
                return null;
            }
            cartList[_key] = cartObject;
            return cartObject;
        }
    }
}
