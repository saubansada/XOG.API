using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class CartViewModel : BaseModel
    {
        public long Id { get; set; }

        public long ProductId { get; set; }

        public string AddedByUserId { get;set;}

        public int MaxPurchase { get; set; }

        public short CartCount { get; set; }
    }
}