using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XOG.AppCode.Models.FilterModels
{ 
    public class CategoryFilter : BaseFilter
    {
        public string Search { get; set; }

        public ProductDivision ProductDivision { get; set; } = ProductDivision.None;
          
        public string Ids { get; set; }

    }
}