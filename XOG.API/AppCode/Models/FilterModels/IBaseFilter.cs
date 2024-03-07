namespace XOG.AppCode.Models.FilterModels
{
    public interface IBaseFilter
    { 
        string SortbBy { get; set; }

        string SortOrder { get; set; }

        string SearchKey { get; set; }

        int PageNumber { get; set; }

        int PageSize { get; set; }

        int Skip { get; }
    }
}