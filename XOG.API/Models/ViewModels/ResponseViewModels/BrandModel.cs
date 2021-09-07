using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class BrandViewModel : BaseModel
    {
        public short Id { get; internal set; }

        public string BrandName { get; internal set; }

        public string BrandDescription { get; internal set; }

        public string BrandUrl { get; internal set; }
    }
}