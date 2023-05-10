using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class BankAccountViewModel : BaseModel
    {
        public long  Id { get; set; }
        public string AccountOfUserId { get; set; } 
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IFSCCode { get; set; }
        public string AccountName { get; set; }
    }
}