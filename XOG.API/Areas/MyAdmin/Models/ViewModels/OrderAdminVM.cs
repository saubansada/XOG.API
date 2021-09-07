using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.Models;
using XOG.AppCode.Models.FilterModels;
using XOG.Models;

namespace XOG.Areas.MyAdmin.Models.ViewModels
{
    public class OrderAdminVM : BaseModel
    {
        public long Id { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatus OrderState { get; set; }

        public DateTime? DispatchedDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public CustomerAdminBaseViewModel CustomerInfo { get; set; }

        public OrderDetailAdminViewModel[] Purchases { get; set; }

        public float SumAmount { get; set; }

        public float Gst { get; set; }

        public float TotalBill { get; set; }
         
    }

    public class OrderDetailAdminViewModel
    {
        public long Id { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public double Price { get; set; }

        public double Discount { get; set; }

        public double Gst { get; set; }

        public double Total { get; set; }

    }

    public class CustomerAdminBaseViewModel
    { 
        public string Id { get; set; }

        public string CustomerFullName { get; set; }
         
        public string PrimaryPhoneNumber { get; set; }
    }

    public class CustomerAdminViewModel : CustomerAdminBaseViewModel
    {

        public string UserName { get; set; }

        public string CustomerEmail { get; set; } 
         
        public bool IsPrimaryPhoneNumberConfirmed { get; set; }

        public string AlternatePhoneNumber { get; set; }

        public List<string> Addresses { get; set; } = new List<string>();

    }
     
    public class OrdersPageViewModel
    {

        public OrderFilter filter { get; set; }

        public GridModel gridModel { get; set; }

        public OrderAdminVM detailModel { get; set; }
    }
}