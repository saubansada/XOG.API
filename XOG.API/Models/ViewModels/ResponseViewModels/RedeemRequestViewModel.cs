using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class RedeemRequestViewModel : BaseModel
    {
        public long Id { get; set; }
        public string RequestedByUserId { get; set; }
        public string BankAccountNumber { get; set; }
        public long BankAccountId { get; set; }
        public double Amount { get; set; }
        public byte RequestState { get; set; }
        public System.DateTime RequestDateTime { get; set; }
        public System.DateTime? RequestCompletionDateTime { get; set; }
    }
}