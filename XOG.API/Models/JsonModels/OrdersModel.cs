using XOG.Models.ViewModels;

namespace XOGModels.JsonModels
{
    public class OrdersModel 
    {
        public long addressesId { get; set; }

        public string userId { get; set; }

        public CartViewModel[] cartList { get; set; }
    }
}