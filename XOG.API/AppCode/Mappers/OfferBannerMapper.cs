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
    public static class OfferBannerTransformer
    {
        public static object MapToOfferBannerModelList<T>(this IQueryable<OfferBanner> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            query = _query.Select(model => (OfferBanner)model);

            var list = query.ToList();

            if (typeof(T) == typeof(OfferBannerViewModel))
            {
                var orders = list.Select(model => new OfferBannerViewModel()
                {
                    Id = model.Id,
                    DisplayName = model.DisplayName,
                    Description = model.Description,
                    Enabled = model.Enabled ?? false,
                    OfferUrl = model.OfferUrl,
                    OfferId = model.OfferId,
                    BannerImageUrl = model.BannerImageUrl,
                    Placement = (OfferBannerPlacement)model.Placement,
                    OfferStatus = model.Enabled ?? false ? OfferStatus.Active : OfferStatus.InActive,
                    OfferDetails = model.Offer.OfferDetails.Select(item =>
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

        public static object MapToOfferBannerModel<T>(this IQueryable<OfferBanner> vList, object obj = null)
        {
            var list = vList.ToList();
            if (typeof(T) == typeof(OfferBannerViewModel))
            {
                var res = list.Select(model => new OfferBannerViewModel()
                {
                    Id = model.Id,
                    DisplayName = model.DisplayName,
                    Description = model.Description,
                    Enabled = model.Enabled ?? false,
                    OfferUrl = model.OfferUrl,
                    OfferId = model.OfferId,
                    BannerImageUrl = model.BannerImageUrl,
                    OfferStatus = model.Enabled ?? false ? OfferStatus.Active : OfferStatus.InActive,
                    Placement = (OfferBannerPlacement)model.Placement,
                    OfferDetails = model.Offer.OfferDetails.Select(item =>
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

        public static IQueryable<OfferBanner> MapOfferBannerEtityQueryable(IQueryable<BaseModel> query)
        {
            return query == null ? null : query.Select(model => MapToOfferBannerEntity(model));
        }

        public static OfferBanner MapToOfferBannerEntity(this BaseModel model)
        {
            OfferBanner offer = new OfferBanner();

            if (model is OfferBannerRequestVM)
            {
                var _model = model as OfferBannerRequestVM;
                offer = new OfferBanner()
                {
                    Id = _model.Id,
                    DisplayName = _model.DisplayName,
                    Description = _model.Description,
                    OfferUrl = _model.OfferUrl,
                    BannerImageUrl = _model.BannerImageUrl,
                    Enabled = _model.OfferStatus == OfferStatus.Active,
                    OfferId = _model.OfferId,
                    Placement = (byte)_model.Placement
                };
            }
            else if (model is OfferBannerViewModel)
            {

                var _model = model as OfferBannerViewModel;
                offer = new OfferBanner()
                {
                    Id = _model.Id,
                    DisplayName = _model.DisplayName,
                    Description = _model.Description,
                    OfferUrl = _model.OfferUrl,
                    BannerImageUrl = _model.BannerImageUrl,
                    Enabled = _model.OfferStatus == OfferStatus.Active,
                    OfferId = _model.OfferId,
                    Placement = (byte)_model.Placement
                };
            } 

            return offer;
        }
    }
}