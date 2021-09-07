using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class OrdersViewModel : BaseModel
    {
        public long Id { get; set; } 

        public DateTime OrderDate { get; set; } 

        public OrderStatus OrderState { get; set; } = OrderStatus.Placed; 

        public DateTime? DispatchedDate { get; set; } 

        public DateTime? DeliveryDate { get; set; }  

        public OrderDetailViewModel[] Purchases { get; set; } 

        public float SumAmount { get; set; } 

        public float Gst { get; set; } 

        public float TotalBill { get; set; }
    }

    public class OrderDetailViewModel
    {
        public long Id { get; set; } 

        public string ProductName { get; set; } 

        public int Quantity { get; set; } 

        public double Price { get; set; } 

        public double Discount { get; set; } 

        public double Gst { get; set; } 

        public double Total { get; set; }
    } 
}