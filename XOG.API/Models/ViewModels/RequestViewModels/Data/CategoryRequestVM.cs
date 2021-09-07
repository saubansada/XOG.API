using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class CategoryRequestVM : BaseModel
    {
        public short Id { get; set; } = -1;

        [Required(ErrorMessage = "Please Select the Product Main Type")]
        [Display(Name = "Product Division")]
        public ProductDivision ProductDivision { get; set; }

        [Required(ErrorMessage = "Please Enter Category Name")]
        [Display(Name = "Category Name")]
        [MaxLength(30, ErrorMessage = "Maximum characters for category name is 30")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Please Provide the Category Description")]
        [Display(Name = "Category Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "Maximum characters for description is 200")]
        public string CategoryDescription { get; set; } = "-";

        public List<OListItem> ProductDivisionList { get; internal set; }
    }
}