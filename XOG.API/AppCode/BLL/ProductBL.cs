using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using XOG.AppCode.DAL;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Transformers;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.Util;

namespace XOG.AppCode.BLL
{
    public static class ProductBL
    {
        internal static XOGEntities GetXOGContext()
        {
            return new XOGEntities();
        }

        private static IQueryable<Product> GetFilteredWhereQuery(IQueryable<Product> query, ProductFilter filter)
        { 
            if (filter != null)
            { 
                if (filter.ProductQueryType == ProductQueryType.FilterOrNone)
                {

                    if (!string.IsNullOrWhiteSpace(filter.Search))
                    {
                        filter.Search = filter.Search.Replace("_", " ");
                    }
                    query = query.Where(i => !filter.Enabled ? true : i.Enabled);
                    query = filter.SubCategoryId != null ? query.Where(i => i.SubCategoryId == filter.SubCategoryId) : query;
                    query = filter.BrandId != null ? query.Where(i => i.BrandId == filter.BrandId) : query;
                    query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.ProductName.StartsWith(filter.Search) ||
                                                                                            i.ProductName.Contains(" " + filter.Search) ||
                                                                                           i.Description.Contains(filter.Search) ||
                                                                                           filter.Search.Contains(i.ProductName) || 
                                                                                           i.Brand.BrandName.StartsWith(filter.Search) ||
                                                                                           i.Brand.BrandName.Contains(filter.Search) || 
                                                                                           filter.Search.Contains(i.Brand.BrandName) ||
                                                                                           i.SubCategory.SubCategoryName.StartsWith(filter.Search) ||
                                                                                           i.SubCategory.SubCategoryName.Contains(filter.Search) ||
                                                                                           filter.Search.Contains(i.SubCategory.SubCategoryName)
                                                                                        ) : query;
                    query = !(string.IsNullOrWhiteSpace(filter.Ids)) ? query.Where(i => filter.Ids.StartsWith(i.Id + ",") ||
                                                                                       filter.Ids.Contains("," + i.Id + ",")
                                                                                      ) : query;
                    if (!(string.IsNullOrWhiteSpace(filter.MainCategoryKey)))
                    {
                        var mainType = EnumsBL.GetProductDivisionList().Where(i => i.Text.ToRouteKey() == filter.MainCategoryKey).FirstOrDefault(); 
                        query = mainType != null ? query.Where(i => mainType.Value.Equals(i.SubCategory.Category.ProductMainType + "")) : query;
                    }

                    query = !(string.IsNullOrWhiteSpace(filter.CategoryKey)) ? query.Where(i => i.SubCategory.Category.RouteKey.Equals(filter.CategoryKey)) : query;
                    query = !(string.IsNullOrWhiteSpace(filter.SubCategoryKey)) ? query.Where(i => i.SubCategory.RouteKey.Equals(filter.SubCategoryKey)) : query;
                    query = query.OrderBy(i => i.ProductName.ToLower().StartsWith(filter.Search.ToLower()) ? 0 : 
                                               (i.Brand.BrandName.ToLower().StartsWith(filter.Search.ToLower()) ? 1 :
                                               i.SubCategory.SubCategoryName.ToLower().StartsWith(filter.Search.ToLower())
                    ? 2 : 3));
                }
                else if (filter.ProductQueryType == ProductQueryType.Trending || filter.ProductQueryType == ProductQueryType.Suggestions)
                {
                    query = query.Where(i => i.Enabled); 
                    query = query.Where(i => i.OrderDetails.Count() > 1 && i.OrderDetails.FirstOrDefault().Order.OrderDate >= DateTime.Now).OrderByDescending(i => i.Id).Take(filter.PageSize);
                }
                else if (filter.ProductQueryType == ProductQueryType.Featured)
                {
                    query = query.Where(i => i.Enabled).Take(filter.PageSize).OrderByDescending(i => i.Id);
                }
            } 
            return query;
        }

        private static IQueryable<Product> GetFilteredQuery(ProductFilter filter, XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetFilteredQuery(filter, _context);
                }
            }
            return GetFilteredWhereQuery(context.Products, filter);
        }

        internal static object GetTList(XOGEntities context = null, ProductFilter filter = null, 
                                        ModelType type = ModelType.Default, ListingType listType = ListingType.GridList, object model = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetTList(_context, filter, type, listType, model);
                }
            } 
            var query = GetFilteredQuery(filter, context); 
            //Name Array is For Search Suggestion in Home Page Search 
            if (type == ModelType.NameArray)
            { 
                //Product Search Suggestion List For Customers

                var products = GetFilteredQuery(filter, context); 
                var product_categories = products.Select(i => i.SubCategory.SubCategoryName); 
                var product_brand = products.Select(i => i.Brand.BrandName); 
                var sub_category_search = context.SubCategories.Where(i => i.SubCategoryName.StartsWith(filter.Search) ||
                                                                                          i.SubCategoryName.Contains(" " + filter.Search) ||
                                                                                            i.SubCategoryName.Contains(filter.Search) ||
                                                                                          filter.Search.Contains(i.SubCategoryName)).Select(i => i.SubCategoryName);
                var brand_search = context.Brands.Where(i => i.BrandName.StartsWith(filter.Search) ||
                                                                                       i.BrandName.Contains(" " + filter.Search) ||
                                                                                         i.BrandName.Contains(filter.Search) ||
                                                                                       filter.Search.Contains(i.BrandName)).Select(i => i.BrandName); 
                var product_list = products.Select(i => i.ProductName); 
                return product_list.Union(product_brand).Union(product_categories).Union(sub_category_search).Union(brand_search)
                                        .OrderBy(i => i.ToLower().StartsWith(filter.Search.ToLower()) ? 0 : 1).Take(filter.PageSize).ToArray(); 
            } 
            return query.TransformToProductModelListing(model, type, listType);
        }

        internal static object GetProductByNameOrId(XOGEntities context = null, ModelType type = ModelType.Default, long id = -1, string title = "", bool isAdmin = false)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetProductByNameOrId(_context, type, id, title, isAdmin);
                }
            }
            var Product = new Product();

            var query = context.Products.Where(i => true);

            if (id != -1)
            {
                query = context.Products.Where(i => i.Id == id);
            }

            if (!string.IsNullOrWhiteSpace(title))
            {
                query = context.Products.Where(i => i.ProductName.Equals(title.Replace("_", " ")));
            }

            return query.FirstOrDefault().TransformToProductModel(type);
        }

        internal static async Task<DBStatus> EditAsync(Product model, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await EditAsync(model, _context);
                    }

                }
                context.Products.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static DBStatus Add(Product model, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return Add(model, _context);
                    }

                }
                context.Products.Add(model);

                context.ProductImages.AddRange(model.ProductImages);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static async Task<DBStatus> AddAsync(Product model, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await AddAsync(model, _context);
                    }
                }
                context.Products.Add(model);

                context.ProductImages.AddRange(model.ProductImages);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static async Task<DBStatus> DeleteAsync(long Id, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await DeleteAsync(Id, _context);
                    }
                }

                if (context.Products.Where(i => i.Id == Id).Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                var Product = context.Products.Where(i => i.Id == Id).SingleOrDefault();

                context.ProductImages.RemoveRange(Product.ProductImages);

                context.Products.Remove(Product);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static async Task<DBStatus> DeleteMultipleAsync(ProductFilter productFilters, XOGEntities context = null)
        {
            try
            {
                if (context == null)
                {
                    using (var _context = new XOGEntities())
                    {
                        if (_context == null)
                        {
                            throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                        }
                        return await DeleteMultipleAsync(productFilters, _context);
                    }
                }

                var list = await GetFilteredQuery(productFilters, context).ToListAsync();

                if (list.Count() <= 0)
                {
                    return DBStatus.DoesntExist;
                }

                foreach (Product product in list)
                {
                    context.ProductImages.RemoveRange(product.ProductImages);
                }

                context.Products.RemoveRange(list);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal static long GetProductsCount(XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetProductsCount(_context);
                }

            }
            return context.Products.Count(i => i.Enabled);
        }

        //internal static void DownloadImages(List<Product> list)
        //{
        //    foreach(Product Product in list) {
        //        DownloadImage(Product); 
        //    } 
        //}

        //internal static void DownloadImage(Product Product)
        //{ 
        //    //var option = TaskContinuationOptions.OnlyOnFaulted;
        //    // string url = String.Format("https://img.youtube.com/vi/{0}/mqdefault.jpg", Product.YoutubeId);
        //    //ImageHelper.SaveImageFromUrl(url, "~/Storage/Uploads/Products/Thumbnails/".MapPath() + Product.Id + "_thumb.jpg");//.ContinueWith(t => ErrorLogger.LogError("Error Downloading File"), option); ;
        //}

    }
}