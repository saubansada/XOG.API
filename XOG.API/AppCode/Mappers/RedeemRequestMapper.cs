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
    public static class RedeemRequestMapper
    {
        public static object MapToRedeemRequestModelListing<T>(this IQueryable<RedeemRequest> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(RedeemRequestViewModel))
            {
                _query = query.Select(model => new RedeemRequestViewModel
                {
                    Id = model.Id,
                    RequestedByUserId = model.BankAccount.AccountOfUserId,
                    BankAccountId = model.BankAccountId,
                    BankAccountNumber = model.BankAccount.AccountNumber,
                    Amount = model.Amount,
                    AccountName = model.BankAccount.AccountName,
                    BankName = model.BankAccount.BankName,
                    IFSCCode = model.BankAccount.IFSCCode,
                    PhoneNumber = model.BankAccount.AspNetUser.PhoneNumber,
                    RequestState = (ReemRequestStatus)model.RequestState,
                    RequestedUserFullName = model.BankAccount.AspNetUser.FirstName + " " + model.BankAccount.AspNetUser.LastName,
                    RequestDateTime = model.RequestDateTime,
                    RequestCompletionDateTime = model.RequestCompletionDateTime
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.Id + "",
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

        public static T MapToRedeemRequestModel<T>(this RedeemRequest model, object obj = null)
        {
            if (typeof(T) == typeof(RedeemRequestViewModel))
            {
                var returnObj = new RedeemRequestViewModel
                {
                    Id = model.Id,
                    RequestedByUserId = model.BankAccount.AccountOfUserId,
                    BankAccountId = model.BankAccountId,
                    BankAccountNumber = model.BankAccount.AccountNumber,
                    AccountName = model.BankAccount.AccountName,
                    BankName = model.BankAccount.BankName,
                    IFSCCode = model.BankAccount.IFSCCode,
                    Amount = model.Amount,
                    PhoneNumber = model.BankAccount.AspNetUser.PhoneNumber,
                    RequestedUserFullName = model.BankAccount.AspNetUser.FirstName + " " + model.BankAccount.AspNetUser.LastName,
                    RequestState = (ReemRequestStatus)model.RequestState,
                    RequestDateTime = model.RequestDateTime,
                    RequestCompletionDateTime = model.RequestCompletionDateTime
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.Id + "",
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

        public static IQueryable<RedeemRequest> MapToRedeemRequestEntityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToRedeemRequestEntity(model, obj));
        }

        public static RedeemRequest MapToRedeemRequestEntity(this BaseModel model, object obj = null)
        {
            RedeemRequest RedeemRequest = null;
             
            if (model is RedeemRequestViewModel)
            {
                var _model = (RedeemRequestViewModel)model;
                RedeemRequest = new RedeemRequest()
                {
                    Id = _model.Id,
                    RequestState = (byte)_model.RequestState,
                    Amount = _model.Amount,
                    BankAccountId = _model.BankAccountId,
                    RequestDateTime = System.DateTime.UtcNow,
                    RequestCompletionDateTime = System.DateTime.UtcNow
                };
            }
            else if (model is RedeemRequestRequestVM)
            {
                var _model = (RedeemRequestRequestVM)model;
                RedeemRequest = new RedeemRequest()
                {
                    Id = _model.Id,
                    RequestState = (byte)_model.RequestState,
                    Amount = _model.Amount,
                    BankAccountId = _model.BankAccountId,
                    RequestDateTime = System.DateTime.UtcNow,
                    RequestCompletionDateTime = System.DateTime.UtcNow
                };

            }
            return RedeemRequest;
        }

    }
}