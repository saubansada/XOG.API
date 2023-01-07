using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using XOG.Abstracts;
using XOG.AppCode.BLL;
using XOG.AppCode.Filters;
using XOG.AppCode.Helpers;
using XOG.AppCode.Mappers;
using XOG.AppCode.Models.FilterModels;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.Util;

namespace XOG.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductController : CrudApiController<ProductFilterRequestVM, ProductRequestVM>
    {
        [HttpGet]
        [Route("get-list")]
        public async override Task<IHttpActionResult> List([FromUri] ProductFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new ProductBL().GetList<ProductViewModel>(filter);

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }

        [HttpGet]
        [Route("get-variant-list")]
        public IHttpActionResult VariantList([FromUri] ProductFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            if (filter == null)
            {
                filter = new ProductFilterRequestVM();
            }
            filter.ProductQueryType = ProductQueryType.Variants;

            res.Data = new ProductBL().GetList<ProductVariantViewModel>(filter);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get-select-list")]
        public override IHttpActionResult GetSelectListAsync([FromUri] ProductFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new ProductBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public async override Task<IHttpActionResult> GetAsync(int id)
        {
            var res = new ReturnObject<ProductViewModel>();

            res.Data = (ProductViewModel)new ProductBL().GetProductByNameOrId<ProductViewModel>(id);

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }

        [HttpPost]
        [Route("add")]
        [TwoFactorAhorize]
        public override async Task<IHttpActionResult> AddAsync(ProductRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToProductEntity();

            res.Data = await new ProductBL().AddAsync(entity);

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
        [TwoFactorAhorize]
        public override async Task<IHttpActionResult> EditAsync(ProductRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();
            try
            {
                var entity = request.MapToProductEntity();

                res.Data = await new ProductBL().EditAsync(entity);

                res.IsSuccess = res.Data == DBStatus.Success;

                res.Result = ApiResult.Success;

                res.Message = "Saved Successfully!";

                if (!res.IsSuccess)
                {
                    res.Result = ApiResult.Failure;

                    return BadRequest("Error Occurred while saving");
                }
            }
            catch (Exception)
            {
                res.Result = ApiResult.Error;
                return BadRequest("Error Occurred while saving");
            }
            return Ok(res);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [TwoFactorAhorize]
        public override async Task<IHttpActionResult> DeleteAsync(int id)
        {
            var res = new ReturnObject<DBStatus>();

            res.Data = await new ProductBL().DeleteAsync(id);

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
        
        [Route("upload-images")]
        [HttpPost]
        [TwoFactorAhorize]
        public IHttpActionResult UploadImages(string storageType)
        {
            var res = new ReturnObject<FileUploadResult>();

            var httpRequest = HttpContext.Current.Request;

            string storagePath = storageType == "product" ? LocalStorages.Storage_Product_Image_Uploads :
                                    storageType == "category" ? LocalStorages.Storage_Category_Image_Uploads :
                                        storageType == "subcategory" ? LocalStorages.Storage_Sub_Category_Image_Uploads :
                                            storageType == "brand" ? LocalStorages.Storage_Brand_Image_Uploads : LocalStorages.Storage_Uploads;

            if (httpRequest.Files.Count > 0)
            {
                try
                {
                    var postedFile = httpRequest.Files[0];
                    res.Data = Utilities.UploadFile(postedFile, new FileUploadSettings
                    {
                        FileType = FileType.Image,
                        MaxSize = 5,
                        StoragePath = storagePath
                    });

                    res.Result = ApiResult.Success;

                    return Ok(res);
                }
                catch (Exception ex)
                {
                    res.Result = ApiResult.Error;

                    return BadRequest(ex.Message);
                }
            }
            else
            {
                return InternalServerError();
            }
        }
         
        [Route("delete-image")]
        [HttpDelete]
        [TwoFactorAhorize]
        public IHttpActionResult DeleteImages(string imageUrl)
             {
            var res = new ReturnObject<bool>();
            try
            {
                if (File.Exists(imageUrl.MapPath()))
                {
                    File.Delete(imageUrl.MapPath());
                    res.IsSuccess = true;
                    res.Data = true;
                }

                res.Result = ApiResult.Success;

                return Ok(res);
            }
            catch (Exception ex)
            {
                res.Result = ApiResult.Error;

                return BadRequest(ex.Message);
            }
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
