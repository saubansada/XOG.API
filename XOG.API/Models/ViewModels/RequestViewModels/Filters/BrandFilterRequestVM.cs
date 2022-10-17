using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class BrandFilterRequestVM : BaseFilterRequestVM, IBrandFilter
    {
        public string Search { get; set; }
        public string Ids { get; set; }
    }
}