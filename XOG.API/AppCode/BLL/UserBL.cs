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
    public class UserBL
    {
        internal XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<AspNetUser> GetFilteredWhereQuery(IQueryable<AspNetUser> query, IUserFilter filter)
        {
            if (filter != null)
            {
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.UserName.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.UserName))
                                                                   : query; 

                query = !(string.IsNullOrWhiteSpace(filter.Ids)) ? query.Where(i => filter.Ids.StartsWith(i.Id + ",") ||
                                                                                    filter.Ids.Contains("," + i.Id + ",")
                                                                                  ) : query;
            }
            return query;
        }

        private IQueryable<AspNetUser> GetFilteredQuery(IUserFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.AspNetUsers, filter);
        }

        internal object GetList<T>(IUserFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, IUserFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery(filter, context);

            return query.MapToUserModelList<T>(model, listType);
        }

        internal T GetUserByNameOrId<T>(string id = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetUserByNameOrId<T>(_context, id, isAdmin);
            }
        }

        internal T GetUserByNameOrId<T>(XOGEntities context, string id = null, bool isAdmin = false)
        {
            var User = new AspNetUser();

            var query = context.AspNetUsers.Where(i => true);

            if (!string.IsNullOrWhiteSpace(id))
            {
                query = context.AspNetUsers.Where(i => i.Id == id);
            }

            var obj = query.ToList();
 
            return query.FirstOrDefault().MapToUserModel<T>();
        }

        internal async Task<DBStatus> EditAsync(AspNetUser model, XOGEntities context = null)
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
                context.AspNetUsers.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal DBStatus Add(AspNetUser model, XOGEntities context = null)
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
                context.AspNetUsers.Add(model);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> AddAsync(AspNetUser model, XOGEntities context = null)
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
                context.AspNetUsers.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteAsync(string Id, XOGEntities context = null)
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
                if (context.AspNetUsers.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var User = context.AspNetUsers.Where(i => i.Id == Id).SingleOrDefault();

                context.AspNetUsers.Remove(User);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(IUserFilter userFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(userFilters, _context);
                    }
                }
                var list = GetFilteredQuery(userFilters, context).ToList();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.AspNetUsers.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_CATEGORY.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal long GetAspNetUsersCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetAspNetUsersCount(_context);
                }

            }
            return context.AspNetUsers.Count();
        }
    }

}