namespace XOG.AppCode.Models.FilterModels
{
    public interface ICategoryFilter : IBaseFilter
    {
        string Search { get; set; }

        ProductDivision ProductDivision { get; set; }

        string Ids { get; set; }

    }
}