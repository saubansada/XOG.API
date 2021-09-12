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
    public static class SubCategoryMapper
    {
        public static object MapToSubCategoryModelList<T>(this IQueryable<SubCategory> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }
            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(SubCategoryViewModel))
            {
                _query = query.Select(model => new SubCategoryViewModel
                {
                    Id = model.Id,
                    CategoryId = model.CategoryId,
                    CategoryName = model.Category.CategoryName,
                    SubCategoryDescription = model.SubCategoryDescription,
                    SubCategoryName = model.SubCategoryName,
                    RouteKey = model.RouteKey
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var res = query.Select(model => new OListItem
                {
                    Text = model.SubCategoryName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                });
                return res.ToList();
            }
            else if (typeof(T) == typeof(Array))
            {
                int id = obj.NullReverse();
                var res = query.Select(model => model.SubCategoryName);
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

        public static T MapToSubCategoryModel<T>(this SubCategory model, object obj = null)
        {
            if (typeof(T) == typeof(SubCategoryViewModel))
            {
                var returnObj = new SubCategoryViewModel
                {
                    Id = model.Id,
                    CategoryId = model.CategoryId,
                    CategoryName = model.Category.CategoryName,
                    SubCategoryDescription = model.SubCategoryDescription,
                    SubCategoryName = model.SubCategoryName,
                    RouteKey = model.RouteKey
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem))
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.SubCategoryName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(model, typeof(T));
            }
        }

        public static IQueryable<SubCategory> MapToSubCategoryEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToSubCategoryEntity(model, obj));
        }

        public static SubCategory MapToSubCategoryEntity(this BaseModel model, object obj = null)
        {
            SubCategory SubCategory = null;

            if (model is SubCategoryViewModel)
            {
                var _model = (SubCategoryViewModel)model;
                SubCategory = new SubCategory()
                {
                    Id = _model.Id,
                    CategoryId = (byte)_model.CategoryId,
                    SubCategoryDescription = _model.SubCategoryDescription,
                    SubCategoryName = _model.SubCategoryName,
                    RouteKey = _model.SubCategoryName.ToRouteKey()
                };
            }
            else if (model is SubCategoryRequestVM)
            {
                var _model = (SubCategoryRequestVM)model;
                SubCategory = new SubCategory()
                {
                    Id = _model.Id,
                    CategoryId = (byte)_model.CategoryId,
                    SubCategoryDescription = _model.SubCategoryDescription,
                    SubCategoryName = _model.SubCategoryName,
                    RouteKey = _model.SubCategoryName.ToRouteKey()
                };
            }
            return SubCategory;
        }
    }
}