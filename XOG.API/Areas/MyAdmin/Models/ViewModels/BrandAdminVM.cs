using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using XOG.Models;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Models;

namespace XOG.Areas.MyAdmin.Models.ViewModels
{
    public class BrandAdminModel : BaseModel
    {
        public short Id { get; set; } = -1;
          
        [Required(ErrorMessage = "Please Enter Brand Name")]
        [Display(Name = "Brand Name")]
        [MaxLength(30, ErrorMessage = "Maximum characters for brand name is 30")]
        public string BrandName { get; set; }

        [Required(ErrorMessage = "Please Enter Brand Name")]
        [Display(Name = "Brand Url")]
        [MaxLength(50, ErrorMessage = "Maximum characters for brand url is 50")]
        [DataType(DataType.Url)]
        public string BrandUrl { get; set; }
         
        [Display(Name = "Brand Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "Maximum characters for description is 200")]
        public string BrandDescription { get; set; } = "-";

        public List<SelectListItem> ProductDivisionList { get; internal set; }
    }

    public class BrandPageViewModel
    {

        public BrandFilter filter { get; set; }

        public GridModel gridModel { get; set; }

        public BrandAdminModel detailModel { get; set; } = new BrandAdminModel();
    }
}