using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class UserFiltersRequestVM : BaseFilterRequestVM, IUserFilter
    {
        public string Search { get; set; }
        public string Ids { get; set; }
        public UserType UserType { get; set; } = UserType.Any;
        public bool Enabled { get; set; } = true;
    }
}