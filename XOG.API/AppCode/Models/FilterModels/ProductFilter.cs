using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XOG.AppCode.Models.FilterModels
{ 
    public class ProductFilter : BaseFilter
    {
        public string Search { get; set; }

        public string Ids { get; set; }

        public int? SubCategoryId { get; set; }

        public string MainCategoryKey { get; set; }

        public string CategoryKey { get; set; }

        public string SubCategoryKey { get; set; }

        public int? BrandId { get; set; }

        public bool Enabled { get; set; } = true;

        public ProductQueryType ProductQueryType { get; set; } = ProductQueryType.FilterOrNone;

    }
}