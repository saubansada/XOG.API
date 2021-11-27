using System;
using System.ComponentModel.DataAnnotations;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class ProductGroupRequestVM : BaseModel
    {
        public short Id { get; set; } = -1;

        [Required(ErrorMessage = "Please Select the Sub Category")]
        public short SubCategoryId { get; set; }

        [Required(ErrorMessage = "Please Enter Group Name")]
        [MaxLength(30, ErrorMessage = "Maximum characters for name is 30")]
        public string ProductGroupName { get; set; }

        public string ProductGroupImage { get; set; }

        [Required(ErrorMessage = "Please Provide the Description")]
        [MaxLength(300, ErrorMessage = "Maximum characters for description is 300")]
        public string ProductGroupDescription { get; set; } = "-";
    }
}