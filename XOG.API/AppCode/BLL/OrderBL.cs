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
using System.Data.Entity;

namespace XOG.AppCode.BLL
{
    public class OrderBL
    {
        internal XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }
        private IQueryable<OrderVW> GetFilteredWhereQuery(IQueryable<OrderVW> query, IOrderFilter filter)
        {
            if (filter != null)
            {
                string[] userIds = filter.userIds.Trim().Equals("") != true ? filter.userIds.Split(',') : new string[0];

                query = userIds.Length == 0 ? query : query.Where(i => filter.IsAdminRequest || userIds.Contains(i.UserId));

                query = !(string.IsNullOrWhiteSpace(filter.Search)) ?
                    query.Where(i => i.ProductName.Equals(filter.Search) || filter.Search.Contains(i.ProductName)) : query;

                //query = !(string.IsNullOrWhiteSpace(filter.CustomerName)) ?
                //        query.Where(i => i.FirstName.Contains(filter.CustomerName) ||
                //        filter.CustomerName.Contains(i.AspNetUser.FirstName)) : query;

                //query = (filter.ItemsCountStart >= 0 && filter.ItemsCountEnd >= 0) ? query.Where(i => i.OrderDetails.Count() >= filter.ItemsCountStart && i.OrderDetails.Count() <= filter.ItemsCountEnd) :
                //            query;

                query = query.Where(i => i.OrderDate > filter.OrderDateStart && i.OrderDate <= filter.OrderDateEnd);

                if (!filter.IsReturnedOrder && filter.OrderState != OrderStatus.All)
                {
                    query = query.Where(i => i.OrderState == (byte)OrderStatus.Placed || i.OrderState == (byte)OrderStatus.Confirmed);
                }

                if (filter.IsReturnedOrder)
                {
                    if (filter.OrderState != (byte)OrderStatus.All)
                    {
                        query = query.Where(i => i.ReturnOrderStatus == (byte)filter.OrderState);
                    }
                    query = query.Where(i => i.ReturnDetailId > -1);
                }

                query = query.OrderByDescending(i => "OrderDate");
            }

            return query;
        }

        private IQueryable<OrderVW> GetFilteredQuery<T>(IOrderFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.OrderVWs, filter);
        }

        internal object GetList<T>(IOrderFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
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

        internal object GetList<T>(XOGEntities context, IOrderFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            var query = GetFilteredQuery<T>(filter, context);

            return filter.IsReturnedOrder ? query.MapToOrderRetunsModelList<T>(model, listType) :
                query.MapToOrderModelList<T>(model, listType);
        }

        internal async Task<Dictionary<string, object>> PlaceOrder(Order model, UserWallet walletInfo = null)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await PlaceOrder(_context, model, walletInfo);
            }
        }
         
        internal async Task<Dictionary<string, object>> PlaceOrder(XOGEntities context, Order model, UserWallet walletInfo = null)
        {
            var res = new Dictionary<string, object>();

            try
            {
                var transaction = new DAL.Transaction()
                {
                    PaymentDateTime = model.OrderDate,
                    BilledByUserId = model.OrderedByUserId,
                    TotalAmount = model.TotalAmount,
                    UserWallet = walletInfo,
                    Order = model
                };

                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    context.Transactions.Add(transaction);

                    ts.Complete();
                }

                await context.SaveChangesAsync();

                res.Add("DBStatus", DBStatus.Success);
                res.Add("OrderId", "" + model.Id);
                res.Add("Amount", model.TotalAmount);
                res.Add("Message", "Order placed successfully!");
                res.Add("DetailedError", "");

                return res;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                res.Add("DbStatus", DBStatus.Error);
                res.Add("OrderId", "");
                res.Add("Amount", model.TotalAmount);
                res.Add("Message", "Error occurred while placing order!");
                res.Add("DetailedError", ex.Message);
                return res;
            }
        }

        internal async Task<Dictionary<string, object>> ReturnOrder(ReturnOrder model)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await ReturnOrder(_context, model);
            }
        }

        internal async Task<Dictionary<string, object>> UpdateOrderStatus(long orderId, OrderStatus orderState)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await UpdateOrderStatus(_context, orderId, orderState);
            }
        }

        internal async Task<Dictionary<string, object>> UpdateOrderStatus(XOGEntities context, long orderId, OrderStatus orderState)
        {
            var res = new Dictionary<string, object>();

            try
            {
                var order = await context.Orders.FindAsync(orderId);

                if (order == null)
                {
                    throw new Exception("No Order Found!");
                }

                order.OrderState = (byte)orderState;

                context.Orders.Attach(order);

                context.Entry(order).State = EntityState.Modified;

                await context.SaveChangesAsync();

                res.Add("DBStatus", DBStatus.Success);
                res.Add("OrderId", "" + orderId);
                res.Add("Message", "Order " + Enum.GetName(typeof(OrderStatus), order.OrderState).ToLower() + " successfully!");
                res.Add("DetailedError", "");

                return res;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                res.Add("DbStatus", DBStatus.Error);
                res.Add("OrderId", orderId);
                res.Add("Message", "Error occurred while confirming order!");
                res.Add("DetailedError", ex.Message);
                return res;
            }
        }

        internal async Task<Dictionary<string, object>> ReturnOrder(XOGEntities context, ReturnOrder model)
        {

            var res = new Dictionary<string, object>();

            try
            {
                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    context.ReturnOrders.Add(model);

                    ts.Complete();
                }

                await context.SaveChangesAsync();

                res.Add("DBStatus", DBStatus.Success);
                res.Add("Message", "Order returned initiated!");

                return res;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                res.Add("DbStatus", DBStatus.Error);
                res.Add("OrderId", "");
                res.Add("Message", "Error occurred while initiating return order!");
                res.Add("DetailedError", ex.Message);
                return res;
            }
        }

        internal async Task<Dictionary<string, object>> UpdateOrderReturnStatus(long returnOrderId, OrderStatus orderState)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return await UpdateOrderReturnStatus(_context, returnOrderId, orderState);
            }
        }

        internal async Task<Dictionary<string, object>> UpdateOrderReturnStatus(XOGEntities context, long returnOrderId, OrderStatus orderState)
        {
            var res = new Dictionary<string, object>();

            try
            {
                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var order = await context.ReturnOrders.FindAsync(returnOrderId);

                    if (order == null)
                    {
                        throw new Exception("No Order Found!");
                    }

                    var userWallet = new UserWallet();

                    userWallet.WalletOfUserId = order.Order.OrderedByUserId;

                    userWallet.Amount = context.OrderVWs.Where(i => i.ReturnId == returnOrderId).Sum(i => i.ReturnTotalSum);

                    userWallet.TimeStamp = DateTime.Now;

                    context.UserWallets.Add(userWallet);

                    await context.SaveChangesAsync();

                    DAL.Transaction transaction = new DAL.Transaction();

                    transaction.OrderId = order.OrderId;

                    transaction.BilledByUserId = userWallet.WalletOfUserId;

                    transaction.ReturnId = order.Id;

                    transaction.WalletId = userWallet.Id;

                    transaction.PaymentDateTime = DateTime.Now;

                    transaction.TransactionFor = (int)TransactionFor.Wallet;

                    transaction.TransactionType = (int)TransactionType.Credit;

                    context.Transactions.Add(transaction);

                    await context.SaveChangesAsync();

                    order.ReturnOrderState = (byte)orderState;

                    context.ReturnOrders.Attach(order);

                    context.Entry(order).State = EntityState.Modified;

                    await context.SaveChangesAsync();
                     
                    ts.Complete();
                }

                res.Add("DBStatus", DBStatus.Success);
                res.Add("OrderReturnId", "" + returnOrderId);
                res.Add("Message", "Order return confirmed successfully!");
                res.Add("DetailedError", "");
                return res;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                res.Add("DbStatus", DBStatus.Error);
                res.Add("OrderId", returnOrderId);
                res.Add("Message", "Error occurred while confirming order!");
                res.Add("DetailedError", ex.Message);
                return res;
            }
        }

        internal async Task<object> GetOrder<T>(long id, bool isReturnedOrder = false, string userId = "")
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception("Error Occurred");
                }
                return await GetOrder<T>(_context, isReturnedOrder, id, userId);
            }
        }

        internal async Task<object> GetOrder<T>(XOGEntities context, bool isReturnedOrder = false, long id = -1, string userId = "")
        {
            try
            {
                var user = context.AspNetUsers.Find(userId);

                var data = context.OrderVWs.Where(i => (isReturnedOrder && i.ReturnId == id) || (!isReturnedOrder && i.OrderId == id));

                if (data == null || user == null)
                {
                    return null;
                }
                else if (data.Count(j => j.UserId != userId) > 0 &&
                                user.AspNetRoles.Count(i => i.Name == "Admin" ||
                                i.Name == "Developer" || i.Name == "SuperAdmin") == 0)
                {
                    return null;
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

