using XOG.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace XOG.AppCode.Helpers
{
    public static class SelectListHelper
    {
        public static List<SelectListItem> ToSelectList(this object obj, bool hasSelect = false, bool isSelectEnabled = true, bool takeValues = true, string value = "-1")
        {
            List<SelectListItem> selectList = new List<SelectListItem>();

            if (hasSelect)
            {
                selectList.Add(new SelectListItem()
                {
                    Text = "-- Select --",
                    Value = "-1",
                    Selected = true,
                    Disabled = !isSelectEnabled,
                });
            }

            if (obj is List<OListItem> && obj != null)
            {
                foreach (var item in (List<OListItem>)obj)
                {
                    selectList.Add(new SelectListItem()
                    {
                        Text = item.Text,
                        Value = takeValues ? item.Value : item.Text,
                        Selected = ((item.Value == value) && !isSelectEnabled) || item.Selected,
                        Disabled = item.Disabled
                    });
                }
            }
            return selectList;
        }
    }
}