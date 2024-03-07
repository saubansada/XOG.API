using System.ComponentModel.DataAnnotations;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class CategoryRequestVM : BaseModel
    {
        public short Id { get; set; } = -1;
        
        [Required(ErrorMessage = "Please Enter Category Name")]
        [MaxLength(30, ErrorMessage = "Maximum characters for category name is 30")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Please Provide Category Image")]
        public string CategoryImage { get; set; }

        [Required(ErrorMessage = "Please Provide Category Banner")]
        public string CategoryBanner { get; set; }

        [Required(ErrorMessage = "Please Provide the Category Description")]
        [MaxLength(300, ErrorMessage = "Maximum characters for description is 300")]
        public string CategoryDescription { get; set; } = "-";
    }
}