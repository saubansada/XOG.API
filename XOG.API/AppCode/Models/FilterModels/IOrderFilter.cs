using System;

namespace XOG.AppCode.Models.FilterModels
{
    interface IOrderFilter : IBaseFilter
    {
        string CustomerName { get; set; }

        string Search { get; set; }

        DateTime OrderDateStart { get; set; } 

        DateTime OrderDateEnd { get; set; } 

        int ItemsCountStart { get; set; } 

        int ItemsCountEnd { get; set; } 

        bool IsReturnedOrder { get; set; }

        OrderStatus OrderState { get; set; } 

        bool isNewOrder { get; set; } 

        string userIds { get; set; } 

        bool IsAdminRequest { get; set; }
    }

}