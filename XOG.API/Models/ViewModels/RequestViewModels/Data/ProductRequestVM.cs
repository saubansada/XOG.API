using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class ProductRequestVM : BaseModel
    {
        public long Id { get; set; }
        
        public string ProductCode { get; set; }

        [Required]
        public short BrandId { get; set; }

        [Required]
        public short CategoryId { get; set; }

        [Required]
        public short SubCategoryId { get; set; }

        [Required]
        public short ProductGroupId { get; set; }

        [Required]
        public string ProductName { get; set; }
         
        public string Description { get; set; }
        public List<string> ProductImages { get; set; }
        public List<ProductVariantRequestVM> ProductVariants { get; set; }
    }


    public class ProductVariantRequestVM : BaseModel
    { 
        [Required]
        public long Id { get; set; }

        [Required]
        public long ProductId { get; set; }

        [Required]
        public double Mrp { get; set; }
          
        [Required]
        public short MeasureId { get; set; }

        [Required]
        public short Volume { get; set; }

        [Required]
        public long StocksAvailable { get; set; }

        [Required]
        public short Gst { get; set; }

        [Required]
        public double Cost { get; set; }

        [Required]
        public int MaxPurchase { get; set; }

        public string HSNCode { get; set; }

        [Required]
        public double DiscountPercentage { get; set; }
    }
}