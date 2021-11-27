using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class AddressViewModel : BaseModel
    {
        public long Id { get; set; }

        public string AddressOfUserId { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string AreaCode { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string LandMark { get; set; }

        public string Country { get; set; }

        public string GPS { get; set; }

        public bool IsDefault { get; set; }
    }
}