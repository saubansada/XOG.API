using System;
using System.Collections.Generic;
using System.Linq;
using XOG.AppCode.BLL;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.AppCode.Models.FilterModels;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.Models.ViewModels.ResponseViewModels;
using XOG.Util;

namespace XOG.AppCode.Mappers
{
    public static class OrderTransformer
    {
        public static object MapToOrderModelList<T>(this IQueryable<Order> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            query = _query.Select(model => (Order)model);

            var list = query.ToList();

            if (typeof(T) == typeof(OrderViewModel))
            {
                var orders = list.Select(model => new OrderViewModel()
                {
                    Id = model.Id,
                    OrderDate = model.OrderDate,
                    OrderState = (OrderStatus)model.OrderState,
                    DeliveryDate = model.DeliveredDate,
                    DispatchedDate = model.DispatchedDate,
                    SumAmount = (float)(model.OrderDetails.Sum(i => (i.Price - ((i.Price * i.Discount / 100) + (i.Price * i.Gst / 100))) * i.Quantity)),
                    TotalBill = (float)model.TotalAmount,
                    Purchases = model.OrderDetails.Select(i => new OrderDetailViewModel()
                    {
                        Id = i.Id,
                        Discount = i.Discount,
                        Gst = i.Gst,
                        Price = i.Price,
                        ProductName = i.ProductVariant.Product.ProductName,
                        Quantity = i.Quantity,
                        Total = (i.Price - (i.Price * i.Discount / 100) + (i.Price * i.Gst / 100)) * i.Quantity
                    }).ToArray(),
                }).ToList();

                return orders;
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();

                return list.Select(model => new OListItem
                {
                    Text = model.AspNetUser.FirstName + " " + model.AspNetUser.LastName + " - " + model.Id,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).ToList();
            }


            if (listType == ListingType.Queryable)
            {
                return (T)Convert.ChangeType(_query, typeof(T)); ;
            }
            else if (listType == ListingType.GridList && obj != null)
            {
                _query = _query.UpdateGridModelList((GridModel)obj);
            }

            return _query.ToList();
        }


        public static object MapToOrderModel<T>(this Order model, object obj = null)
        {
            if (typeof(T) == typeof(OrderViewModel))
            {
                var res = model == null ? null : new OrderViewModel
                {
                    Id = model.Id,
                    OrderDate = model.OrderDate,
                    OrderState = (OrderStatus)model.OrderState,
                    DeliveryDate = model.DeliveredDate,
                    DispatchedDate = model.DispatchedDate,
                    SumAmount = (float)(model.OrderDetails.Sum(i => (i.Price - ((i.Price * i.Discount / 100) + (i.Price * i.Gst / 100))) * i.Quantity)),
                    TotalBill = (float)model.TotalAmount,
                    Purchases = model.OrderDetails.Select(i => new OrderDetailViewModel()
                    {
                        Id = i.Id,
                        Discount = i.Discount,
                        Gst = i.Gst,
                        Price = i.Price,
                        ProductName = i.ProductVariant.Product.ProductName,
                        Quantity = i.Quantity,
                        Total = (i.Price - (i.Price * i.Discount / 100) + (i.Price * i.Gst / 100)) * i.Quantity
                    }).ToArray(),
                };

                return res;
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();
                return new OListItem
                {
                    Text = model.AspNetUser.FirstName + " " + model.AspNetUser.LastName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                };
            }
            else
            {
                return model;
            }
        }

        public static IQueryable<Order> MapOrderEtityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToOrderEntity(model, obj));
        }

        public static Order MapToOrderEntity(this BaseModel model, object obj = null)
        {
            DateTime now = Utilities.DateTimeNow();

            UserViewModel customerInfo = null;

            XOGEntities context = (XOGEntities)obj;

            Order order = new Order();

            List<OrderDetail> orderDetails = new List<OrderDetail>();

            List<ProductVariantViewModel> productVariantsList = new List<ProductVariantViewModel>();

            Dictionary<long, int> purchases = new Dictionary<long, int>();

            string ids = "";

            if (model is OrderRequestVM)
            {
                var _model = (OrderRequestVM)model;

                ids = _model.Purchases.Select(i => i.ProductVariantId).ToArray().Join(",");

                customerInfo = new UserBL().GetUserByNameOrId<UserViewModel>(context, _model.UserId);

                order.OrderToAddressId = customerInfo.DefaultAddress != null ? customerInfo.DefaultAddress.Id : 1;

                ProductFilter productFilter = new ProductFilter() { Ids = ids, ProductQueryType = ProductQueryType.Variants };

                productVariantsList = ((List<object>)new ProductBL().GetList<ProductVariantViewModel>(context, productFilter, ListingType.List)).Select(i => (ProductVariantViewModel)i).ToList();

                purchases = _model.Purchases.ToDictionary(i => i.ProductVariantId, y => y.Quantity);

                order.Id = _model.Id;
            }
            else if (model is OrderViewModel)
            {
                var _model = (OrderViewModel)model;

                ids = ((OrderViewModel)model).Purchases.Select(i => i.Id).ToArray().Join();

                customerInfo = new UserBL().GetUserByNameOrId<UserViewModel>(context, _model.UserId);
                 
                ProductFilter productFilter = new ProductFilter() { Ids = ids, ProductQueryType = ProductQueryType.Variants };

                productVariantsList = ((List<object>)new ProductBL().GetList<ProductVariantViewModel>(context, productFilter, ListingType.List)).Select(i => (ProductVariantViewModel)i).ToList();

                purchases = _model.Purchases.ToDictionary(i => i.Id, y => y.Quantity);

                order.OrderToAddressId = customerInfo.DefaultAddress != null ? customerInfo.DefaultAddress.Id : 1;

                order.Id = _model.Id;
            }
             
            order.TotalAmount = 0.0;

            for (int i = 0; i < productVariantsList.Count; i++)
            {
                var product = productVariantsList[i];
                 
                orderDetails.Add(new OrderDetail()
                {
                    ProductVariantId = product.Id,

                    Price = product.Mrp,

                    Quantity = purchases[product.Id],

                    Discount = product.DiscountPercentage,

                    Gst = product.Gst,

                    Cost = product.Cost
                });

                order.TotalAmount += GetProductTotalAmount(product.Mrp, purchases[product.Id], product.DiscountPercentage, product.Gst);
            }

            order.OrderedByUserId = customerInfo.Id;

            order.OrderDate = now;

            order.OrderState = (byte)OrderStatus.Placed;

            order.Returned = false;

            order.DispatchedDate = now;

            order.DeliveredDate = now;

            order.OrderDetails = orderDetails;

            return order;
        } 

        private static double GetProductTotalAmount(double mrp, int quantity, double discount, double gst)
        {
            var toReturn = (mrp - (mrp * discount / 100) - (mrp * gst / 100)) * quantity;

            return toReturn;
        }
    }
}