using System;
using System.Linq;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Util;

namespace XOG.AppCode.Mappers
{
    public static class ProductGroupMapper
    {
        public static object MapToProductGroupModelList<T>(this IQueryable<ProductGroup> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }
            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(ProductGroupViewModel))
            {
                _query = query.Select(model => new ProductGroupViewModel
                {
                    Id = model.Id,
                    SubCategoryId = model.SubCategoryId,
                    SubCategoryName = model.SubCategory.SubCategoryName,
                    ProductGroupDescription = model.ProductGroupDescription,
                    ProductGroupName = model.ProductGroupName,
                    CategoryId = model.SubCategory.CategoryId,
                    CategoryName = model.SubCategory.Category.CategoryName,
                    ProductGroupImage = model.ImageUrl,
                    RouteKey = model.RouteKey
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var res = query.Select(model => new OListItem
                {
                    Text = model.ProductGroupName,
                    Value = model.Id.ToString(),
                    Extras = new
                    {
                        FilterId = model.SubCategoryId
                    },
                    Selected = id != -1 ? model.Id == id : false,
                });
                return res.ToList();
            }
            else if (typeof(T) == typeof(Array))
            {
                int id = obj.NullReverse();
                var res = query.Select(model => model.ProductGroupName);
                return res;
            }

            if (listType == ListingType.Queryable)
            {
                return (T)Convert.ChangeType(_query, typeof(T)); ;
            }
            else if (listType == ListingType.GridList && obj != null)
            {
                _query = _query.UpdateGridModelList((GridModel)obj);
            }
            return _query.ToList();
        }

        public static T MapToProductGroupModel<T>(this ProductGroup model, object obj = null)
        {
            if (typeof(T) == typeof(ProductGroupViewModel))
            {
                var returnObj = new ProductGroupViewModel
                {
                    Id = model.Id,
                    SubCategoryId = model.SubCategoryId,
                    SubCategoryName = model.SubCategory.SubCategoryName,
                    ProductGroupDescription = model.ProductGroupDescription,
                    ProductGroupName = model.ProductGroupName,
                    CategoryId = model.SubCategory.CategoryId,
                    CategoryName = model.SubCategory.Category.CategoryName,
                    ProductGroupImage = model.ImageUrl,
                    RouteKey = model.RouteKey
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem))
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.ProductGroupName,
                    Value = model.Id.ToString(),
                    Extras = new
                    {
                        FilterId = model.SubCategory.Id,
                    },
                    Selected = id != -1 ? model.Id == id : false
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(model, typeof(T));
            }
        }

        public static IQueryable<ProductGroup> MapToProductGroupEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToProductGroupEntity(model, obj));
        }

        public static ProductGroup MapToProductGroupEntity(this BaseModel model, object obj = null)
        {
            ProductGroup ProductGroup = null;

            if (model is ProductGroupViewModel)
            {
                var _model = (ProductGroupViewModel)model;
                ProductGroup = new ProductGroup()
                {
                    Id = _model.Id,
                    SubCategoryId = (short)_model.SubCategoryId,
                    ProductGroupDescription = _model.ProductGroupDescription,
                    ProductGroupName = _model.ProductGroupName,
                    ImageUrl = _model.ProductGroupImage,
                    RouteKey = _model.ProductGroupName.ToRouteKey()
                };
            }
            else if (model is ProductGroupRequestVM)
            {
                var _model = (ProductGroupRequestVM)model;
                ProductGroup = new ProductGroup()
                {
                    Id = _model.Id,
                    SubCategoryId = (short)_model.SubCategoryId,
                    ProductGroupDescription = _model.ProductGroupDescription,
                    ProductGroupName = _model.ProductGroupName,
                    ImageUrl = _model.ProductGroupImage,
                    RouteKey = _model.ProductGroupName.ToRouteKey()
                };
            }
            return ProductGroup;
        }
    }
}