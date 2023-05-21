namespace XOG.AppCode.Models.FilterModels
{
    interface IProductFilter : IBaseFilter
    {
        string Search { get; set; }

        string ProductCode { get; set; }

        string Ids { get; set; }

        int? SubCategoryId { get; set; }
        
        string CategoryKey { get; set; }

        string SubCategoryKey { get; set; }

        string ProductGroupKey { get; set; }

        int? ProductGroupId { get; set; }

        int? BrandId { get; set; }

        bool Enabled { get; set; }

        int OfferId { get; set; }

        ProductQueryType ProductQueryType { get; set; }

    }
}