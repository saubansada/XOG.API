using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Util;

namespace XOG.AppCode.Transformers
{
    public static class OrderTransformer
    {
        public static object TransformToOrderModelListing(this IQueryable<Order> query, object obj = null, ModelType type = ModelType.Default, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (listType == ListingType.GridList && obj != null)
            {
                _query = query.UpdateGridModelList((GridModel)obj);
            }

            query = _query.Select(model => (Order)model);

            var list = query.ToList();
             
            if (type == ModelType.AdminView)
            {  
                var orders = list.Select(model => new OrderAdminVM()
                {
                    Id = model.Id,
                    OrderDate = model.OrderDate,
                    OrderState = (OrderStatus)model.OrderState,
                    SumAmount = (float)(model.OrderDetails.Sum(i => (i.Price - ((i.Price * i.Discount / 100) + (i.Price * i.Gst / 100))) * i.Quantity)),
                    TotalBill = (float)model.TotalAmount,
                    CustomerInfo = new CustomerAdminBaseViewModel()
                    {
                        Id = model.AspNetUser.Id,
                        CustomerFullName = model.AspNetUser.FirstName + " " + model.AspNetUser.LastName,
                        PrimaryPhoneNumber = model.AspNetUser.PhoneNumber
                    },
                    Purchases = model.OrderDetails.Select(i => new OrderDetailAdminViewModel()
                    {
                        Id = i.Id,
                        Discount = i.Discount,
                        Gst = i.Gst,
                        Price = i.Price,
                        ProductName = i.Product.ProductName,
                        Quantity = i.Quantity,
                        Total = (i.Price - (i.Price * i.Discount / 100) + (i.Price * i.Gst / 100)) * i.Quantity
                    }).ToArray(),
                    DeliveryDate = model.DeliveredDate,
                    DispatchedDate = model.DispatchedDate,
                }).ToList();

                return orders;
            }
            else if (type == ModelType.UserView)
            {
    
                var orders = list.Select(model => new OrdersViewModel()
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
                        ProductName = i.Product.ProductName,
                        Quantity = i.Quantity,
                        Total = (i.Price - (i.Price * i.Discount / 100) + (i.Price * i.Gst / 100)) * i.Quantity
                    }).ToArray(),
                }).ToList();
                 
                return orders;
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
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
                return _query;
            }

            return _query.ToList();
        }


        public static object TransformToOrderModel(this Order model, ModelType type = ModelType.Default, object obj = null)
        {
            if (type == ModelType.AdminView)
            {
                var res = model == null ? null : new OrderAdminVM()
                {
                    Id = model.Id,
                    OrderDate = model.OrderDate,
                    OrderState = (OrderStatus)model.OrderState,
                    CustomerInfo = new CustomerAdminBaseViewModel()
                    {
                        Id = model.AspNetUser.Id,
                        CustomerFullName = model.AspNetUser.FirstName + " " + model.AspNetUser.LastName,
                        PrimaryPhoneNumber = model.AspNetUser.PhoneNumber
                    },
                    DeliveryDate = model.DeliveredDate,
                    DispatchedDate = model.DispatchedDate,
                    SumAmount = (float)(model.OrderDetails.Sum(i => (i.Price - ((i.Price * i.Discount / 100) + (i.Price * i.Gst / 100))) * i.Quantity)),
                    TotalBill = (float)model.TotalAmount,
                    Purchases = model.OrderDetails.Select(i => new OrderDetailAdminViewModel()
                    {
                        Id = i.Id,
                        Discount = i.Discount,
                        Gst = i.Gst,
                        Price = i.Price,
                        ProductName = i.Product.ProductName,
                        Quantity = i.Quantity,
                        Total = (i.Price - (i.Price * i.Discount / 100) + (i.Price * i.Gst / 100)) * i.Quantity
                    }).ToArray(),

                };

                return res;
            }
            else if (type == ModelType.UserView)
            {
                var res = model == null ? null : new OrdersViewModel
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
                        ProductName = i.Product.ProductName,
                        Quantity = i.Quantity,
                        Total = (i.Price - (i.Price * i.Discount / 100) + (i.Price * i.Gst / 100)) * i.Quantity
                    }).ToArray(),
                };

                return res;
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
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

        public static IQueryable<Order> GetOrderDALQueryable(IQueryable<BaseModel> query, ModelType type = ModelType.Default, object obj = null)
        {
            return query == null ? null : query.Select(model => TransformToOrderDALObject(model, type, obj));
        }

        public static Order TransformToOrderDALObject(this BaseModel model, ModelType type = ModelType.Default, object obj = null)
        {
            Order Order = null;

            if (model is OrderAdminVM)
            {
                var _model = (OrderAdminVM)model;
                Order = new Order()
                {
                    Id = _model.Id,
                    DeliveredDate = _model.DeliveryDate,
                    DispatchedDate = _model.DispatchedDate,
                    OrderDate = _model.OrderDate,
                    OrderedByUserId = _model.CustomerInfo.Id,
                    OrderState = (byte)_model.OrderState,
                    Returned = false,
                    TotalAmount = _model.TotalBill,
                };
            }
            else if (model is OrdersViewModel)
            {
                var _model = (OrdersViewModel)model;
                Order = new Order()
                {
                    Id = _model.Id,
                    DeliveredDate = _model.DeliveryDate,
                    DispatchedDate = _model.DispatchedDate,
                    OrderDate = _model.OrderDate,
                    OrderState = (byte)_model.OrderState,
                    Returned = false,
                    TotalAmount = _model.TotalBill,
                };
            }
            return Order;
        }


    }
}