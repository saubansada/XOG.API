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
    public class ProductGroupBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<ProductGroup> GetFilteredWhereQuery(IQueryable<ProductGroup> query, IProductGroupFilter filter)
        { 
            if(filter != null)
            { 
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.ProductGroupName.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.ProductGroupName))
                                                                   : query;

                query = filter.SubCategoryId != -1  ? query.Where(i => i.SubCategoryId == filter.SubCategoryId) : query;


                query = !(string.IsNullOrWhiteSpace(filter.Ids)) ? query.Where(i => filter.Ids.StartsWith(i.Id + ",") || 
                                                                                    filter.Ids.Contains("," + i.Id + ",")
                                                                                  ) : query;
            }

            return query;
        }

        private IQueryable<ProductGroup> GetFilteredQuery(IProductGroupFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.ProductGroups, filter);
        }

        internal object GetList<T>(IProductGroupFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, IProductGroupFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery(filter, context);

            return query.MapToProductGroupModelList<T>(model, listType);
        }

        internal T GetProductGroupByNameOrId<T>(long id = -1, string title = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetProductGroupByNameOrId<T>(_context, id, title, isAdmin);
            }
        }

        internal T GetProductGroupByNameOrId<T>(XOGEntities context, long id = -1, string title = "", bool isAdmin = false)
        {
            var ProductGroup = new ProductGroup();

            var query = context.ProductGroups.Where(i => true);

            if (id != -1)
            {
                query = context.ProductGroups.Where(i => i.Id == id);
            }

            if (!string.IsNullOrWhiteSpace(title))
            {
                query = context.ProductGroups.Where(i => i.ProductGroupName.Equals(title.Replace("_", " ")));
            }

            return query.FirstOrDefault().MapToProductGroupModel<T>();
        }

        internal async Task<DBStatus> EditAsync(ProductGroup model, XOGEntities context = null)
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
                context.ProductGroups.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_PRODUCT_GROUP.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }
         
        internal DBStatus Add(ProductGroup model, XOGEntities context = null)
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
                context.ProductGroups.Add(model);

                context.SaveChanges(); 

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_PRODUCT_GROUP.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }
           
        internal async Task<DBStatus> AddAsync(ProductGroup model, XOGEntities context = null)
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
                context.ProductGroups.Add(model);

                await context.SaveChangesAsync();
                  
                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_PRODUCT_GROUP.ColonNextLine() + ex.ToString());

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
                if (context.ProductGroups.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var ProductGroup = context.ProductGroups.Where(i => i.Id == Id).SingleOrDefault();

                context.ProductGroups.Remove(ProductGroup);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_PRODUCT_GROUP.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }
          
        internal async Task<DBStatus> DeleteMultipleAsync(IProductGroupFilter ProductGroupFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(ProductGroupFilters, _context);
                    }
                }
                var list = await GetFilteredQuery(ProductGroupFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.ProductGroups.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_PRODUCT_GROUP.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal long GetProductGroupsCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetProductGroupsCount(_context);
                }

            }
            return context.ProductGroups.Count();
        }

    }
}