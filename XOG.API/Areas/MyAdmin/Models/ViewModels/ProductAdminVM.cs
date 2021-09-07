using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using XOG.Models;
using XOG.AppCode.Models;
using XOG.AppCode.Models.FilterModels;

namespace XOG.Areas.MyAdmin.Models.ViewModels
{
    public class ProductAdminVM : BaseModel
    {
        public long Id { get; set; } = -1;

        [Required(ErrorMessage = "Please Select the Product Main Type")]
        [Display(Name = "Product Division")]
        public ProductDivision ProductDivision { get; set; }

        public List<SelectListItem> ProductDivisionList { get; internal set; }

        [Required(ErrorMessage = "Please select the Category")]
        [Display(Name = "Category")]  
        public short CategoryId { get; set; }
         
        public List<SelectListItem> CategoryList { get; set; }
         
        [Required(ErrorMessage = "Please enter the Sub-Category")]
        [Display(Name = "Sub Category")]  
        public short SubCategoryId { get; set; }
         
        public List<SelectListItem> SubCategoryList { get; set; }

        [Required(ErrorMessage = "Please provide the Brand Name")]
        [Display(Name = "Brand")]
        public short BrandId { get; set; }
         
        public List<SelectListItem> BrandList { get; set; }

        [Required(ErrorMessage = "Product Name is Mandatory")]
        [MaxLength(50, ErrorMessage = "Product Name must be upto 40 characters")]
        [MinLength(3, ErrorMessage = "Product Name must be of Minimum 3 characters")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public bool Enabled { get; set; } = true;

        [Required(ErrorMessage ="Mrp is required")]  
        [Display(Name = "M.R.P")]
        [RegularExpression("^(([1-9]{1}[0-9]{0,2})|([1-9]{1}[0-9]{0,2}[.][0-9]{1,2}))$", ErrorMessage = "Please Enter Valid Amout")]
        public double Mrp { get; set; } 

        [Required(ErrorMessage = "Please Enter the Measure Type")]
        [Display(Name = "Measure")]
        public MeasureType Measure { get; set; }
         
        public List<SelectListItem> MeasureList { get; set; }

        [Required(ErrorMessage = "Volume is required")]  
        [Display(Name = "Volume")]
        [RegularExpression("^([1-9][0-9]{0,2})$")] 
        public string Volume { get; set; }

        [Required(ErrorMessage ="Please proivide Gst")]
        [RegularExpression("^(([1-9]{1}[0-9]{0,1})|([0-9]{1,2}[.][0-9]{1,2})|([0]))$", ErrorMessage = "Please Enter Valid GST %")]
        public short Gst { get; set; }

        [Required(ErrorMessage = "Please proivide Cost")]
        [Display(Name = "Cost")]
        [RegularExpression("^(([1-9]{1}[0-9]{0,2})|([1-9]{1}[0-9]{0,2}[.][0-9]{1,2}))$", ErrorMessage = "Please Enter Valid Amout")]

        public double Cost { get; set; }

        [Required(ErrorMessage = "Please Available")]
        [Display(Name = "Stocks Available")]
        [RegularExpression("^[1-9]{1}[0-9]{1,3}$", ErrorMessage = "Please Enter Valid Quantity")]
        public long StocksAvailable { get; set; }

        [Required(ErrorMessage = "Please proivide Discount Percentage")]
        [Display(Name = "Discount Percentage")]
        [RegularExpression("^(([1-9]{1}[0-9]{0,1})|([0-9]{1,2}[.][0-9]{1,2})|([0]))$", ErrorMessage = "Please Enter Valid Discount %")]
        public double DiscountPercentage { get; set; } = 0;

        [Required(ErrorMessage = "Please proivide Discount Description")]
        [Display(Name = "Product Description")]
        [MaxLength(3000, ErrorMessage = "Maximum Digits is 3000")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; } = "-";

        [Required]
        [Display(Name = "Product Image")]
        public List<String> ProductImage { get; set; }

        [Required]
        [Display(Name = "Max Purchase")]
        [RegularExpression("^(1?[1-9]|20|10)$", ErrorMessage = "Please Enter Valid Number between 1 - 20")]
        public int MaxPurchase { get; set; } = 1;
          
    }

    public class ProductsPageViewModel {

        public ProductFilter filter { get; set; }

        public GridModel gridModel { get; set; }
    }

}