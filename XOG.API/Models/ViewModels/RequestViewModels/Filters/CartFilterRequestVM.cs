using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class CartFilterRequestVM : BaseFilterRequestVM, ICartFilter
    {
        public string UserId { get; set; }
        public string Search { get; set; }
    }
}