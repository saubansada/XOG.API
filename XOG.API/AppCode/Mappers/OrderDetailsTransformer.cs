using System;
using System.Collections.Generic;
using System.Linq;
using XOG.AppCode.DAL; 
using XOG.Util;

//namespace XOG.AppCode.Mappers
//{
//    public static class OrderDetailsTransformer
//    {
//        public static OrderDetailAdminViewModel TransformToViewModel(this OrderDetail model)
//        {
//            try
//            {
//                return model == null ? null : new OrderDetailAdminViewModel()
//                { 
//                    Id = model.Id,
//                    ProductName = model.Product.ProductName,
//                    Price = (float)model.Price,
//                    Discount = model.Discount,
//                    Quantity = model.Quantity,
//                    Total = (float)(((model.Quantity * model.Price) +
//                                     ((model.Quantity * model.Price) * (model.Discount/100))
//                                   ))
//                };
//            }
//            catch (Exception)
//            {
//                ErrorLogger.LogError("Error Occurred while Processing Order Details");
//            }
//            return null;
//        }

//        public static List<OrderDetailAdminViewModel> TransformToViewModelList(this ICollection<OrderDetail> collection, object obj = null)
//        {
//            return collection == null ? null : collection.Select(model => model.TransformToViewModel()).ToList();
//        }
//    }
//}