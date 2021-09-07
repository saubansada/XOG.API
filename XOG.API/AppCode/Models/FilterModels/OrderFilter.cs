using System;

namespace XOG.AppCode.Models.FilterModels
{
    public class OrderFilter : BaseFilter
    {
        public string CustomerName { get; set; }

        public string Search { get; set; }

        public DateTime OrderDateStart { get; set; } = DateTime.MinValue;

        public DateTime OrderDateEnd { get; set; } = DateTime.MaxValue;

        public int ItemsCountStart { get; set; } = -1;

        public int ItemsCountEnd { get; set; } = Int32.MaxValue;

        public OrderStatus OrderState { get; set; } = OrderStatus.All;

        public bool isNewOrder { get; set; } = false; 

        public string userIds { get; set; } = "";
    }
     
}