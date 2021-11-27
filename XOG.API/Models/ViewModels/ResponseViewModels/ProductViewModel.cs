using System.Collections.Generic;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class ProductViewModel : BaseModel
    {
        public long Id { get; set; }
        public string ProductCode { get; set; }
        public short BrandId { get; set; }
        public short CategoryId { get; set; }
        public short SubCategoryId { get; set; }
        public short ProductGroupId { get; set; }

        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string BrandName { get; set; }
        public string ProductName { get; set; }

        public string Description { get; set; }
        public List<string> ProductImages { get; set; }
        public List<ProductVariantViewModel> ProductVariants { get; set; }
    }

    public class ProductVariantViewModel  
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public double Mrp { get; set; }
        public double Price { get; set; }

        public string MeasureName { get; set; }
        public short MeasureId { get; set; }
        public short Volume { get; set; }
        public long StocksAvailable { get; set; }

        public short Gst { get; set; }
        public double Cost { get; set; }
        public int MaxPurchase { get; set; }
        public double DiscountPercentage { get; set; }
        public string HSNCode { get; set; }

        public ProductViewModel Product { get; set; }
    }
}