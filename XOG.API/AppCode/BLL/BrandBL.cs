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
    public class BrandBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<Brand> GetFilteredWhereQuery(IQueryable<Brand> query, IBrandFilter filter)
        {
            if (filter != null)
            {
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.BrandName.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.BrandName))
                                                                   : query;

                query = !(string.IsNullOrWhiteSpace(filter.Ids)) ? query.Where(i => filter.Ids.StartsWith(i.Id + ",") ||
                                                                                    filter.Ids.Contains("," + i.Id + ",")
                                                                                  ) : query;
            }

            return query;
        }

        private IQueryable<Brand> GetFilteredQuery(IBrandFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.Brands, filter);
        }

        internal object GetList<T>(IBrandFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, IBrandFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery(filter, context);

            return query.MapToBrandModelListing<T>(model, listType);
        }

        internal object GetBrandByNameOrId<T>(long id = -1, string title = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetBrandByNameOrId<T>(_context, id, title, isAdmin);
            }
        }

        internal object GetBrandByNameOrId<T>(XOGEntities context, long id = -1, string title = "", bool isAdmin = false)
        {
            var Brand = new Brand();

            var query = context.Brands.Where(i => true);

            if (id != -1)
            {
                query = context.Brands.Where(i => i.Id == id);
            }

            if (!string.IsNullOrWhiteSpace(title))
            {
                query = context.Brands.Where(i => i.BrandName.Equals(title.Replace("_", " ")));
            }

            return query.FirstOrDefault().MapToBrandModel<T>();
        }

        internal async Task<DBStatus> EditAsync(Brand model, XOGEntities context = null)
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
                context.Brands.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_BRAND.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal DBStatus Add(Brand model, XOGEntities context = null)
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
                context.Brands.Add(model);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_BRAND.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> AddAsync(Brand model, XOGEntities context = null)
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
                context.Brands.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_BRAND.ColonNextLine() + ex.ToString());

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
                if (context.Brands.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var Brand = context.Brands.Where(i => i.Id == Id).SingleOrDefault();

                context.Brands.Remove(Brand);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_BRAND.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(IBrandFilter BrandFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(BrandFilters, _context);
                    }
                }
                var list = await GetFilteredQuery(BrandFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.Brands.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_BRAND.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal long GetBrandsCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetBrandsCount(_context);
                }

            }
            return context.Brands.Count();
        }

    }
}