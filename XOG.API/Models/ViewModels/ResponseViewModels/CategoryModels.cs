using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class CategoryViewModel : BaseModel
    {
        public short Id { get; set; }

        public string RouteKey { get; set; }
        
        public string CategoryName { get; set; }

        public string CategoryImage { get; set; }

        public string CategoryBanner { get; set; }

        public string CategoryDescription { get; set; }
    }

}