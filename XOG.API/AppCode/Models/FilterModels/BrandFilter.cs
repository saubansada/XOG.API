using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XOG.AppCode.Models.FilterModels
{ 
    public class BrandFilter : BaseFilter
    {
        public string Search { get; set; }

        public string Ids { get; set; }
    }
}