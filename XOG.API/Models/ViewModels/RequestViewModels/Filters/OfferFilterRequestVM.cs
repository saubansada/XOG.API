using System;
using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class OfferFilterRequestVM : BaseFilterRequestVM, IOfferFilter
    { 
        public string Search { get; set; } 
        public DateTime OfferDateStart { get; set; } = DateTime.MinValue; 
        public DateTime OfferDateEnd { get; set; } = DateTime.MaxValue; 
        public int ItemsCountStart { get; set; } = -1; 
        public int ItemsCountEnd { get; set; } = Int32.MaxValue;
        public OfferStatus OfferState { get; set; } = OfferStatus.All;
        public bool IsAdminRequest { get; set; }
    }
}