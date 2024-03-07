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
using XOG.Util;

namespace XOG.AppCode.Mappers
{
    public static class OrderTransformer
    {
        public static object MapToOrderRetunsModelList<T>(this IQueryable<OrderVW> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            query = _query.Select(model => (OrderVW)model);

            var list = query.ToList();

            if (typeof(T) == typeof(ReturnOrderViewModel))
            {
                var orders = list.ToList().GroupBy(i => i.ReturnId)
                    .Select(model => new ReturnOrderViewModel()
                    {
                        Id = model.FirstOrDefault().Id,
                        OrderId = model.FirstOrDefault().OrderId,
                        ReturnId = model.FirstOrDefault().ReturnId ?? -1,
                        OrderReturnState = (OrderStatus)model.FirstOrDefault().ReturnOrderStatus,
                        PhoneNumber = model.FirstOrDefault().PhoneNumber,
                        OrderDate = model.FirstOrDefault().OrderDate,
                        OrderState = (OrderStatus)model.FirstOrDefault().OrderState,
                        DeliveryDate = model.FirstOrDefault().DeliveredDate,
                        DispatchedDate = model.FirstOrDefault().DispatchedDate,
                        SumAmount = (float)model.Sum(i => i.OrderedTotal),
                        TotalBill = (float)model.Where(i => i.ReturnId == -1).Sum(i => i.OrderedTotal),
                        ReturnTotal = (float)model.Where(i => i.ReturnId != -1).Sum(i => i.OrderedTotal),
                        Address = new AddressViewModel()
                        {
                            FullName = model.FirstOrDefault().FirstName + " " + model.FirstOrDefault().LastName,
                            AddressLine1 = model.FirstOrDefault().AddressLine1,
                            AddressLine2 = model.FirstOrDefault().AddressLine2,
                            PhoneNumber = model.FirstOrDefault().OrderedPhoneNumber,
                            Country = model.FirstOrDefault().Country,
                            LandMark = model.FirstOrDefault().LandMark,
                            AreaCode = model.FirstOrDefault().AreaCode,
                            Id = model.FirstOrDefault().OrderToAddressId,
                        },
                        IsDelivery = model.FirstOrDefault().OrderToAddressId != 0,
                        Purchases = list.Where(j => model.Key == j.OrderId).Select(i => new OrderDetailViewModel()
                        {
                            Id = i.Id,
                            OrderId = i.OrderId,
                            ReturnDetailId = i.ReturnDetailId ?? -1,
                            Discount = i.Discount,
                            Gst = i.Gst,
                            Price = i.Price,
                            DiscPrice = i.DiscPrice,
                            ProductName = i.ProductName,
                            ReturnedQuantity = i.ReturnedQuantity ?? 0,
                            TotalQuantity = i.TotalQuantity ?? 0,
                            OrderedQuantity = i.OrderedQuantity,
                            TotalReturnedQuantity = i.TotalReturnedQuantity ?? 0,
                            ReturnTotalSum = i.ReturnTotalSum ?? 0,
                            ReturnTotal = i.ReturnTotal ?? 0,
                            Total = i.Total ?? 0,
                            Volume = i.Volume,
                            ReturnOrderDate = i.ReturnOrderDate ?? DateTime.Now,
                            OrderedTotal = i.OrderedTotal,

                            UnitType = new QuantityMeasure()
                            {
                                Acronym = i.Acronym,
                                QuantityMeasureName = i.QuantityMeasureName,
                                Id = i.QuantityMeasureId,
                            },
                            ProductImage = new ProductImage()
                            {
                                Id = i.ImageId,
                                ImageUrl = i.ImageUrl,
                                ProductId = i.ProductId
                            }
                        }).ToArray(),
                    }).ToList();

                return orders;
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();

                return list.Select(model => new OListItem
                {
                    Text = model.OrderId + "",
                    Value = model.OrderId.ToString(),
                    Selected = id != -1 ? model.OrderId == id : false
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

        public static object MapToOrderModelList<T>(this IQueryable<OrderVW> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            query = _query.Select(model => (OrderVW)model);

            var list = query.ToList();

            if (typeof(T) == typeof(OrderViewModel))
            {
                var orders = list.ToList().GroupBy(i => i.OrderId)
                    .Select(model => new OrderViewModel()
                    {
                        Id = model.Key,
                        ReturnId = model.FirstOrDefault().ReturnId ?? -1,
                        OrderReturnState = (OrderStatus)model.FirstOrDefault().ReturnOrderStatus,
                        PhoneNumber = model.FirstOrDefault().PhoneNumber,
                        OrderDate = model.FirstOrDefault().OrderDate,
                        OrderState = (OrderStatus)model.FirstOrDefault().OrderState,
                        DeliveredDate = model.FirstOrDefault().DeliveredDate,
                        DeliveryDate = model.FirstOrDefault().DeliveryDate,
                        DispatchedDate = model.FirstOrDefault().DispatchedDate,
                        SumAmount = (float)model.Sum(i => i.OrderedTotal),
                        TotalBill = (float)model.Where(i => i.ReturnId == -1).Sum(i => i.OrderedTotal),
                        TimePeriodText = model.FirstOrDefault().TimePeriodText,
                        TimePeriod = model.FirstOrDefault().TimePeriod,
                        Address = new AddressViewModel()
                        {
                            FullName = model.FirstOrDefault().FirstName + " " + model.FirstOrDefault().LastName,
                            AddressLine1 = model.FirstOrDefault().AddressLine1,
                            AddressLine2 = model.FirstOrDefault().AddressLine2,
                            PhoneNumber = model.FirstOrDefault().OrderedPhoneNumber,
                            Country = model.FirstOrDefault().Country,
                            LandMark = model.FirstOrDefault().LandMark,
                            AreaCode = model.FirstOrDefault().AreaCode,
                            Id = model.FirstOrDefault().OrderToAddressId,
                        },
                        IsDelivery = model.FirstOrDefault().OrderToAddressId != 0,
                        Purchases = list.Where(j => model.Key == j.OrderId).Select(i => new OrderDetailViewModel()
                        {
                            Id = i.Id,
                            OrderId = i.OrderId,
                            ReturnDetailId = i.ReturnDetailId ?? -1,
                            Discount = i.Discount,
                            Gst = i.Gst,
                            DiscPrice = i.DiscPrice,
                            Price = i.Price,
                            ProductName = i.ProductName,
                            ReturnedQuantity = i.ReturnedQuantity ?? 0,
                            TotalQuantity = i.TotalQuantity ?? 0,
                            OrderedQuantity = i.OrderedQuantity,
                            TotalReturnedQuantity = i.TotalReturnedQuantity ?? 0,
                            ReturnTotalSum = i.ReturnTotalSum ?? 0,
                            ReturnTotal = i.ReturnTotal ?? 0,
                            Total = i.Total ?? 0,
                            Volume = i.Volume,
                            ReturnOrderDate = i.ReturnOrderDate ?? DateTime.Now,
                            OrderedTotal = i.OrderedTotal,
                            UnitType = new QuantityMeasure()
                            {
                                Acronym = i.Acronym,
                                QuantityMeasureName = i.QuantityMeasureName,
                                Id = i.QuantityMeasureId,
                            },
                            ProductImage = new ProductImage()
                            {
                                Id = i.ImageId,
                                ImageUrl = i.ImageUrl,
                                ProductId = i.ProductId
                            }
                        }).ToArray(),
                    }).ToList();

                return orders;
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();

                return list.Select(model => new OListItem
                {
                    Text = model.OrderId + "",
                    Value = model.OrderId.ToString(),
                    Selected = id != -1 ? model.OrderId == id : false
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

        public static object MapToOrderModel<T>(this IQueryable<OrderVW> vList, object obj = null)
        {
            var list = vList.ToList();
            if (typeof(T) == typeof(OrderViewModel))
            {
                var res = list.ToList().GroupBy(i => i.OrderId)
                    .Select(model => new OrderViewModel()
                    {
                        Id = model.FirstOrDefault().OrderId,
                        ReturnId = model.FirstOrDefault().ReturnId ?? -1,
                        OrderReturnState = (OrderStatus)model.FirstOrDefault().ReturnOrderStatus,
                        PhoneNumber = model.FirstOrDefault().PhoneNumber,
                        OrderDate = model.FirstOrDefault().OrderDate,
                        OrderState = (OrderStatus)model.FirstOrDefault().OrderState,
                        DeliveryDate = model.FirstOrDefault().DeliveryDate,
                        DeliveredDate = model.FirstOrDefault().DeliveredDate,
                        DispatchedDate = model.FirstOrDefault().DispatchedDate,
                        SumAmount = (float)model.Sum(i => i.OrderedTotal),
                        TotalBill = (float)model.Where(i => i.ReturnId == -1).Sum(i => i.OrderedTotal),
                        TimePeriod = model.FirstOrDefault().TimePeriod,
                        TimePeriodText = model.FirstOrDefault().TimePeriodText,
                        Address = new AddressViewModel()
                        {
                            FullName = model.FirstOrDefault().FirstName + " " + model.FirstOrDefault().LastName,
                            AddressLine1 = model.FirstOrDefault().AddressLine1,
                            AddressLine2 = model.FirstOrDefault().AddressLine2,
                            PhoneNumber = model.FirstOrDefault().OrderedPhoneNumber,
                            Country = model.FirstOrDefault().Country,
                            LandMark = model.FirstOrDefault().LandMark,
                            AreaCode = model.FirstOrDefault().AreaCode,
                            Id = model.FirstOrDefault().OrderToAddressId,
                        },
                        IsDelivery = model.FirstOrDefault().OrderToAddressId != 0,
                        Purchases = list.Where(j => model.FirstOrDefault().OrderId == j.OrderId)
                        .Select(i => new OrderDetailViewModel()
                        {
                            Id = i.Id,
                            ReturnDetailId = i.ReturnDetailId ?? -1,
                            OrderId = i.OrderId,
                            Discount = i.Discount,
                            Gst = i.Gst,
                            DiscPrice = i.DiscPrice,
                            Price = i.Price,
                            ProductName = i.ProductName,
                            ReturnedQuantity = i.ReturnedQuantity ?? 0,
                            TotalQuantity = i.TotalQuantity ?? 0,
                            OrderedQuantity = i.OrderedQuantity,
                            ReturnTotalSum = i.ReturnTotalSum ?? 0,
                            TotalReturnedQuantity = i.TotalReturnedQuantity ?? 0,
                            ReturnOrderDate = i.ReturnOrderDate ?? DateTime.Now,
                            ReturnTotal = i.ReturnTotal ?? 0,
                            Total = i.Total ?? 0,
                            Volume = i.Volume,
                            OrderedTotal = i.OrderedTotal,
                            UnitType = new QuantityMeasure()
                            {
                                Acronym = i.Acronym,
                                QuantityMeasureName = i.QuantityMeasureName,
                                Id = i.QuantityMeasureId,
                            },
                            ProductImage = new ProductImage()
                            {
                                Id = i.ImageId,
                                ImageUrl = i.ImageUrl,
                                ProductId = i.ProductId
                            }
                        }).ToArray(),
                    }).FirstOrDefault();

                return res;
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();
                return list.Select(model => new OListItem
                {
                    Text = model.FirstName + " " + model.LastName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).FirstOrDefault();
            }
            else
            {
                return list;
            }
        }

        public static IQueryable<Order> MapOrderEtityQueryable(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToOrderEntity(model, obj));
        }


        public static ReturnOrder MapToOrderReturnEntity(this BaseModel model, object obj = null)
        {
            DateTime now = Utilities.DateTimeNow();

            XOGEntities context = (XOGEntities)obj;

            ReturnOrder order = new ReturnOrder();

            if (model is OrderReturnRequestViewModel)
            {
                var _model = (OrderReturnRequestViewModel)model;
                order.OrderId = _model.OrderId;
                order.IsReturn = false;
                order.ReturnOrderDate = now;
                order.ReturnOrderState = (byte)OrderStatus.Pending;
                order.ReturnOrderDetails = _model.ReturnOrderDetails.Select(i =>
                     new ReturnOrderDetail
                     {
                         ReturnOrderId = i.ReturnOrderId,
                         IsCancelled = i.IsCancelled,
                         OrderDetailsId = i.OrderDetailsId,
                         Quantity = i.Quantity,
                     }).ToList();
            }

            return order;
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

                IProductFilter productFilter = new ProductFilterRequestVM() { Ids = ids, ProductQueryType = ProductQueryType.Variants };

                productVariantsList = ((List<object>)new ProductBL().GetList<ProductVariantViewModel>(context, productFilter, ListingType.List)).Select(i => (ProductVariantViewModel)i).ToList();

                purchases = _model.Purchases.ToDictionary(i => i.ProductVariantId, y => y.Quantity);

                order.Id = _model.Id;
                 
                order.TimePeriod = _model.TimePeriod;
            }
            else if (model is OrderViewModel)
            {
                var _model = (OrderViewModel)model;

                ids = ((OrderViewModel)model).Purchases.Select(i => i.Id).ToArray().Join();

                customerInfo = new UserBL().GetUserByNameOrId<UserViewModel>(context, _model.UserId);

                IProductFilter productFilter = new ProductFilterRequestVM() { Ids = ids, ProductQueryType = ProductQueryType.Variants };

                productVariantsList = ((List<object>)new ProductBL().GetList<ProductVariantViewModel>(context, productFilter, ListingType.List)).Select(i => (ProductVariantViewModel)i).ToList();

                purchases = _model.Purchases.ToDictionary(i => i.Id, y => y.OrderedQuantity);

                order.OrderToAddressId = customerInfo.DefaultAddress != null ? customerInfo.DefaultAddress.Id : 1;

                order.Id = _model.Id;
                 
                order.TimePeriod = _model.TimePeriod;
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
            var toReturn = (mrp - (mrp * discount / 100)) * quantity;

            return toReturn;
        }
    }
}