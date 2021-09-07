using System;
using System.Globalization;
using System.Linq;
using System.Text;
using XOG.AppCode.DAL;
using XOG.AppCode.Helpers;
using XOG.Util;

namespace XOG.AppCode.BLL
{
    public static class SiteMapBL
    {
        internal static bool GenerateSiteMap(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GenerateSiteMap(_context);
                }
            }

            var siteMapString = new StringBuilder("[");

            var mainCategories = EnumsBL.GetProductDivisionList();
              
            mainCategories = mainCategories.Where(i => context.Categories.Count(j => (j.ProductMainType + "") == i.Value) > 0).ToList();
  
            var categories = context.Categories.Where(i => i.SubCategories.Count() > 0).ToList();

            var subCategories = context.SubCategories.Where(i => i.Products.Count() > 0).ToList();

            foreach (var mainCategory in mainCategories)
            {
                if ((Int32.Parse(mainCategory.Value)) > -1)
                {

                    siteMapString.Append("{ \"action\":\"" + mainCategory.Text.ToRouteKey() + "\", \"title\":\"" + mainCategory.Text + "\",");

                    var _categories = categories.Where(i => Int16.Parse(mainCategory.Value) == i.ProductMainType).ToList();

                    if (_categories.Count() > 0)
                    {
                        siteMapString.Append("\"categories\" : [");
                    }

                    TextInfo myTI = new CultureInfo("en-US", false).TextInfo;

                    foreach (var category in _categories)
                    {

                        siteMapString.Append("{ \"action\":\"" + category.RouteKey + "\", \"title\":\"" + myTI.ToTitleCase(category.CategoryName.ToLower()) + "\",");

                        var _subCategories = subCategories.Where(i => i.CategoryId == category.Id).ToList();

                        if (_subCategories.Count() > 0)
                        {
                            siteMapString.Append("\"subcategories\" : [");
                        }

                        foreach (var subCategory in _subCategories)
                        {
                            siteMapString.Append("{ \"action\":\"" + subCategory.RouteKey + "\", \"title\": \"" + myTI.ToTitleCase(subCategory.SubCategoryName.ToLower()) + "\" },");
                        }

                        siteMapString.Remove(siteMapString.Length - 1, 1);

                        if (_subCategories.Count() > 0)
                        {
                            siteMapString.Append("]");
                        }

                        siteMapString.Append("},");

                    }

                    siteMapString.Remove(siteMapString.Length - 1, 1);

                    if (_categories.Count() > 0)
                    {
                        siteMapString.Append("]");
                    }

                    siteMapString.Append(", \"expanded\":false },");

                }
            }

            siteMapString.Remove(siteMapString.Length - 1, 1);

            siteMapString.Append("]");

            bool writeResult = FilesHelper.WriteFile(LocalStorages.Site_Map, siteMapString.ToString());

            siteMapString.Clear();

            siteMapString = null;

            return writeResult;
        }


    }
}