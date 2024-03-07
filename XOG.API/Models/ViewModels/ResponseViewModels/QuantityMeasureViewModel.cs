using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class QuantityMeasureViewModel : BaseModel
    {
        public short Id { get; set; }

        public string QuantityMeasureName { get; set; }

        public string Acronym { get; set; }
    } 
}