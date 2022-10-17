using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class SubCategoryFilterRequestVM : BaseFilterRequestVM, ISubCategoryFilter
    {
        public string Search { get; set; }

        public short CategoryId { get; set; } = -1;
        public string Ids { get; set; }
    }
}