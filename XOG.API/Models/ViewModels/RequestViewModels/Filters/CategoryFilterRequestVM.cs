using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class CategoryFilterRequestVM : BaseFilterRequestVM, ICategoryFilter
    {
        public string Search { get; set; } 
        public ProductDivision ProductDivision { get; set; } = ProductDivision.None;
        public string Ids { get; set; } 
    }
}