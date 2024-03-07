//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Web.Mvc;
//using XOG.Models;
//using XOG.AppCode.Models.FilterModels;
//using XOG.AppCode.Models;

//namespace XOG.Areas.MyAdmin.Models.ViewModels
//{
//    public class SubCategoryVM : BaseModel
//    {
//        public short Id { get; set; } = -1;

//        [Required(ErrorMessage = "Please Select the Category")]
//        [Display(Name = "Category")]
//        public short CategoryId { get; set; }

//        [Required(ErrorMessage = "Please Enter Sub-Category Name")]
//        [Display(Name = "Sub-Category Name")]
//        [MaxLength(30, ErrorMessage ="Maximum characters for category name is 30")]
//        public string SubCategoryName { get; set; }

//        [Required(ErrorMessage = "Please Provide the SUb-Category Description")]
//        [Display(Name = "Sub-Category Description")]
//        [DataType(DataType.MultilineText)]
//        [MaxLength(200, ErrorMessage = "Maximum characters for description is 200")]
//        public string SubCategoryDescription { get; set; } = "-";

//        public List<SelectListItem> CategoryList { get; internal set; }
//    }

//    public class SubCategoryPageViewModel
//    {
//        public short Id { get; set; }

//        public SubCategoryFilter filter { get; set; }

//        public GridModel gridModel { get; set; }

//        public SubCategoryVM detailModel { get; set; } = new SubCategoryVM();
//    }

//}