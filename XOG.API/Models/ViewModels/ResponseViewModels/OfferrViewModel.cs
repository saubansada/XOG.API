using System;
using System.Collections.Generic;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class OfferViewModel : BaseModel
    {
        public long Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public OfferStatus OfferStatus { get; set; }
        public List<OfferDetailsViewModel> OfferDetails { get; set; }
    }

    public class OfferBannerViewModel : OfferViewModel
    {
        public new short Id { get; set; }
        public string BannerImageUrl { get; set; }
        public string OfferUrl { get; set; }
        public OfferBannerPlacement Placement { get; set; }

        public long OfferId { get; set; }
    }

    public class OfferDetailsViewModel
    {
        public long Id { get; set; }
        public long OfferId { get; set; }
        public long ProductId { get; set; }
    }
}