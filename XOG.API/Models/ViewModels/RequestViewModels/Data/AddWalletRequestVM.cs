using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.Models; 

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class AddWalletRequestVM : BaseModel
    {
        public long Id { get; set; }
        public string UserId { get; set; }

        public TransactionType RequestType { get; set; }

        public double Amount { get; set; }

        public string Description { get; set; }

    }
}