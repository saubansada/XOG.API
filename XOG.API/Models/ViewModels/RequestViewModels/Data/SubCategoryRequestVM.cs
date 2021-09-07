using System.ComponentModel.DataAnnotations;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class SubCategoryRequestVM : BaseModel
    {
        public short Id { get; set; } = -1;

        [Required(ErrorMessage = "Please Select the Category")]
        public short CategoryId { get; set; }

        [Required(ErrorMessage = "Please Enter Category Name")]
        [MaxLength(30, ErrorMessage = "Maximum characters for category name is 30")]
        public string SubCategoryName { get; set; }

        [Required(ErrorMessage = "Please Provide the Category Description")]
        [MaxLength(300, ErrorMessage = "Maximum characters for description is 300")]
        public string SubCategoryDescription { get; set; } = "-";
    }
}