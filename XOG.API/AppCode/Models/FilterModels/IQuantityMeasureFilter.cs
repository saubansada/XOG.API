﻿namespace XOG.AppCode.Models.FilterModels
{
    public interface IQuantityMeasureFilter : IBaseFilter
    {
        string Search { get; set; }

        string Ids { get; set; }
    }
}