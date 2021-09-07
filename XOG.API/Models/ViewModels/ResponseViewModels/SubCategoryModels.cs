using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class SubCategoryViewModel : BaseModel
    {
        public short Id { get; set; }

        public string RouteKey { get; set; }

        public short CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string SubCategoryDescription { get; set; }
         
        public string SubCategoryName { get; set; }
    } 
}