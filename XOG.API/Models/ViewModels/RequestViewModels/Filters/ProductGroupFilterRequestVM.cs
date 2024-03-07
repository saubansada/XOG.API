using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class ProductGroupFilterRequestVM : BaseFilterRequestVM, IProductGroupFilter
    {
        public string Search { get; set; }
        public short SubCategoryId { get; set; }
        public string Ids { get; set; }
    }
}