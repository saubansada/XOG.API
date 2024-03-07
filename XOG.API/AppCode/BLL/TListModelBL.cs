using System;
using System.Linq;

namespace XOG.AppCode.BLL
{
    public class TListModelBL
    { 
        internal static object GetTListModel<T>(IQueryable<T> query, Func<IQueryable<T>, object, object> func, object model)
        {
            if (func == null)
            {
                return query.ToList();
            }

            return func.DynamicInvoke(query, model);
        } 
    }
}