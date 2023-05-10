namespace XOG.AppCode.Models.FilterModels
{
    public interface IBankAccountFilter : IBaseFilter
    {
        string Search { get; set; }

        string Ids { get; set; }

        string UserId { get; set; }
    }
}