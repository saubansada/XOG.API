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
    public class SubCategoryBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<SubCategory> GetFilteredWhereQuery(IQueryable<SubCategory> query, ISubCategoryFilter filter)
        { 
            if(filter != null)
            { 
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.SubCategoryName.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.SubCategoryName))
                                                                   : query;

                query = filter.CategoryId != -1  ? query.Where(i => i.CategoryId == filter.CategoryId) : query;


                query = !(string.IsNullOrWhiteSpace(filter.Ids)) ? query.Where(i => filter.Ids.StartsWith(i.Id + ",") || 
                                                                                    filter.Ids.Contains("," + i.Id + ",")
                                                                                  ) : query;
            }

            return query;
        }

        private IQueryable<SubCategory> GetFilteredQuery(ISubCategoryFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.SubCategories, filter);
        }

        internal object GetList<T>(ISubCategoryFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, ISubCategoryFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery(filter, context);

            return query.MapToSubCategoryModelList<T>(model, listType);
        }

        internal T GetSubCategoryByNameOrId<T>(long id = -1, string title = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetSubCategoryByNameOrId<T>(_context, id, title, isAdmin);
            }
        }

        internal T GetSubCategoryByNameOrId<T>(XOGEntities context, long id = -1, string title = "", bool isAdmin = false)
        {
            var SubCategory = new SubCategory();

            var query = context.SubCategories.Where(i => true);

            if (id != -1)
            {
                query = context.SubCategories.Where(i => i.Id == id);
            }

            if (!string.IsNullOrWhiteSpace(title))
            {
                query = context.SubCategories.Where(i => i.SubCategoryName.Equals(title.Replace("_", " ")));
            }

            return query.FirstOrDefault().MapToSubCategoryModel<T>();
        }

        internal async Task<DBStatus> EditAsync(SubCategory model, XOGEntities context = null)
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
                context.SubCategories.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_SUB_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }
         
        internal DBStatus Add(SubCategory model, XOGEntities context = null)
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
                context.SubCategories.Add(model);

                context.SaveChanges(); 

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_SUB_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }
           
        internal async Task<DBStatus> AddAsync(SubCategory model, XOGEntities context = null)
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
                context.SubCategories.Add(model);

                await context.SaveChangesAsync();
                  
                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_SUB_CATEGORY.ColonNextLine() + ex.ToString());

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
                if (context.SubCategories.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var SubCategory = context.SubCategories.Where(i => i.Id == Id).SingleOrDefault();

                context.SubCategories.Remove(SubCategory);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_SUB_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }
          
        internal async Task<DBStatus> DeleteMultipleAsync(ISubCategoryFilter subCategoryFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(subCategoryFilters, _context);
                    }
                }
                var list = await GetFilteredQuery(subCategoryFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.SubCategories.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_SUB_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal long GetSubCategoriesCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetSubCategoriesCount(_context);
                }

            }
            return context.SubCategories.Count();
        }

    }
}