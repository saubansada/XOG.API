namespace XOG.AppCode.Models.FilterModels
{
    public interface IBrandFilter : IBaseFilter
    {
        string Search { get; set; }

        string Ids { get; set; }
    }
}