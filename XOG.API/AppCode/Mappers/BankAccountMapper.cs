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
    public static class BankAccountMapper
    {
        public static object MapToBankAccountModelListing<T>(this IQueryable<BankAccount> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(BankAccountViewModel))
            {
                _query = query.Select(model => new BankAccountViewModel
                {
                    Id = model.Id,
                    AccountOfUserId = model.AccountOfUserId,
                    BankName = model.BankName,
                    AccountName = model.AccountName,
                    AccountNumber = model.AccountNumber,
                    IFSCCode = model.IFSCCode
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.AccountNumber + model.AccountNumber,
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

        public static T MapToBankAccountModel<T>(this BankAccount model, object obj = null)
        { 
            if (typeof(T) == typeof(BankAccountViewModel))
            {
                var returnObj = new BankAccountViewModel
                {
                    Id = model.Id,
                    AccountOfUserId = model.AccountOfUserId,
                    AccountName = model.AccountName,
                    BankName = model.BankName,
                    AccountNumber = model.AccountNumber,
                    IFSCCode = model.IFSCCode
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.AccountNumber + model.AccountNumber,
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

        public static IQueryable<BankAccount> MapToBankAccountEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToBankAccountEntity(model, obj));
        }

        public static BankAccount MapToBankAccountEntity(this BaseModel model, object obj = null)
        {
            BankAccount BankAccount = null;

            if (model is BankAccountViewModel)
            {
                var _model = (BankAccountViewModel)model;
                BankAccount = new BankAccount()
                {
                    Id = _model.Id,
                    AccountOfUserId = _model.AccountOfUserId,
                    AccountName = _model.AccountName,
                    BankName = _model.BankName,
                    AccountNumber = _model.AccountNumber,
                    IFSCCode = _model.IFSCCode
                };
            }
            else if (model is BankAccountRequestVM)
            {
                var _model = (BankAccountRequestVM)model;
                BankAccount = new BankAccount()
                {
                    Id = _model.Id,
                    AccountOfUserId = _model.AccountOfUserId,
                    AccountName = _model.AccountName,
                    BankName = _model.BankName,
                    AccountNumber = _model.AccountNumber,
                    IFSCCode = _model.IFSCCode
                };

            }
            return BankAccount;
        }

    }
}