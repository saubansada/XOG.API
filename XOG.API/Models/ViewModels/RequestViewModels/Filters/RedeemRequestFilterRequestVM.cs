using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class RedeemRequestFilterRequestVM : BaseFilterRequestVM, IRedeemRequestFilter
    {
        public string Search { get; set; }
        public string Ids { get; set; }
        public string UserId { get; set; }
    }
}