using System;
using System.Collections.Generic;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class OfferRequestVM : BaseModel
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; } 
        public OfferStatus OfferStatus { get; set; }
        public List<OfferDetailRequestVM> OfferDetails { get; set; }
    }

    public class OfferBannerRequestVM : BaseModel
    {
        public short Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public OfferStatus OfferStatus { get; set; } 
        public long OfferId { get; set; }
        public string BannerImageUrl { get; set; }
        public string OfferUrl { get; set; }
        public OfferBannerPlacement Placement { get; set; }
    }

    public class OfferDetailRequestVM
    {
        public long Id { get; set; }

        public long OfferId { get; set; }
        public long ProductId { get; set; } 
    } 
}