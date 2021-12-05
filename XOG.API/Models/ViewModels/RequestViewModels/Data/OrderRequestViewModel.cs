using System;
using System.Collections.Generic;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class OrderRequestVM : BaseModel
    {
        public long Id { get; set; }

        public string UserId { get; set; }

        public int TimePeriod { get; set; }

        public int RelDay { get; set; }

        public bool IsDeliveery { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatus OrderState { get; set; } = OrderStatus.Placed;

        public DateTime? DispatchedDate { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public List<OrderDetailRequestVM> Purchases { get; set; }
    }

    public class OrderDetailRequestVM
    {
        public long ProductVariantId { get; set; }

        public int Quantity { get; set; }
    }
}