namespace XOG.AppCode.Models.FilterModels
{
    public interface IRedeemRequestFilter : IBaseFilter
    {
        string Search { get; set; }

        string Ids { get; set; }

        string UserId { get; set; }
    }
}