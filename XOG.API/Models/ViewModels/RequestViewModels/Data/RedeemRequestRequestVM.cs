using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class RedeemRequestRequestVM : BaseModel
    {
        public long Id { get; set; }
        public string RequestedByUserId { get; set; }
        public string BankAccountNumber { get; set; }
        public string RequestedUserUserFullName { get; set; } 
        public string PhoneNumber { get; set; }
        public long BankAccountId { get; set; }
        public double Amount { get; set; }
        public byte RequestState { get; set; }
        public System.DateTime RequestDateTime { get; set; }
        public System.DateTime? RequestCompletionDateTime { get; set; }


    }
}