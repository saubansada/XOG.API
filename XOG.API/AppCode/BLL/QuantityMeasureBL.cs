using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XOG.AppCode.DAL;
using XOG.AppCode.Mappers;
using XOG.AppCode.Models.FilterModels;
using XOG.Util;

namespace XOG.AppCode.BLL
{
    public class QuantityMeasureBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<QuantityMeasure> GetFilteredWhereQuery(IQueryable<QuantityMeasure> query, QuantityMeasureFilter filter)
        {
            if (filter != null)
            {
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.QuantityMeasureName.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.QuantityMeasureName))
                                                                   : query;


                query = !(string.IsNullOrWhiteSpace(filter.Ids)) ? query.Where(i => filter.Ids.StartsWith(i.Id + ",") ||
                                                                                    filter.Ids.Contains("," + i.Id + ",")
                                                                                  ) : query;
            }

            return query;
        }

        private IQueryable<QuantityMeasure> GetFilteredQuery(QuantityMeasureFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.QuantityMeasures, filter);
        }

        internal object GetList<T>(QuantityMeasureFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, QuantityMeasureFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery(filter, context);

            return query.MapToQuantityMeasureModelList<T>(model, listType);
        }

        internal T GetQuantityMeasureByNameOrId<T>(long id = -1, string title = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetQuantityMeasureByNameOrId<T>(_context, id, title, isAdmin);
            }
        }

        internal T GetQuantityMeasureByNameOrId<T>(XOGEntities context, long id = -1, string title = "", bool isAdmin = false)
        {
            var QuantityMeasure = new QuantityMeasure();

            var query = context.QuantityMeasures.Where(i => true);

            if (id != -1)
            {
                query = context.QuantityMeasures.Where(i => i.Id == id);
            }

            if (!string.IsNullOrWhiteSpace(title))
            {
                query = context.QuantityMeasures.Where(i => i.QuantityMeasureName.Equals(title.Replace("_", " ")));
            }

            return query.FirstOrDefault().MapToQuantityMeasureModel<T>();
        }

        internal async Task<DBStatus> EditAsync(QuantityMeasure model, XOGEntities context = null)
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
                context.QuantityMeasures.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_QUANTITY_MEASURE.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal DBStatus Add(QuantityMeasure model, XOGEntities context = null)
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
                context.QuantityMeasures.Add(model);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_QUANTITY_MEASURE.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> AddAsync(QuantityMeasure model, XOGEntities context = null)
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
                context.QuantityMeasures.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_QUANTITY_MEASURE.ColonNextLine() + ex.ToString());

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
                if (context.QuantityMeasures.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var QuantityMeasure = context.QuantityMeasures.Where(i => i.Id == Id).SingleOrDefault();

                context.QuantityMeasures.Remove(QuantityMeasure);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_QUANTITY_MEASURE.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(QuantityMeasureFilter QuantityMeasureFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(QuantityMeasureFilters, _context);
                    }
                }
                var list = await GetFilteredQuery(QuantityMeasureFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.QuantityMeasures.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_QUANTITY_MEASURE.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal long GetQuantityMeasuresCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetQuantityMeasuresCount(_context);
                }

            }
            return context.QuantityMeasures.Count();
        }

    }
}