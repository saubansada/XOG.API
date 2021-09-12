using System.Linq;
using XOG.AppCode.DAL;
using XOG.Helpers;
using XOG.Models;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.AppCode.Models;
using XOG.Util;
using XOG.Models.ViewModels;
using System;
using XOG.Models.ViewModels.RequestViewModels.Data;

namespace XOG.AppCode.Mappers
{
    public static class BrandMapper
    {
        public static object MapToBrandModelListing<T>(this IQueryable<Brand> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(BrandViewModel))
            {
                _query = query.Select(model => new BrandViewModel
                {
                    Id = model.Id,
                    BrandDescription = model.BrandDescription,
                    BrandUrl = model.BrandUrl,
                    BrandName = model.BrandName
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.BrandName,
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

        public static T MapToBrandModel<T>(this Brand model, object obj = null)
        {
            if (typeof(T) == typeof(BrandViewModel))
            {
                var returnObj = new BrandViewModel
                {
                    Id = model.Id,
                    BrandDescription = model.BrandDescription,
                    BrandUrl = model.BrandUrl,
                    BrandName = model.BrandName
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.BrandName,
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

        public static IQueryable<Brand> MapToBrandEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToBrandEntity(model, obj));
        }

        public static Brand MapToBrandEntity(this BaseModel model, object obj = null)
        {
            Brand Brand = null;

            if (model is BrandViewModel)
            {
                var _model = (BrandViewModel)model;
                Brand = new Brand()
                {
                    Id = _model.Id,
                    BrandDescription = _model.BrandDescription,
                    BrandUrl = _model.BrandUrl,
                    BrandName = _model.BrandName
                };
            }
            else if (model is BrandRequestVM)
            {
                var _model = (BrandRequestVM)model;
                Brand = new Brand()
                {
                    Id = _model.Id,
                    BrandDescription = _model.BrandDescription,
                    BrandUrl = _model.BrandUrl,
                    BrandName = _model.BrandName
                };

            }
            return Brand;
        }

    }
}