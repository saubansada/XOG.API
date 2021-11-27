namespace XOG.AppCode.Models.FilterModels
{
    public class ProductGroupFilter : BaseFilter
    {
        public string Search { get; set; }

        public short SubCategoryId { get; set; }
          
        public string Ids { get; set; }
    }
}