using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XOG.AppCode.DAL;
using XOG.AppCode.Transformers;
using XOG.Util;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.AppCode.BLL
{
    public static class CartBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private static IQueryable<Cart> GetFilteredWhereQuery(IQueryable<Cart> query, CartFilterRequestVM filter)
        {
            if (filter != null)
            {
                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.Product.ProductName.Contains(filter.Search) ||
                                                                                      filter.Search.Contains(i.Product.ProductName))
                                                                   : query;

                query = !(string.IsNullOrWhiteSpace(filter.UserId)) ? query.Where(i => i.AddedByUserId == filter.UserId)
                                                                 : query;

            }

            return query;
        }

        private static IQueryable<Cart> GetFilteredQuery(CartFilterRequestVM filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.Carts, filter);
        }

        internal static object GetTList(XOGEntities context = null, CartFilterRequestVM filter = null, ModelType type = ModelType.Default, ListingType listType = ListingType.GridList, object model = null)
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

            return query.TransformToCartModelListing(model, type, listType);
        }

        internal static object GetCartByNameOrId(XOGEntities context = null, ModelType type = ModelType.Default, long id = -1, string title = "", bool isAdmin = false)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetCartByNameOrId(_context, type, id, title, isAdmin);
                }
            }
            var Cart = new Cart();

            var query = context.Carts.Where(i => true);

            if (id != -1)
            {
                query = context.Carts.Where(i => i.Id == id);
            }

            if (!string.IsNullOrWhiteSpace(title))
            {
                query = context.Carts.Where(i => i.Product.ProductName.Equals(title.Replace("_", " ")));
            }

            return query.FirstOrDefault().TransformToCartModel(type);
        }

        internal static async Task<DBStatus> EditAsync(Cart model, XOGEntities context = null)
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
                context.Carts.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_CART.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static DBStatus Add(Cart model, XOGEntities context = null)
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
                context.Carts.Add(model);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_CART.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static async Task<DBStatus> AddAsync(Cart model, XOGEntities context = null)
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
                context.Carts.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_CART.ColonNextLine() + ex.ToString());

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
                if (context.Carts.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var Cart = context.Carts.Where(i => i.Id == Id).SingleOrDefault();

                context.Carts.Remove(Cart);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_CART.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static async Task<DBStatus> DeleteMultipleAsync(CartFilterRequestVM CartFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(CartFilters, _context);
                    }
                }
                var list = await GetFilteredQuery(CartFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.Carts.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_CART.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }


        internal static DBStatus AttachList(List<Cart> list, XOGEntities context = null)
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
                        return AttachList(list, _context);
                    }
                }

                list.ForEach(model =>
                {
                    var entityState =  model.Id > 0 ? EntityState.Modified : EntityState.Added;
                    context.Carts.Attach(model); context.Entry(model).State = entityState;
                });

                context.SaveChanges();

                return DBStatus.Success;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_CART.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static long GetCartsCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetCartsCount(_context);
                }

            }
            return context.Carts.Count();
        }

    }
}