using System;
using System.Collections.Generic;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class OrderReturnRequestViewModel : BaseModel
    {
        public long Id { get; set; }

        public long? OrderId { get; set; }

        public long? IsReturn { get; set; }

        public DateTime ReturnOrderDate { get; set; }

        public byte ReturnOrderState { get; set; }

        public List<OrderReturnDetailRequestViewModel> ReturnOrderDetails { get; set; }
    }

    public class OrderReturnDetailRequestViewModel : BaseModel
    {
        public long Id { get; set; }

        public long ReturnOrderId { get; set; }

        public long OrderDetailsId { get; set; }

        public int Quantity { get; set; }

        public bool IsCancelled { get; set; }
    }
}