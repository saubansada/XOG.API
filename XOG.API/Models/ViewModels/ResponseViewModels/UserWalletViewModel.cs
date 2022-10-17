﻿using System;
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
        public TransactionType TransactionType { get; set; }
        public string OrderAction { get; set; }
        public long TransactionId { get; set; }
        public byte[] TimeStamp { get; set; }
        public Nullable<long> ActionId { get; set; }
        public Nullable<double> Amount { get; set; }
    }
}
