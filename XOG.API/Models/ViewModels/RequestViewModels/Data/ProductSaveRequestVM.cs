using System.ComponentModel.DataAnnotations;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class ProductSaveRequestVM
    {
        public int ProductId { get;set;} 

        [Required]
        public string ProductName { get; set; }
         
        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        public MeasureType Measure { get; set; }

        [Required]
        public float Volume { get; set; }

        [Required]
        public float Price { get; set; }

        public float Discount { get; set; }
    }
}