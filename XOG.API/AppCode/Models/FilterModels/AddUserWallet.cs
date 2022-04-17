namespace XOG.AppCode.Models.FilterModels
{
    public class AddUserWallet : BaseFilter
    {
        public string Search { get; set; }

        public string Ids { get; set; }

        public UserType UserType { get; set; } = UserType.Any;

        public bool Enabled { get; set; } = true;
    }
}