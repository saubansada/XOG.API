using System;
using System.ComponentModel.DataAnnotations;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class BrandRequestVM : BaseModel
    {
        public short Id { get; set; } = -1;

        [Required(ErrorMessage = "Please Provide the Brand Name")]
        public string BrandName { get; set; }
          
        public string BrandUrl { get; set; }

        [Required(ErrorMessage = "Please Provide the Brand Description")] 
        public string BrandDescription { get; set; } = "-";
    }
}