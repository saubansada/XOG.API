namespace XOG.AppCode.Models.FilterModels
{
    public interface IUserFilter : IBaseFilter
    {
        string Search { get; set; }

        string Ids { get; set; }

        UserType UserType { get; set; }

        bool Enabled { get; set; }
    }
}