using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.ResponseViewModels
{
    public class UserWalletViewModel: BaseModel
    {
        public long Id { get; set; }
        public string UserId { get; set; }

        public TransactionType RequestType { get; set; }

        public double? Amount { get; set; }

        public string Description { get; set; }
    }
}
