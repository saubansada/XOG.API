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

namespace XOG.AppCode.BLL
{
    public class OfferBannerBL
    {
        internal XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }
        private IQueryable<OfferBanner> GetFilteredWhereQuery(IQueryable<OfferBanner> query, IOfferFilter filter)
        {
            if (filter != null)
            {
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ?
                    query.Where(i => i.DisplayName.Equals(filter.Search) || filter.Search.Contains(i.DisplayName)) : query;

                //query = !(string.IsNullOrWhiteSpace(filter.CustomerName)) ?
                //        query.Where(i => i.FirstName.Contains(filter.CustomerName) ||
                //        filter.CustomerName.Contains(i.AspNetUser.FirstName)) : query;

                //query = (filter.ItemsCountStart >= 0 && filter.ItemsCountEnd >= 0) ? query.Where(i => i.OfferBannerDetails.Count() >= filter.ItemsCountStart && i.OfferBannerDetails.Count() <= filter.ItemsCountEnd) :
                //            query;

                //query = query.Where(i => i.Offs > filter.OfferBannerDateStart && i.OfferBannerDate <= filter.OfferBannerDateEnd);
            }

            return query;
        }

        private IQueryable<OfferBanner> GetFilteredQuery<T>(IOfferFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.OfferBanners, filter);
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

            return query.MapToOfferBannerModelList<T>(model, listType);
        }

        internal async Task<Dictionary<string, object>> AddOfferBanner(OfferBanner model)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await AddOfferBanner(_context, model);
            }
        }

        internal async Task<Dictionary<string, object>> AddOfferBanner(XOGEntities context, OfferBanner model)
        {
            var res = new Dictionary<string, object>();

            try
            {
                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    context.OfferBanners.Add(model);

                    ts.Complete();
                }

                await context.SaveChangesAsync();

                res.Add("DBStatus", DBStatus.Success);
                res.Add("OfferBannerId", "" + model.Id);
                res.Add("Message", "Offer Banner saved successfully!");
                res.Add("DetailedError", "");

                return res;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                res.Add("DbStatus", DBStatus.Error);
                res.Add("OfferBannerId", "");
                res.Add("Message", "Error occurred while saving offer!");
                res.Add("DetailedError", ex.Message);
                return res;
            }
        }


        internal async Task<Dictionary<string, object>> UpdateAsync(OfferBanner offerBanner)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await UpdateAsync(_context, offerBanner);
            }
        }

        internal async Task<Dictionary<string, object>> UpdateAsync(XOGEntities context, OfferBanner offerBanner)
        {
            var res = new Dictionary<string, object>();

            try
            {  
                context.OfferBanners.Attach(offerBanner);

                context.Entry(offerBanner).State = EntityState.Modified;

                await context.SaveChangesAsync();

                res.Add("DBStatus", DBStatus.Success);
                res.Add("OfferBannerId", "" + offerBanner.Id);
                res.Add("Message", "Offer Banner " + Enum.GetName(typeof(OfferStatus), (offerBanner.Enabled ?? false) ? OfferStatus.Active : OfferStatus.InActive).ToLower() + " successfully!");
                res.Add("DetailedError", "");

                return res;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                res.Add("DbStatus", DBStatus.Error);
                res.Add("OfferBannerId", offerBanner.Id);
                res.Add("Message", "Error occurred while updating offer!");
                res.Add("DetailedError", ex.Message);
                return res;
            }
        }

        internal async Task<object> GetOfferBanner<T>(long id, string userId = "")
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception("Error Occurred");
                }
                return await GetOfferBanner<T>(_context, id, userId);
            }
        }

        internal async Task<object> GetOfferBanner<T>(XOGEntities context, long id = -1, string userId = "")
        {
            try
            {
                var user = context.AspNetUsers.Find(userId);

                var data = context.OfferBanners.Where(i => i.Id == id);

                if (data == null || user == null)
                {
                    return null;
                }

                return await Task.FromResult(data.MapToOfferBannerModel<T>());

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Error Occurred while Loading Offer Banner" + ex.Message);

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
                if (context.OfferBanners.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var offerBanner = context.OfferBanners.Where(i => i.Id == Id).SingleOrDefault();
                 
                context.OfferBanners.Remove(offerBanner);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_OFFER_BANNER.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(IOfferFilter OfferBannerFilter, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(OfferBannerFilter, _context);
                    }
                }
                var list = await GetFilteredQuery<OfferBanner>(OfferBannerFilter, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.OfferBanners.RemoveRange(list);

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

