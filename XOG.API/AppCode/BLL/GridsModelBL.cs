using System;
using System.Linq;

namespace XOG.AppCode.BLL
{
    public class GridsModelBL
    {
        internal static object GetGridModel<T>(IQueryable<T> query, Func<IQueryable<T>, object, object> func, object model)
        {
            return func.DynamicInvoke(query, model); 
        }
    }
}