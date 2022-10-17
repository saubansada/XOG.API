using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class UserWalletFilterRequestVM : BaseFilterRequestVM, IAddUserWallet
    {
        public string Search { get; set; }
        public string UserId { get; set; }
        public string Ids { get; set; }
        public UserType UserType { get; set; } = UserType.Any;
        public bool Enabled { get; set; } = true;
    }
}
