using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class CartViewModel : BaseModel
    {
        public long Id { get; set; }

        public long ProductVariantId { get; set; } 
          
        public short Quantity { get; set; }
    }
}