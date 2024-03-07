using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Transactions;
using XOG.AppCode.DAL;
using XOG.Util;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOGModels.JsonModels;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Mappers;
using System.Threading.Tasks;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;

namespace XOG.AppCode.BLL
{
    public class OfferBL
    {
        internal XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }
        private IQueryable<Offer> GetFilteredWhereQuery(IQueryable<Offer> query, IOfferFilter filter)
        {
            if (filter != null)
            {
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ?
                    query.Where(i => i.DisplayName.Equals(filter.Search) || filter.Search.Contains(i.DisplayName)) : query;

                //query = !(string.IsNullOrWhiteSpace(filter.CustomerName)) ?
                //        query.Where(i => i.FirstName.Contains(filter.CustomerName) ||
                //        filter.CustomerName.Contains(i.AspNetUser.FirstName)) : query;

                //query = (filter.ItemsCountStart >= 0 && filter.ItemsCountEnd >= 0) ? query.Where(i => i.OfferDetails.Count() >= filter.ItemsCountStart && i.OfferDetails.Count() <= filter.ItemsCountEnd) :
                //            query;

                //query = query.Where(i => i.Offs > filter.OfferDateStart && i.OfferDate <= filter.OfferDateEnd);
            }

            return query;
        }

        private IQueryable<Offer> GetFilteredQuery<T>(IOfferFilter filter, XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetFilteredQuery<T>(filter, _context);
                }
            }
            return GetFilteredWhereQuery(context.Offers, filter);
        }

        internal object GetList<T>(IOfferFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetList<T>(_context, filter, listType, model);
            }
        }

        internal object GetList<T>(XOGEntities context, IOfferFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery<T>(filter, context);

            return query.MapToOfferModelList<T>(model, listType);
        }

        internal async Task<Dictionary<string, object>> AddOffer(Offer model)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await AddOffer(_context, model);
            }
        }

        internal async Task<Dictionary<string, object>> AddOffer(XOGEntities context, Offer model)
        {
            var res = new Dictionary<string, object>();

            try
            {
                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    context.OfferDetails.AddRange(model.OfferDetails);

                    context.Offers.Add(model);

                    ts.Complete();
                }

                await context.SaveChangesAsync();

                res.Add("DBStatus", DBStatus.Success);
                res.Add("OfferId", "" + model.Id);
                res.Add("Message", "Offer placed successfully!");
                res.Add("DetailedError", "");

                return res;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                res.Add("DbStatus", DBStatus.Error);
                res.Add("OfferId", "");
                res.Add("Message", "Error occurred while placing offer!");
                res.Add("DetailedError", ex.Message);
                return res;
            }
        }


        internal async Task<Dictionary<string, object>> UpdateAsync(Offer offer)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await UpdateAsync(_context, offer);
            }
        }

        internal async Task<Dictionary<string, object>> UpdateAsync(XOGEntities context, Offer offer)
        {
            var res = new Dictionary<string, object>();

            try
            {
                var existing = context.Offers.Find(offer.Id);

                if (offer == null || existing == null)
                {
                    throw new Exception("No Offer Found!");
                }

                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {

                    context.OfferDetails.AddRange(offer.OfferDetails.Where(i => existing.OfferDetails.Count(j => j.ProductId == i.ProductId) == 0).ToList());

                    context.OfferDetails.RemoveRange(existing.OfferDetails.Where(i => offer.OfferDetails.Count(j => j.ProductId == i.ProductId) == 0).ToList());

                    existing.DisplayName = offer.DisplayName;
                    existing.Description = offer.Description;
                    existing.Enabled = offer.Enabled;
                        
                    context.Offers.Attach(existing);

                    context.Entry(existing).State = EntityState.Modified;

                    await context.SaveChangesAsync();

                    ts.Complete();
                }

                res.Add("DBStatus", DBStatus.Success);
                res.Add("OfferId", "" + offer.Id);
                res.Add("Message", "Offer " + Enum.GetName(typeof(OfferStatus), (offer.Enabled ?? false) ? OfferStatus.Active : OfferStatus.InActive).ToLower() + " successfully!");
                res.Add("DetailedError", "");

                return res;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                res.Add("DbStatus", DBStatus.Error);
                res.Add("OfferId", offer.Id);
                res.Add("Message", "Error occurred while confirming offer!");
                res.Add("DetailedError", ex.Message);
                return res;
            }
        }

        internal async Task<object> GetOffer<T>(long id, string userId = "")
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception("Error Occurred");
                }
                return await GetOffer<T>(_context, id, userId);
            }
        }

        internal async Task<object> GetOffer<T>(XOGEntities context, long id = -1, string userId = "")
        {
            try
            {
                var user = context.AspNetUsers.Find(userId);

                var data = context.Offers.Where(i => i.Id == id);

                if (data == null || user == null)
                {
                    return null;
                }

                return await Task.FromResult(data.MapToOfferModel<T>());

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Error Occurred while Loading Offer" + ex.Message);

                return null;
            }
        }


        internal async Task<DBStatus> DeleteAsync(long Id, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await DeleteAsync(Id, _context);
                    }
                }
                if (context.Offers.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var offer = context.Offers.Where(i => i.Id == Id).SingleOrDefault();

                if (offer.OfferDetails != null && offer.OfferDetails.Count() > 0)
                {
                    context.OfferDetails.RemoveRange(offer.OfferDetails);
                }

                context.Offers.Remove(offer);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_OFFER.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(IOfferFilter OfferFilter, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await DeleteMultipleAsync(OfferFilter, _context);
                    }
                }
                var list = await GetFilteredQuery<Offer>(OfferFilter, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                foreach (var offer in list)
                {
                    if (offer.OfferDetails != null && offer.OfferDetails.Count() > 0)
                    {
                        context.OfferDetails.RemoveRange(offer.OfferDetails);
                    }
                }

                context.Offers.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_BRAND.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

    }
}

