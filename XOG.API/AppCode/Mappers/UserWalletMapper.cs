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
    public static class UserWalletMapper
    {
        public static object MapToUserWalletModelList<T>(this IQueryable<UserWallet> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }
            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(UserWalletViewModel))
            {
                _query = query.Select(model => new UserWalletViewModel
                {
                    UserId = model.WalletOfUserId,
                    Amount = Math.Abs(model.Amount ?? 0.0),
                    RequestType = model.Amount > 0 ? TransactionType.Debit : TransactionType.Credit,
                });
            }
            //else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            //{
            //    string id = (string)obj;
            //    var res = query.Select(model => new OListItem
            //    {
            //        Text = model.UserWalletName,
            //        Value = model.Id.ToString(),
            //        Selected = !string.IsNullOrWhiteSpace(id) ? model.Id + "" == id : false
            //    });
            //    return res.ToList();
            //}
            //else if (typeof(T) == typeof(string[]))
            //{
            //    int id = obj.NullReverse();
            //    var res = query.Select(model => model.);
            //    return res;
            //}

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

        public static T MapToUserWalletModel<T>(this UserWallet model, object obj = null)
        {
            if (typeof(T) == typeof(UserWalletViewModel))
            {
                var returnObj = new UserWalletViewModel
                {
                    UserId = model.WalletOfUserId,
                    Amount = Math.Abs(model.Amount ?? 0.0),
                    RequestType = model.Amount > 0 ? TransactionType.Debit : TransactionType.Credit,
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(model, typeof(T));
            }
        }

        public static IQueryable<UserWallet> MapToUserWalletEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToUserWalletEntity(model, obj));
        }

        public static UserWallet MapToUserWalletEntity(this BaseModel model, object obj = null)
        {
            UserWallet UserWallet = null;

            if (model is UserWalletViewModel)
            {
                var _model = (UserWalletViewModel)model;

                UserWallet = new UserWallet()
                {
                    Id = _model.Id,
                    WalletOfUserId = _model.UserId,
                    Amount = (_model.RequestType == TransactionType.Debit ? -1 : 1) * (_model.Amount ?? 0)
                };
            }
            else if (model is AddWalletRequestVM)
            {
                var _model = (AddWalletRequestVM)model;
                UserWallet = new UserWallet()
                {
                    Id = _model.Id,
                    WalletOfUserId = _model.UserId,
                    Amount = (_model.RequestType == TransactionType.Debit ? -1 : 1) * (_model.Amount)
                };
            }
            return UserWallet;
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