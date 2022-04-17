namespace XOG.AppCode.Models.FilterModels
{
    public class ProductFilter : BaseFilter
    {
        public string Search { get; set; }

        public string ProductCode { get; set; }

        public string Ids { get; set; }

        public int? SubCategoryId { get; set; }
        
        public string CategoryKey { get; set; }

        public string SubCategoryKey { get; set; }

        public string ProductGroupKey { get; set; }

        public int? ProductGroupId { get; set; }

        public int? BrandId { get; set; }

        public bool Enabled { get; set; } = true;

        public ProductQueryType ProductQueryType { get; set; } = ProductQueryType.FilterOrNone;

    }
}