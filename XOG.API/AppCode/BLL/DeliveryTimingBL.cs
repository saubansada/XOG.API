using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XOG.AppCode.DAL;
using XOG.AppCode.Mappers;
using XOG.Util;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.AppCode.Models.FilterModels;

namespace XOG.AppCode.BLL
{
    public class DeliveryTimingBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<WeekDayTiming> GetFilteredWhereQuery(IQueryable<WeekDayTiming> query, IDeliveryTimingsFilter filter)
        {
            if (filter != null)
            {
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.DayName.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.DayName))
                                                                   : query;

                query = !(string.IsNullOrWhiteSpace(filter.Ids)) ? query.Where(i => filter.Ids.StartsWith(i.WeekDayId + ",") ||
                                                                                    filter.Ids.Contains("" + i.WeekDayId)
                                                                                  ) : query;
            }
            return query;
        }

        private IQueryable<WeekDayTiming> GetFilteredQuery(IDeliveryTimingsFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.WeekDayTimings, filter);
        }

        internal object GetList<T>(IDeliveryTimingsFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, IDeliveryTimingsFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery(filter, context);

            return query.MapToDeliveryTimingModelList<T>(model, listType);
        }

        internal T GetDeliveryTimingByNameOrId<T>(long id = -1, string title = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetDeliveryTimingByNameOrId<T>(_context, id, title, isAdmin);
            }
        }

        internal T GetDeliveryTimingByNameOrId<T>(XOGEntities context, long id = -1, string title = "", bool isAdmin = false)
        {  
            var query = context.WeekDayTimings.Where(i => true);

            if (id != -1)
            {
                query = context.WeekDayTimings.Where(i => i.WeekDayId == id);
            }

            //if (!string.IsNullOrWhiteSpace(title))
            //{
            //    query = context.DeliveryTimings.Where(i => i.D.Equals(title.Replace("_", " ")));
            //}

            return query.FirstOrDefault().MapToDeliveryTimingModel<T>();
        }

        internal async Task<DBStatus> EditAsync(DeliveryTiming model, XOGEntities context = null)
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
                context.DeliveryTimings.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_DELIVERY_TIMINGS.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal DBStatus Add(DeliveryTiming model, XOGEntities context = null)
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
                context.DeliveryTimings.Add(model);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_DELIVERY_TIMINGS.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> AddAsync(DeliveryTiming model, XOGEntities context = null)
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
                context.DeliveryTimings.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_DELIVERY_TIMINGS.ColonNextLine() + ex.ToString());

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
                if (context.DeliveryTimings.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var DeliveryTiming = context.DeliveryTimings.Where(i => i.Id == Id).SingleOrDefault();

                context.DeliveryTimings.Remove(DeliveryTiming);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_DELIVERY_TIMINGS.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(IDeliveryTimingsFilter filter, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(filter, _context);
                    }
                }
                var list = context.DeliveryTimings.Where(i => filter.Ids.StartsWith(i.Id + ",") 
                                                        || filter.Ids.Contains("," + i.DayId + ","));
                                                                             

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.DeliveryTimings.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_DELIVERY_TIMINGS.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal long GetDeliveryTimingsCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetDeliveryTimingsCount(_context);
                }

            }
            return context.DeliveryTimings.Count();
        }
    }
}