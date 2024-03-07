using System;
using System.Collections.Generic;
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
    public static class AddressMapper
    {
        public static object MapToAddressModelListing<T>(this IQueryable<Address> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(AddressViewModel))
            {
                _query = query.Select(model => new AddressViewModel
                {
                    Id = model.Id,

                    AddressOfUserId = model.AddressOfUserId,

                    FullName = model.FullName,

                    PhoneNumber = model.PhoneNumber,

                    AreaCode = model.AreaCode,

                    AddressLine1 = model.AddressLine1,

                    AddressLine2 = model.AddressLine2,

                    LandMark = model.LandMark,

                    Country = model.Country,

                    GPS = model.GPS,

                    IsDefault = model.IsDefault
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.AddressLine1 + model.AddressLine2,
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

        public static T MapToAddressModel<T>(this Address model, object obj = null)
        {
            if (typeof(T) == typeof(AddressViewModel))
            {
                var returnObj = new AddressViewModel
                {
                    Id = model.Id, 
                    AddressOfUserId = model.AddressOfUserId,
                    FullName = model.FullName, 
                    PhoneNumber = model.PhoneNumber, 
                    AreaCode = model.AreaCode, 
                    AddressLine1 = model.AddressLine1, 
                    AddressLine2 = model.AddressLine2, 
                    LandMark = model.LandMark, 
                    Country = model.Country, 
                    GPS = model.GPS,
                    IsDefault = model.IsDefault
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.AddressLine1 + model.AddressLine2,
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

        public static IQueryable<Address> MapToAddressEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToAddressEntity(model, obj));
        }

        public static Address MapToAddressEntity(this BaseModel model, object obj = null)
        {
            Address Address = null;

            if (model is AddressViewModel)
            {
                var _model = (AddressViewModel)model;
                Address = new Address()
                {
                    Id = _model.Id,
                    AddressOfUserId = _model.AddressOfUserId,
                    FullName = _model.FullName,
                    PhoneNumber = _model.PhoneNumber,
                    AreaCode = _model.AreaCode,
                    AddressLine1 = _model.AddressLine1,
                    AddressLine2 = _model.AddressLine2,
                    LandMark = _model.LandMark,
                    Country = _model.Country,
                    GPS = _model.GPS,
                    IsDefault = _model.IsDefault
                };
            }
            else if (model is AddressRequestVM)
            {
                var _model = (AddressRequestVM)model;
                Address = new Address()
                {
                    Id = _model.Id,
                    AddressOfUserId = _model.AddressOfUserId,
                    FullName = _model.FullName,
                    PhoneNumber = _model.PhoneNumber,
                    AreaCode = _model.AreaCode,
                    AddressLine1 = _model.AddressLine1,
                    AddressLine2 = _model.AddressLine2,
                    LandMark = _model.LandMark,
                    Country = _model.Country,
                    GPS = _model.GPS,
                    IsDefault = _model.IsDefault
                };

            }
            return Address;
        }

    }
}