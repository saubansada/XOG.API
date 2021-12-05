using System;
using System.Data.Entity;
using System.Linq;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.ResponseViewModels;
using XOG.Util;

namespace XOG.AppCode.Mappers
{
    public static class UserMapper
    {
        public static object MapToUserModelList<T>(this IQueryable<AspNetUser> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }
            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(UserViewModel))
            {
                _query = query.Select(model => new UserViewModel
                {
                    Id = model.Id,
                    UserType = model.UserType,
                    Email = model.Email,
                    EmailConfirmed = model.EmailConfirmed,
                    SecurityStamp = model.SecurityStamp,
                    PhoneNumber = model.PhoneNumber,
                    PhoneNumberConfirmed = model.PhoneNumberConfirmed,
                    TwoFactorEnabled = model.TwoFactorEnabled,
                    LockoutEndDateUtc = model.LockoutEndDateUtc,
                    LockoutEnabled = model.LockoutEnabled,
                    AccessFailedCount = model.AccessFailedCount,
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    RegistrationDate = model.RegistrationDate,
                    AlternateMobileNumber = model.AlternateMobileNumber,
                    Roles = model.AspNetRoles.Select(i =>
                        new UserRoleVM
                        {
                            Id = i.Id,
                            Name = i.Name
                        }).ToList()
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                string id = (string)obj;
                var res = query.Select(model => new OListItem
                {
                    Text = model.UserName,
                    Value = model.Id.ToString(),
                    Selected = !string.IsNullOrWhiteSpace(id) ? model.Id == id : false
                });
                return res.ToList();
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();
                var res = query.Select(model => model.UserName);
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

        public static T MapToUserModel<T>(this AspNetUser model, object obj = null)
        {
            if (typeof(T) == typeof(UserViewModel))
            {
                var returnObj = new UserViewModel
                {
                    Id = model.Id,
                    UserType = model.UserType,
                    Email = model.Email,
                    EmailConfirmed = model.EmailConfirmed,
                    SecurityStamp = model.SecurityStamp,
                    PhoneNumber = model.PhoneNumber,
                    PhoneNumberConfirmed = model.PhoneNumberConfirmed,
                    TwoFactorEnabled = model.TwoFactorEnabled,
                    LockoutEndDateUtc = model.LockoutEndDateUtc,
                    LockoutEnabled = model.LockoutEnabled,
                    AccessFailedCount = model.AccessFailedCount,
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    RegistrationDate = model.RegistrationDate,
                    AlternateMobileNumber = model.AlternateMobileNumber,
                    DefaultAddress = model.Addresses.Count == 0 ? null : (model.Addresses.Count == 1 ? model.Addresses : model.Addresses.Where(i => i.IsDefault)).Select(m => 
                    new UserAddressVM
                    {
                        Id = m.Id,
                        PhoneNumber = m.PhoneNumber,
                        AddressLine1 = m.AddressLine1,
                        AddressLine2 = m.AddressLine2,
                        LandMark = m.LandMark,
                        AreaCode = m.AreaCode,
                        Country = m.Country,
                        FullName = m.FullName,
                        GPS = m.GPS,
                        IsDefault = m.IsDefault
                    }).First(),
                    Roles = model.AspNetRoles.Select(i =>
                        new UserRoleVM
                        {
                            Id = i.Id,
                            Name = i.Name
                        }).ToList()
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem))
            {
                string id = (string)obj;
                var returnObj = new OListItem
                {
                    Text = model.UserName,
                    Value = model.Id.ToString(),
                    Selected = !string.IsNullOrWhiteSpace(id) ? model.Id == id : false
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(model, typeof(T));
            }
        }

        public static IQueryable<AspNetUser> MapToAspNetUserEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToAspNetUserEntity(model, obj));
        }

        public static AspNetUser MapToAspNetUserEntity(this BaseModel model, object obj = null)
        {
            AspNetUser User = null;

            if (model is UserViewModel)
            {
                var _model = (UserRequestVM)model;

                User = new AspNetUser()
                {
                    Id = _model.Id,
                    UserType = _model.UserType.ToString(),
                    Email = _model.Email,
                    EmailConfirmed = _model.EmailConfirmed,
                    SecurityStamp = _model.SecurityStamp,
                    PhoneNumber = _model.PhoneNumber,
                    PhoneNumberConfirmed = _model.PhoneNumberConfirmed,
                    TwoFactorEnabled = _model.TwoFactorEnabled,
                    LockoutEndDateUtc = _model.LockoutEndDateUtc,
                    LockoutEnabled = _model.LockoutEnabled,
                    AccessFailedCount = _model.AccessFailedCount,
                    UserName = _model.UserName,
                    FirstName = _model.FirstName,
                    LastName = _model.LastName,
                    RegistrationDate = _model.RegistrationDate,
                    AlternateMobileNumber = _model.AlternateMobileNumber,
                };
            }
            else if (model is UserRequestVM)
            {
                var _model = (UserRequestVM)model;
                User = new AspNetUser()
                {
                    Id = _model.Id,
                    UserType = _model.UserType.ToString(),
                    Email = _model.Email,
                    EmailConfirmed = _model.EmailConfirmed,
                    SecurityStamp = _model.SecurityStamp,
                    PhoneNumber = _model.PhoneNumber,
                    PhoneNumberConfirmed = _model.PhoneNumberConfirmed,
                    TwoFactorEnabled = _model.TwoFactorEnabled,
                    LockoutEndDateUtc = _model.LockoutEndDateUtc,
                    LockoutEnabled = _model.LockoutEnabled,
                    AccessFailedCount = _model.AccessFailedCount,
                    UserName = _model.UserName,
                    FirstName = _model.FirstName,
                    LastName = _model.LastName,
                    RegistrationDate = _model.RegistrationDate,
                    AlternateMobileNumber = _model.AlternateMobileNumber,
                };
            }
            return User;
        }

        internal static T UnProxy<T>(this T proxyObject, DbContext context) where T : class
        {
            var proxyCreationEnabled = context.Configuration.ProxyCreationEnabled;
            try
            {
                context.Configuration.ProxyCreationEnabled = false;
                //T poco = context.Entry(proxyObject).CurrentValues.ToObject() as T;
                return proxyObject;
            }
            finally
            {
                context.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
            }
        }
    }
}