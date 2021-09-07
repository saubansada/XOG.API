using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.AppCode.Helpers;
using XOG.AppCode.Models.FilterModels;
using XOG.Models;
using XOG.Models.ViewModels;

namespace XOG.Controllers
{
    public class ProductController : ApiController
    {
        public ReturnObject<object> GetProduct(long id = -1)
        {
            var response = new ReturnObject<object>();
            try
            {
                if (id > 0)
                {
                    ProductViewModel model = (ProductViewModel)ProductBL.GetProductByNameOrId(id: id, type: ModelType.UserView);
                    response.Data = model;
                    response.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public IHttpActionResult GetSiteMap()
        {
            var response = new ReturnObject<object>();
            try
            {
                response.Data = FilesHelper.ReadFile(LocalStorages.Site_Map);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return Ok(response);
        }

        [HttpPost]
        public IHttpActionResult GetSuggestions(ProductFilter filter)
        {
            var response = new ReturnObject<object>();
            try
            {
                response.Data = ProductBL.GetTList(filter: filter, type: ModelType.NameArray);
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return Ok(response);
        }

        [HttpPost]
        public object LoadOrUpdateCart(CartListObject cartListObj)
        {
            var jc = new JSONConfirmation();

            if (User.Identity.IsAuthenticated)
            {
                try
                {

                    //if (cartList != null)
                    //{
                    //    List<Cart> modelList = new List<Cart>();

                    //    cartList.ForEach(m =>
                    //    {
                    //        modelList.Add(new Cart()
                    //        {
                    //            Id = m.Id,
                    //            ProductId = m.ProductId,
                    //            AddedByUserId = User.Identity.GetUserId(),
                    //            Quantity = m.CartCount
                    //        });
                    //    });

                    //    jc.IsSuccess = CartBL.AttachList(modelList) == DBStatus.Success;

                    //}

                    //if (jc.IsSuccess || cartList == null)
                    //{

                    var cartObject = CartHolder.ReadOrUpdateCart(User.Identity.GetUserId(), cartListObj.CartList);

                    jc.Object = cartObject;

                    jc.IsSuccess = true;

                }
                catch (Exception ex)
                {
                    jc.IsError = true;
                    jc.IsSuccess = false;
                    jc.Message = "Error in Cart Operation";
                }
                //CartBL.GetTList(filter: new CartFilters() { UserId = User.Identity.GetUserId() }, type: ModelType.UserView, listType: ListingType.List);
                //}
            }
            return Json(jc);
        }

    }

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
