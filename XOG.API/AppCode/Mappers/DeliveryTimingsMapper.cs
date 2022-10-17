using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Util;

namespace XOG.AppCode.Mappers
{
    public static class DeliveryTimingsMapper
    {
        public static object MapToDeliveryTimingModelList<T>(this IQueryable<WeekDayTiming> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(WeekDayTimingViewModel))
            {
                _query = query.Select(model => new WeekDayTimingViewModel
                {
                    Id = model.WeekDayId,
                    DayName = model.DayName,
                    FromHours = model.FromHours ?? 0,
                    FromMinutes = model.FromMinutes ?? 0,
                    ToHours = model.ToHours ?? 0,
                    IsActive = model.IsTimingActive ?? false,
                    IsDayActive = model.IsWeekDayActive
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var res = query.Select(model => new OListItem
                {
                    Text = model.DayName + " " + model.FromHours + ":" + model.FromMinutes + " - " + model.ToHours + ":" + model.ToMinutes,
                    Value = model.WeekDayId + ""
                });
                return res.ToList();
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();
                var res = query.Select(model => model.DayName);
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

        public static T MapToDeliveryTimingModel<T>(this WeekDayTiming model, object obj = null)
        {
            if (typeof(T) == typeof(WeekDayTimingViewModel))
            {
                var returnObj = new WeekDayTimingViewModel
                {
                    Id = model.WeekDayId,
                    DayName = model.DayName,
                    FromHours = model.FromHours ?? 0,
                    FromMinutes = model.FromMinutes ?? 0,
                    ToHours = model.ToHours ?? 0,
                    IsActive = model.IsTimingActive ?? false,
                    IsDayActive = model.IsWeekDayActive
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem))
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.DayName + " " + model.FromHours + ":" + model.FromMinutes + " - " + model.ToHours + ":" + model.ToMinutes,
                    Value = model.WeekDayId + ""
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(model, typeof(T));
            }
        }

        public static IQueryable<DeliveryTiming> MapToDeliveryTimingEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToDeliveryTimingEntity(model, obj));
        }
         
        public static DeliveryTiming MapToDeliveryTimingEntity(this BaseModel model, object obj = null)
        {
            DeliveryTiming WeekDayTiming = null;

            if (model is WeekDayTimingViewModel)
            {
                var _model = (WeekDayTimingViewModel)model;
                WeekDayTiming = new DeliveryTiming()
                { 
                    FromHours = _model.FromHours,
                    FromMinutes = _model.FromMinutes,
                    ToHours = _model.ToHours,
                    IsActive = _model.IsActive,
                    ToMinutes = _model.ToMinutes,
                    Id = _model.Id,
                    DayId = _model.DayId
                };
            }
            else if (model is DeliveryTimingRequestVM)
            {
                var _model = (DeliveryTimingRequestVM)model;
                WeekDayTiming = new DeliveryTiming()
                {
                    FromHours = _model.FromHours,
                    FromMinutes = _model.FromMinutes,
                    ToHours = _model.ToHours,
                    IsActive = _model.IsActive,
                    ToMinutes = _model.ToMinutes,
                    Id = _model.Id,
                    DayId = _model.DayId
                };
            } 
            else if (model is WeekDayStatusRequestVM)
            {
                var __model = (WeekDayStatusRequestVM)model;
                var _model = __model.DeliveryTimings;
                WeekDayTiming = new DeliveryTiming()
                {
                    FromHours = _model.FromHours,
                    FromMinutes = _model.FromMinutes,
                    ToHours = _model.ToHours,
                    IsActive = _model.IsActive,
                    ToMinutes = _model.ToMinutes,
                    Id = _model.Id,
                    DayId = _model.DayId
                };
            }
            return WeekDayTiming;
        }
          
        public static WeekDayStatus MapToWeekDayStatusEntity(this BaseModel model, object obj = null)
        {
            WeekDayStatus WeekDayStatus = new WeekDayStatus();

            if (model is WeekDayStatusRequestVM)
            {
                var _model = (WeekDayStatusRequestVM)model;
                WeekDayStatus = new WeekDayStatus()
                {
                    Id = _model.DayId, 
                    IsActive = _model.IsDayActive,
                    DayName = _model.DayName,
                };
            } 
            return WeekDayStatus;
        }
    }
}
