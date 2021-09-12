using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class BrandViewModel : BaseModel
    {
        public short Id { get; set; } = -1;
         
        public string BrandName { get; set; }

        public string BrandUrl { get; set; }
         
        public string BrandDescription { get; set; }
    }
}