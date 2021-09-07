using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Transactions;
using XOG.AppCode.DAL;
using XOG.AppCode.Transformers;
using XOG.Util;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOGModels.JsonModels;
using XOG.AppCode.Models.FilterModels;

namespace XOG.AppCode.BLL
{
    public class OrderBL
    {

        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private static IQueryable<Order> GetFilteredWhereQuery(IQueryable<Order> query, OrderFilter filter)
        {
            if (filter != null)
            {
                string[] userIds = filter.userIds.Trim().Equals("") != true ? filter.userIds.Split(',') : new string[0];
                  
                query = userIds.Length == 0 ? query : query.Where(i => userIds.Contains(i.AspNetUser.Id));

                query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.OrderDetails
                    .Where(o =>
                        o.Product.ProductName.Equals(filter.Search) ||
                        filter.Search.Contains(o.Product.ProductName)).Count() > 0) : query;

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

        private static IQueryable<Order> GetFilteredQuery(OrderFilter filter, XOGEntities context = null)
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
            return GetFilteredWhereQuery(context.Orders, filter);
        }


        internal static object GetTList(XOGEntities context = null, OrderFilter filter = null, ModelType type = ModelType.Default, ListingType listType = ListingType.GridList, object model = null)
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

            return query.TransformToOrderModelListing(model, type, listType);
        }

        internal static object PlaceOrder(XOGEntities context = null, OrdersModel model = null)
        {
            if (model == null)
            {
                return null;
            }

            DateTime now = Utilities.DateTimeNow();

            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception("Error Occurred");
                    }
                    return PlaceOrder(_context, model);
                }
            }

            try
            {
                var ids = "";

                model.cartList.ToList().ForEach(i =>
                { 
                    ids += i.ProductId + ",";
                });

                var productList = (List<Object>)ProductBL.GetTList(context, new ProductFilterRequestVM() { Ids = ids }, listType: ListingType.List);

                var orderDetails = new List<OrderDetail>();

                double totalAmount = 0.0;

                for (int i = 0; i < productList.Count; i++)
                {
                    var product = (Product)productList[i];

                    var quantity = model.cartList[i].CartCount;

                    orderDetails.Add(new OrderDetail()
                    {
                        ProductId = product.Id,
                        Price = product.Mrp,
                        Quantity = quantity,
                        Discount = product.DiscountPercentage,
                        Gst = product.Gst,
                        Cost = product.Cost, 
                    });

                    totalAmount = totalAmount + GetProductTotalAmount(product.Mrp, quantity, product.DiscountPercentage, product.Gst);
                }

                var customerInfo = UsersBL.GetUserInfo(model.userId, context);

                Type t = customerInfo.GetType();

                PropertyInfo p = t.GetProperty("Id");

                object customerId = p.GetValue(customerInfo, null);

                var address = context.Addresses.Where(i => i.Id == model.addressesId).FirstOrDefault();
                 
                var order = new Order()
                {
                    OrderedByUserId = customerId.ToString(),
                    OrderDate = now,
                    OrderState = (byte)OrderStatus.Placed,
                    OrderToAddressId = address.Id,
                    Returned = false,
                    DispatchedDate = now,   
                    TotalAmount = totalAmount,
                    DeliveredDate = now,
                    OrderDetails = orderDetails
                };

                var transaction = new DAL.Transaction()
                {
                    PaymentDateTime = now,
                    BilledByUserId = model.userId,
                    TotalAmount = totalAmount,
                    Canceled = false,
                    Order = order
                };

                using (var ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {

                    context.Transactions.Add(transaction);

                    ts.Complete();
                }
                  
                context.SaveChanges();

                return order.Id;

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Some Error Occurred : Details - " + ex.Message);

                return -1;
            }
        }

        internal static object GetOrder(XOGEntities context = null, long id = -1, string userId = "", ModelType modelType = ModelType.Default, bool isCurrent = false)
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
                    return GetOrder(_context, id, userId, modelType, isCurrent);
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

                return data.TransformToOrderModel(type: modelType);

            }
            catch (Exception ex)
            {
                ErrorLogger.LogError("Error Occurred while Loading Order" + ex.Message);

                return null;
            }
        }

        private static double GetProductTotalAmount(double mrp, int quantity, double discount, double gst)
        {
            var toReturn = (mrp - (mrp * discount / 100) - (mrp * gst / 100)) * quantity;
            return toReturn;
        }

    }
}
 
