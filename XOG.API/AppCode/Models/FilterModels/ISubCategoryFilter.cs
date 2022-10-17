namespace XOG.AppCode.Models.FilterModels
{
    public interface ISubCategoryFilter : IBaseFilter
    {
        string Search { get; set; }
          
        short CategoryId { get; set; }

        string Ids { get; set; }

    }
}