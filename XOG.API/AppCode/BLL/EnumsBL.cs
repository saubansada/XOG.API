using System.Collections.Generic;
using XOG.Models;
using XOG.Util;

namespace XOG.AppCode.BLL
{
    public static class EnumsBL
    {  
        internal static List<OListItem> GetMeasureList(bool translate = false)
        {
            return Extensions.GetEnumList(typeof(MeasureType), takeValue: false, friendlyText: true, selectedValue: ((byte)MeasureType.Unit).ToString(), translate: translate);
        }

        internal static List<OListItem> GetProductDivisionList(bool translate = false)
        {
            return Extensions.GetEnumList(typeof(ProductDivision), takeValue: true, friendlyText: true, selectedValue: ((byte)ProductDivision.Grocery).ToString(), translate: translate);
        }
    }
}