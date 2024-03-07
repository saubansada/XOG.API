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
    public class BankAccountBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private IQueryable<BankAccount> GetFilteredWhereQuery(IQueryable<BankAccount> query, IBankAccountFilter filter)
        {
            if (filter != null)
            {
                //query = (string.IsNullOrWhiteSpace(filter.Search)) ? query : query.Where(i => i.BankAccountLine1.Contains(filter.Search) ||
                //                                                                      filter.Search.Contains(i.BankAccountLine1) || i.BankAccountLine2.Contains(filter.Search) ||
                //                                                                      filter.Search.Contains(i.BankAccountLine2));

                query = string.IsNullOrWhiteSpace(filter.UserId) ? query : query.Where(i => i.AspNetUser.Id == filter.UserId);

                query = (string.IsNullOrWhiteSpace(filter.Ids)) ? query : query.Where(i => filter.Ids.StartsWith(i.Id + ",") ||
                                                                                    filter.Ids.Contains("," + i.Id + ",")
                                                                                  );
            }

            return query;
        }

        private IQueryable<BankAccount> GetFilteredQuery(IBankAccountFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.BankAccounts, filter);
        }

        internal object GetList<T>(IBankAccountFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, IBankAccountFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery(filter, context);

            return query.MapToBankAccountModelListing<T>(model, listType);
        }

        internal object GetBankAccountByNameOrId<T>(long id = 0, string title = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetBankAccountByNameOrId<T>(_context, id, title, isAdmin);
            }
        }

        internal object GetBankAccountByNameOrId<T>(XOGEntities context, long id = 0, string title = "", bool isAdmin = false)
        {
            var bankAccount = new BankAccount();

            var query = context.BankAccounts.Where(i => true);

            if (id != 0)
            {
                query = context.BankAccounts.Where(i => i.Id == id);
            }

            bankAccount = query.FirstOrDefault();
            
            if(bankAccount == null)
            {
                return null;
            }
            return bankAccount.MapToBankAccountModel<T>();
        }

        internal async Task<DBStatus> EditAsync(BankAccount model, XOGEntities context = null)
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
                context.BankAccounts.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_BANK_ACCOUNT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal DBStatus Add(BankAccount model, XOGEntities context = null)
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
                context.BankAccounts.Add(model);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_BANK_ACCOUNT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> AddAsync(BankAccount model, XOGEntities context = null)
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
                context.BankAccounts.Add(model);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_BANK_ACCOUNT.ColonNextLine() + ex.ToString());

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
                if (context.BankAccounts.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var BankAccount = context.BankAccounts.Where(i => i.Id == Id).SingleOrDefault();

                context.BankAccounts.Remove(BankAccount);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_BANK_ACCOUNT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(IBankAccountFilter BankAccountFilters, XOGEntities context = null)
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
                        return await DeleteMultipleAsync(BankAccountFilters, _context);
                    }
                }
                var list = await GetFilteredQuery(BankAccountFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                context.BankAccounts.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_BANK_ACCOUNT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal long GetBankAccountsCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetBankAccountsCount(_context);
                }

            }
            return context.BankAccounts.Count();
        }

    }
}