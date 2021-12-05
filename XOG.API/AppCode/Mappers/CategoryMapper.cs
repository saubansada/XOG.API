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
    public static class CategoryMapper
    {
        public static object MapToCategoryModelList<T>(this IQueryable<Category> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(CategoryViewModel))
            {
                _query = query.Select(model => new CategoryViewModel
                {
                    Id = model.Id,
                    CategoryDescription = model.CategoryDescription,
                    CategoryName = model.CategoryName,
                    CategoryBanner = model.CategoryBanner,
                    CategoryImage = model.CategoryImage,
                    RouteKey = model.RouteKey
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var res = query.Select(model => new OListItem
                {
                    Text = model.CategoryName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                });
                return res.ToList();
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();
                var res = query.Select(model => model.CategoryName);
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

        public static T MapToCategoryModel<T>(this Category model, object obj = null)
        {
            if (typeof(T) == typeof(CategoryViewModel))
            {
                var returnObj = new CategoryViewModel
                {
                    Id = model.Id,
                    CategoryDescription = model.CategoryDescription,
                    CategoryName = model.CategoryName,
                    CategoryBanner = model.CategoryBanner,
                    CategoryImage = model.CategoryImage,
                    RouteKey = model.RouteKey
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem))
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.CategoryName,
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

        public static IQueryable<Category> MapToCategoryEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToCategoryEntity(model, obj));
        }

        public static Category MapToCategoryEntity(this BaseModel model, object obj = null)
        {
            Category Category = null;

            if (model is CategoryViewModel)
            {
                var _model = (CategoryViewModel)model;
                Category = new Category()
                {
                    Id = _model.Id,
                    CategoryDescription = _model.CategoryDescription,
                    CategoryName = _model.CategoryName,
                    CategoryBanner = _model.CategoryBanner,
                    CategoryImage = _model.CategoryImage,
                    RouteKey = _model.CategoryName.ToRouteKey()
                };
            }
            else if (model is CategoryRequestVM)
            {
                var _model = (CategoryRequestVM)model;
                Category = new Category()
                {
                    Id = _model.Id,
                    CategoryDescription = _model.CategoryDescription,
                    CategoryName = _model.CategoryName,
                    CategoryBanner = _model.CategoryBanner,
                    CategoryImage = _model.CategoryImage,
                    RouteKey = _model.CategoryName.ToRouteKey()
                };
            }
            return Category;
        }
    }
}