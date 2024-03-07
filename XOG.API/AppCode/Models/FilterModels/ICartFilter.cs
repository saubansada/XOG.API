namespace XOG.AppCode.Models.FilterModels
{
    public interface ICartFilter : IBaseFilter
    {
        string UserId { get; set; }

        string Search { get; set; }
    }
}