﻿namespace XOG.AppCode.Models.FilterModels
{
    public class SubCategoryFilter : BaseFilter
    {
        public string Search { get; set; }
          
        public short CategoryId { get; set; } = -1;

        public string Ids { get; set; }

    }
}