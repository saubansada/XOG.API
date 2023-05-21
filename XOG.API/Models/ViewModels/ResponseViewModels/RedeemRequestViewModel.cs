using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class RedeemRequestViewModel : BaseModel
    {
        public long Id { get; set; }
        public string RequestedByUserId { get; set; }
        public string RequestedUserFullName { get; set; }
        public string PhoneNumber { get; set; }
        public string BankAccountNumber { get; set; } 
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public string AccountName { get; set; }
        public long BankAccountId { get; set; }
        public double Amount { get; set; }
        public ReemRequestStatus RequestState { get; set; }
        public System.DateTime RequestDateTime { get; set; }
        public System.DateTime? RequestCompletionDateTime { get; set; }
    }
}