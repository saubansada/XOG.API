using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class ProductGroupViewModel : BaseModel
    {
        public short Id { get; set; }

        public string RouteKey { get; set; }

        public short CategoryId { get; set; }

        public string CategoryName { get; set; }

        public short SubCategoryId { get; set; }

        public string SubCategoryName { get; set; }

        public string ProductGroupImage { get; set; }

        public string ProductGroupDescription { get; set; }
         
        public string ProductGroupName { get; set; }
    } 
}