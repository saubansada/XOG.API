using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XOG.AppCode.DAL;
using XOG.Util;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Mappers;

namespace XOG.AppCode.BLL
{
    public class RedeemRequestBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<RedeemRequest> GetFilteredWhereQuery(IQueryable<RedeemRequest> query, IRedeemRequestFilter filter)
        {
            if (filter != null)
            {
                //query = (string.IsNullOrWhiteSpace(filter.Search)) ? query : query.Where(i => i.RedeemRequestLine1.Contains(filter.Search) ||
                //                                                                      filter.Search.Contains(i.RedeemRequestLine1) || i.RedeemRequestLine2.Contains(filter.Search) ||
                //                                                                      filter.Search.Contains(i.RedeemRequestLine2));

                query = string.IsNullOrWhiteSpace(filter.UserId) ? query : query.Where(i => i.BankAccount.AspNetUser.Id == filter.UserId);

                query = (string.IsNullOrWhiteSpace(filter.Ids)) ? query : query.Where(i => filter.Ids.StartsWith(i.Id + ",") ||
                                                                                    filter.Ids.Contains("," + i.Id + ",")
                                                                                  );
            }

            return query;
        }

        private IQueryable<RedeemRequest> GetFilteredQuery(IRedeemRequestFilter filter, XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetFilteredQuery(filter, _context);
                }
            }
            return GetFilteredWhereQuery(context.RedeemRequests, filter);
        }

        internal object GetList<T>(IRedeemRequestFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, IRedeemRequestFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery(filter, context);

            return query.MapToRedeemRequestModelListing<T>(model, listType);
        }

        internal object GetRedeemRequestByNameOrId<T>(long id = -1, string title = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetRedeemRequestByNameOrId<T>(_context, id, title, isAdmin);
            }
        }

        internal object GetRedeemRequestByNameOrId<T>(XOGEntities context, long id = -1, string title = "", bool isAdmin = false)
        {
            var RedeemRequest = new RedeemRequest();

            var query = context.RedeemRequests.Where(i => true);

            if (id != -1)
            {
                query = context.RedeemRequests.Where(i => i.Id == id);
            }

            return query.FirstOrDefault().MapToRedeemRequestModel<T>();
        }

        internal async Task<DBStatus> EditAsync(RedeemRequest model, XOGEntities context = null)
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
                        return await EditAsync(model, _context);
                    }
                }
                context.RedeemRequests.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_REDEEM_REQUEST.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal DBStatus Add(RedeemRequest model, XOGEntities context = null)
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
                        return Add(model, _context);
                    }
                }
                context.RedeemRequests.Add(model);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_REDEEM_REQUEST.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> AddAsync(RedeemRequest model, XOGEntities context = null)
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
                        return await AddAsync(model, _context);
                    }
                }
                context.RedeemRequests.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_REDEEM_REQUEST.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
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
                if (context.RedeemRequests.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var RedeemRequest = context.RedeemRequests.Where(i => i.Id == Id).SingleOrDefault();

                context.RedeemRequests.Remove(RedeemRequest);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_REDEEM_REQUEST.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(IRedeemRequestFilter RedeemRequestFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(RedeemRequestFilters, _context);
                    }
                }
                var list = await GetFilteredQuery(RedeemRequestFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.RedeemRequests.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_REDEEM_REQUEST.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal long GetRedeemRequestsCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetRedeemRequestsCount(_context);
                }

            }
            return context.RedeemRequests.Count();
        }

    }
}