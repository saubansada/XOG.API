using System;

namespace XOG.AppCode.Models.FilterModels
{
    interface IOfferFilter : IBaseFilter
    {
        string Search { get; set; }

        DateTime OfferDateStart { get; set; } 

        DateTime OfferDateEnd { get; set; } 

        int ItemsCountStart { get; set; } 

        int ItemsCountEnd { get; set; } 

        OfferStatus OfferState { get; set; } 
        
        bool IsAdminRequest { get; set; }
    }

}