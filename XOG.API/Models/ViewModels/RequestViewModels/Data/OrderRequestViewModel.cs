using System;
using System.Collections.Generic;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class OrderRequestVM : BaseModel
    {
        public long Id { get; set; }

        public long ReturnId { get; set; }

        public string UserId { get; set; }

        public byte TimePeriod { get; set; }

        public int RelDay { get; set; }

        public bool IsDeliveery { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatus OrderState { get; set; } = OrderStatus.Pending;

        public DateTime? DispatchedDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public PaymentType PaymentMode { get; set; }
         
        public string PaymentId { get; set; }

        public bool UseWallet { get; set; }

        public string PaymentOrderId { get; set; }

        public string PaymentSignature { get; set; }

        public List<OrderDetailRequestVM> Purchases { get; set; }
    }

    public class OrderDetailRequestVM
    {
        public long ProductVariantId { get; set; }

        public int Quantity { get; set; }
    }

    public class OrderInitiateRequestVM
    {
        public Boolean UseWallet { get; set; }
        public List<CartViewModel> CartList { get; set; }
    }
}