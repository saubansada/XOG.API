using System;
using System.ComponentModel.DataAnnotations;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class QuantityMeasureRequestVM : BaseModel
    {
        public short Id { get; set; } = -1; 

        [Required(ErrorMessage = "Please Enter Measure Name")]
        [MaxLength(30, ErrorMessage = "Maximum characters for name is 20")]
        public string QuantityMeasureName { get; set; }

        [Required(ErrorMessage = "Please Enter Measure Acronym")]
        [MaxLength(30, ErrorMessage = "Maximum characters for acronym is 5")]
        public string Acronym { get; set; }
    }
}