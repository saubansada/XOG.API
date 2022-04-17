using System;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class OrderViewModel : BaseModel
    {
        public long Id { get; set; }

        public string UserId { get; set; }
         
        public long ReturnId { get; set; }
        
        public string PhoneNumber { get; set; }

        public int TimePeriod { get; set; }

        public int RelDay { get; set; }

        public bool IsDelivery { get; set; }

        public DateTime OrderDate { get; set; } 

        public OrderStatus OrderState { get; set; } = OrderStatus.Placed;

        public OrderStatus OrderReturnState { get; set; } = OrderStatus.Placed;

        public DateTime? DispatchedDate { get; set; } 

        public DateTime? DeliveryDate { get; set; }  

        public OrderDetailViewModel[] Purchases { get; set; }

        public float SumAmount { get; set; } 

        public float Gst { get; set; }
           
        public float TotalBill { get; set; }

        public AddressViewModel Address { get; set; }
    }

    public class OrderDetailViewModel
    {
        public long OrderId { get; set; }

        public long Id { get; set; }

        public long ReturnDetailId { get; set; }

        public long ProductVariantId { get; set; }

        public QuantityMeasure UnitType { get; set; }

        public ProductImage ProductImage { get; set; }

        public string ProductName { get; set; } 

        public int TotalQuantity { get; set; }

        public int OrderedQuantity { get; set; }

        public double ReturnTotalSum { get; set; }

        public DateTime ReturnOrderDate { get; set; }

        public int? ReturnedQuantity { get; set; }

        public int? TotalReturnedQuantity { get; set; }
         
        public double Discount { get; set; }

        public double Price { get; set; }  

        public double DiscPrice { get; set; }  

        public double Gst { get; set; } 

        public double Total { get; set; }

        public double OrderedTotal { get; set; }

        public double? ReturnTotal { get; set; }
    } 
}