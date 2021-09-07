using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XOG.AppCode.Models.FilterModels
{
    public class BaseFilter
    { 
        public string SortBy { get; set; }

        public string SortOrder { get; set; }

        public string SearchKey { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; } = 12;

        public int Skip { get => PageNumber * (PageSize); }
    }
}