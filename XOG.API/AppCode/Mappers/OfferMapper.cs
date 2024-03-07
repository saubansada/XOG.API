using System;
using System.Collections.Generic;
using System.Linq;
using XOG.AppCode.BLL;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.AppCode.Models.FilterModels;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.Util;

namespace XOG.AppCode.Mappers
{
    public static class OfferTransformer
    {
        public static object MapToOfferModelList<T>(this IQueryable<Offer> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            query = _query.Select(model => (Offer)model);

            var list = query.ToList();

            if (typeof(T) == typeof(OfferViewModel))
            {
                var orders = list.Select(model => new OfferViewModel()
                {
                    Id = model.Id,
                    DisplayName = model.DisplayName,
                    Description = model.Description,
                    Enabled = model.Enabled ?? false,
                    OfferStatus = model.Enabled ?? false ? OfferStatus.Active : OfferStatus.InActive,
                    OfferDetails = model.OfferDetails.Select(item =>
                    new OfferDetailsViewModel()
                    {
                        Id = item.Id,
                        ProductId = item.ProductId,
                        OfferId = item.OfferId
                    }).ToList()
                }).ToList();

                return orders;
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();

                return list.Select(model => new OListItem
                {
                    Text = model.DisplayName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).ToList();
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

        public static object MapToOfferModel<T>(this IQueryable<Offer> vList, object obj = null)
        {
            var list = vList.ToList();
            if (typeof(T) == typeof(OfferViewModel))
            {
                var res = list.Select(model => new OfferViewModel()
                {
                    Id = model.Id,
                    DisplayName = model.DisplayName,
                    Description = model.Description,
                    Enabled = model.Enabled ?? false,
                    OfferStatus = model.Enabled ?? false ? OfferStatus.Active : OfferStatus.InActive,
                    OfferDetails = model.OfferDetails.Select(item =>
                    new OfferDetailsViewModel()
                    {
                        Id = item.Id,
                        ProductId = item.ProductId,
                        OfferId = item.OfferId
                    }).ToList()
                }).FirstOrDefault();

                return res;
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();
                return list.Select(model => new OListItem
                {
                    Text = model.DisplayName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).FirstOrDefault();
            }
            else
            {
                return list;
            }
        }

        public static IQueryable<Offer> MapOfferEtityQueryable(IQueryable<BaseModel> query)
        {
            return query == null ? null : query.Select(model => MapToOfferEntity(model));
        }

        public static Offer MapToOfferEntity(this BaseModel model)
        {
            Offer offer = new Offer();

            if (model is OfferRequestVM)
            {
                var _model = model as OfferRequestVM;
                offer = new Offer()
                {
                    Id = _model.Id,
                    DisplayName = _model.DisplayName,
                    Description = _model.Description,
                    Enabled = _model.OfferStatus == OfferStatus.Active,
                    OfferDetails = _model.OfferDetails.Select(item =>
                    new OfferDetail()
                    {
                        Id = item.Id,
                        ProductId = item.ProductId,
                        OfferId = _model.Id
                    }).ToList()
                };
            }
            else if (model is OfferViewModel)
            {

                var _model = model as OfferViewModel;
                offer = new Offer()
                {
                    Id = _model.Id,
                    DisplayName = _model.DisplayName,
                    Description = _model.Description,
                    Enabled = _model.OfferStatus == OfferStatus.Active,
                    OfferDetails = _model.OfferDetails.Select(item =>
                    new OfferDetail()
                    {
                        Id = item.Id,
                        ProductId = item.ProductId,
                        OfferId = _model.Id
                    }).ToList()
                };
            } 

            return offer;
        }
    }
}