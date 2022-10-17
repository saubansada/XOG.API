using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.AppCode.Models.FilterModels
{
    public interface IProductGroupFilter : IBaseFilter
    {
        string Search { get; set; }

        short SubCategoryId { get; set; }

        string Ids { get; set; }
    }
}