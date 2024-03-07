using System;
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

        private IQueryable<UserWalletListVW> GetFilteredWhereQuery(IQueryable<UserWalletListVW> query, UserWalletFilterRequestVM filter)
        {
            if (filter != null)
            {
                //query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.ProductVariant.Product.ProductName.Contains(filter.Search) ||
                //                                                                      filter.Search.Contains(i.ProductVariant.Product.ProductName))
                //                                                   : query;

                query = !(string.IsNullOrWhiteSpace(filter.UserId)) ? query.Where(i => i.UserId == filter.UserId)
                                                                 : query;

            }

            return query;
        }

        private IQueryable<UserWalletListVW> GetDetailedListFilteredQuery(UserWalletFilterRequestVM filter, XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetDetailedListFilteredQuery(filter, _context);
                }
            }
            return GetFilteredWhereQuery(context.UserWalletListVWs, filter);
        }

        internal object GetDetailedList<T>(XOGEntities context = null, UserWalletFilterRequestVM filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetDetailedList<T>(_context, filter, listType, model);
                }
            }
            var query = GetDetailedListFilteredQuery(filter, context);

            return query.MapToUserWalletModelList<T>(model, listType);
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

        internal object GetUserWalletByUserNameOrId<T>(XOGEntities context = null, string userId = "", string title = "", bool isAdmin = false)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetUserWalletByUserNameOrId<T>(_context, userId, title, isAdmin);
                }
            }
            var UserWallet = new UserWallet();

            var query = context.UsersWalletVWs.Where(i => true);

            if (userId != "")
            {
                query = context.UsersWalletVWs.Where(i => i.WalletOfUserId == userId);
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

        internal DBStatus Add(UserWallet model, string userId = null, XOGEntities context = null)
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
                        return Add(model, userId, _context);
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

        internal async Task<DBStatus> AddAsync(UserWallet model, string userId = null, XOGEntities context = null)
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
                        return await AddAsync(model, userId, _context);
                    }
                }

                var entity = new Transaction()
                {
                    BilledByUserId = userId,
                    OrderId = null,
                    PaymentDateTime = DateTime.Now,
                    ReturnOrder = null,
                    TotalAmount = model.Amount ?? 0,
                    TransactionType = (model.Amount ?? 0) < 0 ? (int)TransactionType.Debit : (int)TransactionType.Credit,
                    TransactionFor = (int)TransactionFor.System,
                    UserWallet = model
                };

                context.Transactions.Add(entity);
                  

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