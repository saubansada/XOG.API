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
    public static class SubCategoryTransformer
    {
        public static object TransformToSubCategoryModelListing(this IQueryable<SubCategory> query, object obj = null, ModelType type = ModelType.Default, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (type == ModelType.AdminView)
            {
                _query = query.Select(model => new SubCategoryVM()
                {
                    Id = model.Id,
                    CategoryId = model.CategoryId,
                    SubCategoryDescription = model.SubCategoryDescription,
                    SubCategoryName = model.SubCategoryName
                });
            }
            else if (type == ModelType.UserView)
            {
                _query = query.Select(model => new SubCategoryViewModel
                {
                    Id = model.Id,
                    CategoryId = model.CategoryId,
                    SubCategoryDescription = model.SubCategoryDescription,
                    SubCategoryName = model.SubCategoryName,
                    RouteKey = model.RouteKey
                });
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.SubCategoryName,
                    Value = model.Id.ToString(),
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

        public static object TransformToSubCategoryModel(this SubCategory model, ModelType type = ModelType.Default, object obj = null)
        {
            if (type == ModelType.AdminView)
            {
                return model == null ? null : new SubCategoryVM()
                {
                    Id = model.Id,
                    CategoryId = model.CategoryId,
                    SubCategoryDescription = model.SubCategoryDescription,
                    SubCategoryName = model.SubCategoryName
                };
            }
            else if (type == ModelType.UserView)
            {
                return new SubCategoryViewModel
                {
                    Id = model.Id,
                    CategoryId = model.CategoryId,
                    SubCategoryDescription = model.SubCategoryDescription,
                    SubCategoryName = model.SubCategoryName,
                    RouteKey = model.RouteKey
                };
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return new OListItem
                {
                    Text = model.SubCategoryName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                };
            }
            else
            {
                return model;
            }
        }

        public static IQueryable<SubCategory> GetSubCategoryDALQueryable(IQueryable<BaseModel> query, ModelType type = ModelType.Default, object obj = null)
        {
            return query == null ? null : query.Select(model => TransformToSubCategoryDALObject(model, type, obj));
        }

        public static SubCategory TransformToSubCategoryDALObject(this BaseModel model, ModelType type = ModelType.Default, object obj = null)
        {
            SubCategory SubCategory = null;

            if (model is SubCategoryVM)
            {
                var _model = (SubCategoryVM)model;
                SubCategory = new SubCategory()
                {
                    Id = _model.Id,
                    CategoryId = _model.CategoryId,
                    SubCategoryDescription = _model.SubCategoryDescription,
                    SubCategoryName = _model.SubCategoryName,
                    RouteKey = _model.SubCategoryName.ToRouteKey()
                };
            }
            else if (model is SubCategoryViewModel)
            {
                var _model = (SubCategoryViewModel)model;
                SubCategory = new SubCategory()
                {
                    Id = _model.Id,
                    CategoryId = _model.CategoryId,
                    SubCategoryDescription = _model.SubCategoryDescription,
                    SubCategoryName = _model.SubCategoryName,
                    RouteKey = _model.SubCategoryName.ToRouteKey()
                };
            } 
            return SubCategory;
        } 

    }
}