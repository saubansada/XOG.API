using System.Linq;
using XOG.AppCode.DAL;
using XOG.Helpers;
using XOG.Models;
using XOG.AppCode.Models;
using XOG.Util;
using XOG.Models.ViewModels;
using System;
using XOG.Models.ViewModels.RequestViewModels.Data;
using System.Collections.Generic;

namespace XOG.AppCode.Mappers
{
    public static class CartMapper
    {
        public static object MapToCartModelListing<T>(this IQueryable<Cart> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(CartViewModel))
            {
                _query = query.Select(model => new CartViewModel
                {
                    Id = model.Id,
                    ProductVariantId = model.ProductVariantId ?? -1,
                    Quantity = model.Quantity ?? 0
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.ProductVariant.Product.ProductName,
                    Value = model.ProductVariantId.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).ToList();
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

        public static T MapToCartModel<T>(this Cart model, object obj = null)
        {
            if (typeof(T) == typeof(CartViewModel))
            {
                var returnObj = new CartViewModel
                {
                    Id = model.Id,
                    ProductVariantId = model.ProductVariantId ?? -1,
                    Quantity = model.Quantity ?? 0
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.ProductVariant.Product.ProductName,
                    Value = model.ProductVariantId.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(model, typeof(T));
            }
        }

        public static List<Cart> MapToCartEntityList(this List<CartViewModel> list, string userId)
        {
            return list.Select(model => (Cart)MapToCartEntity(model, userId)).ToList();
        }

        public static IQueryable<Cart> MapToCartEntityQueryable(IQueryable<BaseModel> query)
        {
            return query == null ? null : query.Select(model => MapToCartEntity(model, ""));
        }

        public static Cart MapToCartEntity(this BaseModel model, string userId)
        {
            Cart Cart = null;

            if (model is CartViewModel)
            {
                var _model = (CartViewModel)model;
                Cart = new Cart()
                {
                    Id = _model.Id,
                    AddedByUserId = userId,
                    ProductVariantId = _model.ProductVariantId,
                    Quantity = _model.Quantity
                };
            }
            //else if (model is CartRequestVM)
            //{
            //    var _model = (CartRequestVM)model.Cart;
            //    Cart = new Cart()
            //    {
            //        Id = _model.Id,
            //        ProductVariantId = _model.ProductVariantId,
            //        Quantity = _model.Quantity
            //    };

            //}
            return Cart;
        }

    }
}