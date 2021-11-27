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
    public static class QuantityMeasureMapper
    {
        public static object MapToQuantityMeasureModelList<T>(this IQueryable<QuantityMeasure> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }
            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(QuantityMeasureViewModel))
            {
                _query = query.Select(model => new QuantityMeasureViewModel
                {
                    Id = model.Id,
                    QuantityMeasureName = model.QuantityMeasureName,
                    Acronym = model.Acronym, 
                    Enabled = model.Enabled
                });;
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var res = query.Select(model => new OListItem
                {
                    Text = model.Acronym,
                    Value = model.Id.ToString(),
                    Extras = new
                    {
                        FullName = model.QuantityMeasureName,
                        model.Enabled,
                    },
                    Selected = id != -1 ? model.Id == id : false,
                });
                return res.ToList();
            }
            else if (typeof(T) == typeof(Array))
            {
                int id = obj.NullReverse();
                var res = query.Select(model => model.QuantityMeasureName);
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

        public static T MapToQuantityMeasureModel<T>(this QuantityMeasure model, object obj = null)
        {
            if (typeof(T) == typeof(QuantityMeasureViewModel))
            {
                var returnObj = new QuantityMeasureViewModel
                {
                    Id = model.Id, 
                    QuantityMeasureName = model.QuantityMeasureName,
                    Acronym = model.Acronym,
                    Enabled = model.Enabled
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem))
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.Acronym,
                    Value = model.Id.ToString(),
                    Extras = new
                    {
                        FullName = model.QuantityMeasureName,
                        model.Enabled
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

        public static IQueryable<QuantityMeasure> MapToQuantityMeasureEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToQuantityMeasureEntity(model, obj));
        }

        public static QuantityMeasure MapToQuantityMeasureEntity(this BaseModel model, object obj = null)
        {
            QuantityMeasure QuantityMeasure = null;

            if (model is QuantityMeasureViewModel)
            {
                var _model = (QuantityMeasureViewModel)model;
                QuantityMeasure = new QuantityMeasure()
                {
                    Id = _model.Id,
                    QuantityMeasureName = _model.QuantityMeasureName,
                    Acronym = _model.Acronym,
                    Enabled = model.Enabled
                };
            }
            else if (model is QuantityMeasureRequestVM)
            {
                var _model = (QuantityMeasureRequestVM)model;
                QuantityMeasure = new QuantityMeasure()
                {
                    Id = _model.Id,
                    QuantityMeasureName = _model.QuantityMeasureName,
                    Acronym = _model.Acronym,
                    Enabled = model.Enabled
                };
            }
            return QuantityMeasure;
        }
    }
}