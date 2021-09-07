using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XOG.AppCode.Models.FilterModels
{ 
    public class CartFilter : BaseFilter
    {
        public string UserId { get; set; }

        public string Search { get; set; }
    }
}