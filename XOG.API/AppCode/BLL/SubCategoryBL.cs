using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using XOG.AppCode.DAL;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Transformers;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.Util;

namespace XOG.AppCode.BLL
{
    public static class SubCategoryBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private static IQueryable<SubCategory> GetFilteredWhereQuery(IQueryable<SubCategory> query, SubCategoryFilter filter)
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

        private static IQueryable<SubCategory> GetFilteredQuery(SubCategoryFilter filter, XOGEntities context = null)
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

        internal static object GetTList(XOGEntities context = null, SubCategoryFilter filter = null, ModelType type = ModelType.Default, ListingType listType = ListingType.GridList, object model = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetTList(_context, filter, type, listType, model);
                }
            }
            var query = GetFilteredQuery(filter, context);

            return query.TransformToSubCategoryModelListing(model, type, listType);
        }
        internal static object GetSubCategoryByNameOrId(XOGEntities context = null, ModelType type = ModelType.Default, long id = -1, string title = "", bool isAdmin = false)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetSubCategoryByNameOrId(_context, type, id, title, isAdmin);
                }
            }
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

            return query.FirstOrDefault().TransformToSubCategoryModel(type);
        }

        internal static async Task<DBStatus> EditAsync(SubCategory model, XOGEntities context = null)
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
         
        internal static DBStatus Add(SubCategory model, XOGEntities context = null)
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
           
        internal static async Task<DBStatus> AddAsync(SubCategory model, XOGEntities context = null)
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
         
        internal static async Task<DBStatus> DeleteAsync(long Id, XOGEntities context = null)
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
          
        internal static async Task<DBStatus> DeleteMultipleAsync(SubCategoryFilter subCategoryFilters, XOGEntities context = null)
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

        internal static long GetSubCategoriesCount(XOGEntities context = null)
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