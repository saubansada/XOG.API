using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class BankAccountFilterRequestVM : BaseFilterRequestVM, IBankAccountFilter
    {
        public string Search { get; set; }
        public string Ids { get; set; }
        public string UserId { get; set; }
    }
}