using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Transactions;
using XOG.AppCode.DAL;
using XOG.Util;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOGModels.JsonModels;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Mappers;
using System.Threading.Tasks;

namespace XOG.AppCode.BLL
{
    public class OrderBL
    {
        internal XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }
        private IQueryable<Order> GetFilteredWhereQuery(IQueryable<Order> query, OrderFilter filter)
        {
            if (filter != null)
            {
                string[] userIds = filter.userIds.Trim().Equals("") != true ? filter.userIds.Split(',') : new string[0];

                query = userIds.Length == 0 ? query : query.Where(i => userIds.Contains(i.AspNetUser.Id));

                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.OrderDetails
                    .Where(o =>
                        o.ProductVariant.Product.ProductName.Equals(filter.Search) ||
                        filter.Search.Contains(o.ProductVariant.Product.ProductName)).Count() > 0) : query;

                query = !(string.IsNullOrWhiteSpace(filter.CustomerName)) ?
                        query.Where(i => i.AspNetUser.FirstName.Contains(filter.CustomerName) ||
                        filter.CustomerName.Contains(i.AspNetUser.FirstName)) : query;

                query = (filter.ItemsCountStart >= 0 && filter.ItemsCountEnd >= 0) ? query.Where(i => i.OrderDetails.Count() >= filter.ItemsCountStart && i.OrderDetails.Count() <= filter.ItemsCountEnd) :
                            query;

                query = query.Where(i => i.OrderDate > filter.OrderDateStart && i.OrderDate <= filter.OrderDateEnd);

                query = filter.OrderState != OrderStatus.All ? query.Where(i => i.OrderState == (byte)filter.OrderState) : query;

                query = query.Where(i => i.OrderState == (byte)OrderStatus.Placed || i.OrderState == (byte)OrderStatus.Notified);

                query = query.OrderByDescending(i => "OrderDate");
            }

            return query;
        }

        private IQueryable<Order> GetFilteredQuery<T>(OrderFilter filter, XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetFilteredQuery<T>(filter, _context);
                }
            }
            return GetFilteredWhereQuery(context.Orders, filter);
        }

        internal object GetList<T>(OrderFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, OrderFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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
            var query = GetFilteredQuery<T>(filter, context);

            return query.MapToOrderModelList<T>(model, listType);
        }

        internal async Task<DBStatus> PlaceOrder(Order model)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await PlaceOrder(_context, model);
            }
        }

        internal async Task<DBStatus> PlaceOrder(XOGEntities context, Order model)
        {
            try
            { 
                var transaction = new DAL.Transaction()
                {
                    PaymentDateTime = model.OrderDate,
                    BilledByUserId = model.OrderedByUserId,
                    TotalAmount = model.TotalAmount,
                    Canceled = false,
                    Order = model
                };

                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    context.Transactions.Add(transaction);

                    ts.Complete();
                }

                await context.SaveChangesAsync();

                return DBStatus.Success;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                return DBStatus.Error;
            }
        }

        internal object GetOrder<T>(XOGEntities context = null, long id = -1, string userId = "", bool isCurrent = false)
        {
            if (id < 0 && isCurrent == false)
            {
                return null;
            }

            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception("Error Occurred");
                    }
                    return GetOrder<T>(_context, id, userId, isCurrent);
                }
            }

            try
            {
                OrderStatus[] toExcludeOrderStates = { OrderStatus.All, OrderStatus.Dilevered, OrderStatus.Rejected };

                var data = isCurrent && id < 0 ? context.Orders.Where(i => i.AspNetUser.Id == userId && !toExcludeOrderStates.Contains((OrderStatus)i.OrderState)).OrderByDescending(i => i.OrderDate).FirstOrDefault()
                                    : context.Orders.Where(i => i.Id == id).FirstOrDefault();


                if (data != null && isCurrent && data.AspNetUser.Id != userId && data.AspNetUser.AspNetRoles.Count(i => i.Name == "Admin" || i.Name == "Developer" || i.Name == "SuperAdmin") <= 0)
                {

                    throw new Exception("The User trying to Access to Record is Invalid");
                }

                return data.MapToOrderModel<T>();

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Error Occurred while Loading Order" + ex.Message);

                return null;
            }
        }


    }
}

