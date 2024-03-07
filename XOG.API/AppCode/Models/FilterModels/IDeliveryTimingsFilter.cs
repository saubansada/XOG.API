namespace XOG.AppCode.Models.FilterModels
{
    public interface IDeliveryTimingsFilter : IBaseFilter
    {
        string Search { get; set; }

        string Ids { get; set; }
    }
}