using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOG.AppCode.Models.FilterModels;

namespace XOG.Models.ViewModels.RequestViewModels.Filters
{
    public class UserWalletFilterRequestVM : AddUserWallet
    {
        public string UserId { get; set; }
    }
}
