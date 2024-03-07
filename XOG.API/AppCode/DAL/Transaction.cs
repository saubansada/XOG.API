//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XOG.AppCode.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public long Id { get; set; }
        public string BilledByUserId { get; set; }
        public Nullable<long> OrderId { get; set; }
        public double TotalAmount { get; set; }
        public System.DateTime PaymentDateTime { get; set; }
        public Nullable<int> TransactionType { get; set; }
        public Nullable<int> TransactionFor { get; set; }
        public Nullable<long> WalletId { get; set; }
        public Nullable<long> ReturnId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Order Order { get; set; }
        public virtual ReturnOrder ReturnOrder { get; set; }
        public virtual UserWallet UserWallet { get; set; }
    }
}
