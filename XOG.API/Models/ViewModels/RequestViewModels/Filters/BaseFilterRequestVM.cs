using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class BaseFilterRequestVM : IBaseFilter
    {
        public string SortbBy { get; set; }
        public string SortOrder { get; set; }
        public string SearchKey { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 12;
        public int Skip { get => PageNumber * (PageSize); }
    }
}