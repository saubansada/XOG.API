using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Util;

namespace XOG.AppCode.Transformers
{
    public static class CartTransformer
    {   
        public static object TransformToCartModelListing(this IQueryable<Cart> query, object obj = null, ModelType type = ModelType.Default, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            //if (type == ModelType.AdminView)
            //{
            //    _query = query.Select(model => new CartAdminModel()
            //    {
            //        Id = model.Id,
            //        SubCategoryId = model.SubCategoryId,
            //        BrandId = model.BrandId,
            //        CartName = model.CartName,
            //        Mrp = model.Mrp,
            //        Measure = (MeasureType)model.Measure,
            //        Gst = model.Gst,
            //        Cost = model.Cost,
            //        Volume = model.Volume,
            //        StocksAvailable = model.StocksAvailable,
            //        DiscountPercentage = model.DiscountPercentage,
            //        Description = model.Description,
            //        CartImage = model.CartImages.Select(i => i.ImageUrl).ToList(),
            //        Enabled = model.Enabled,
            //        MaxPurchase = model.MaxPurchase
            //    });
            //}
            //else 

            if (type == ModelType.UserView)
            {
                _query = query.Select(model => new CartViewModel
                {
                    Id = model.Id, 
                    ProductId = model.ProductId ?? -1,
                    AddedByUserId = model.AddedByUserId,
                    CartCount = model.Quantity ?? 0,
                    MaxPurchase = model.Product.MaxPurchase
                });
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.Product.ProductName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).ToList();
            } 
            else if (type == ModelType.NameArray)
            {
                int id = obj.NullReverse();
                return query.Select(model => model.Product.ProductName).ToArray();
            }

            if (listType == ListingType.Queryable)
            {
                return _query;
            }
            else if (listType == ListingType.GridList && obj != null)
            {
                _query = _query.UpdateGridModelList((GridModel)obj);
            }
            return _query.ToList();
        }
         
        public static object TransformToCartModel(this Cart model, ModelType type = ModelType.Default, object obj = null)
        {
        //    if (type == ModelType.AdminView)
        //    {
        //        return model == null ? null : new CartAdminModel()
        //        {
        //            Id = model.Id,
        //            SubCategoryId = model.SubCategoryId,
        //            BrandId = model.BrandId,
        //            CartName = model.CartName,
        //            Mrp = model.Mrp,
        //            Measure = (MeasureType)model.Measure,
        //            Gst = model.Gst,
        //            Cost = model.Cost,
        //            Volume = model.Volume,
        //            StocksAvailable = model.StocksAvailable,
        //            DiscountPercentage = model.DiscountPercentage,
        //            Description = model.Description,
        //            CartImage = model.CartImages.Select(i => i.ImageUrl).ToList(),
        //            Enabled = model.Enabled,
        //            MaxPurchase = model.MaxPurchase
        //        };
        //    }
           // else 
           if (type == ModelType.UserView)
            {
                var _obj = new CartViewModel
                {
                    Id = model.Id,
                    ProductId = model.ProductId ?? -1,
                    AddedByUserId = model.AddedByUserId,
                    CartCount = model.Quantity ?? 0,
                    MaxPurchase = model.Product.MaxPurchase
                }; 
                return _obj;
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return new OListItem
                {
                    Text = model.Product.ProductName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                };
            }
            else
            { 
                return model;
            }
        }
          
        public static IQueryable<Cart> GetCartDALQueryable(IQueryable<BaseModel> query, ModelType type = ModelType.Default, object obj = null)
        {
            return query == null ? null : query.Select(model => TransformToCartDALObject(model, type, obj));
        }

        public static Cart TransformToCartDALObject(this BaseModel model, ModelType type = ModelType.Default, object obj = null)
        {
            Cart Cart = null;

            //if (model is CartAdminModel)
            //{
            //    var _model = (CartAdminModel)model;
            //    //_model.CartImage = _model.CartImage.Substring(_model.CartImage.LastIndexOf('/') + 1, _model.CartImage.Length);
            //    Cart = new  Cart()
            //    {
            //        ProductId = _model.Id,
            //        Quantity = _model.CartCount

            //    };  
            //}
            // else 
            if (model is CartViewModel)
            {
                var _model = (CartViewModel)model;
                Cart = new Cart()
                {
                    Id = _model.Id,
                    ProductId = _model.ProductId,
                    AddedByUserId = _model.AddedByUserId,
                    Quantity = _model.CartCount, 
                }; 

            }

            return Cart; 
        }
         
    }
}