using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XOG.AppCode.BLL
{
    public class TListModelBL
    { 
        internal static object GetTListModel<T>(IQueryable<T> query, Func<IQueryable<T>, object, object> func, object model, ModelType type = ModelType.Default)
        {
            if (func == null)
            {
                return query.ToList();
            }

            return func.DynamicInvoke(query, model);
        } 
    }
}