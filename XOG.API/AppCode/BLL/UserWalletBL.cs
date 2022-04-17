﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using XOG.AppCode.DAL;
using XOG.AppCode.Mappers;
using XOG.Util;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.AppCode.BLL
{
    public class UserWalletBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<UserWallet> GetFilteredWhereQuery(IQueryable<UserWallet> query, UserWalletFilterRequestVM filter)
        {
            if (filter != null)
            {
                //query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.ProductVariant.Product.ProductName.Contains(filter.Search) ||
                //                                                                      filter.Search.Contains(i.ProductVariant.Product.ProductName))
                //                                                   : query;

                query = !(string.IsNullOrWhiteSpace(filter.UserId)) ? query.Where(i => i.WalletOfUserId == filter.UserId)
                                                                 : query;

            }

            return query;
        }

        private IQueryable<UserWallet> GetFilteredQuery(UserWalletFilterRequestVM filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.UserWallets, filter);
        }

        internal object GetList<T>(XOGEntities context = null, UserWalletFilterRequestVM filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            if (context == null)
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
            var query = GetFilteredQuery(filter, context);

            return query.MapToUserWalletModelList<T>(model, listType);
        }

        internal object GetUserWalletByNameOrId<T>(XOGEntities context = null, long id = -1, string title = "", bool isAdmin = false)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetUserWalletByNameOrId<T>(_context, id, title, isAdmin);
                }
            }
            var UserWallet = new UserWallet();

            var query = context.UserWallets.Where(i => true);

            if (id != -1)
            {
                query = context.UserWallets.Where(i => i.Id == id);
            }

            //if (!string.IsNullOrWhiteSpace(title))
            //{
            //    query = context.UserWallets.Where(i => i..Equals(title.Replace("_", " ")));
            //}

            return query.FirstOrDefault().MapToUserWalletModel<T>();
        }

        internal async Task<DBStatus> EditAsync(UserWallet model, XOGEntities context = null)
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
                context.UserWallets.Attach(model);

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

        internal DBStatus Add(UserWallet model, XOGEntities context = null)
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
                context.UserWallets.Add(model);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_CART.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> AddAsync(UserWallet model, XOGEntities context = null)
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
                context.UserWallets.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_CART.ColonNextLine() + ex.ToString());

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
                if (context.UserWallets.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var UserWallet = context.UserWallets.Where(i => i.Id == Id).SingleOrDefault();

                context.UserWallets.Remove(UserWallet);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_CART.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(UserWalletFilterRequestVM UserWalletFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(UserWalletFilters, _context);
                    }
                }
                var list = await GetFilteredQuery(UserWalletFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.UserWallets.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_CART.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }


        internal DBStatus AttachList(List<UserWallet> list, XOGEntities context = null)
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
                    var entityState = model.Id > 0 ? EntityState.Modified : EntityState.Added;
                    context.UserWallets.Attach(model); context.Entry(model).State = entityState;
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

        internal long GetUserWalletsCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetUserWalletsCount(_context);
                }

            }
            return context.UserWallets.Count();
        }

    }
}