namespace XOG.AppCode.Models.FilterModels
{
    public interface IAddUserWallet : IBaseFilter
    {
        string Search { get; set; }

        string UserId { get; set; }

        string Ids { get; set; }

        UserType UserType { get; set; }

        bool Enabled { get; set; }
    }
}