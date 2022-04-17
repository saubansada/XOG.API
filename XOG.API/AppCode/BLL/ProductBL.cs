using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using XOG.AppCode.DAL;
using XOG.AppCode.Mappers;
using XOG.AppCode.Models.FilterModels;
using XOG.Util;

namespace XOG.AppCode.BLL
{
    public class ProductBL
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

                    query = !(string.IsNullOrWhiteSpace(filter.CategoryKey)) ? query.Where(i => i.SubCategory.Category.RouteKey.Equals(filter.CategoryKey)) : query;

                    query = !(string.IsNullOrWhiteSpace(filter.SubCategoryKey)) ? query.Where(i => i.SubCategory.RouteKey.Equals(filter.SubCategoryKey)) : query;

                    query = query.OrderBy(i => i.ProductName.ToLower().StartsWith(filter.Search.ToLower()) ? 0 :
                                               (i.Brand.BrandName.ToLower().StartsWith(filter.Search.ToLower()) ? 1 :
                                               i.SubCategory.SubCategoryName.ToLower().StartsWith(filter.Search.ToLower())
                    ? 2 : 3));

                    query = query.Where(i => i.Enabled).Skip(filter.Skip).Take(filter.PageSize).OrderByDescending(i => i.Id);

                    query = filter.ProductGroupId != null ? query.Where(i => i.ProductGroupId == filter.ProductGroupId) : query;

                    query = filter.ProductGroupKey != null ? query.Where(i => i.ProductGroup.RouteKey == filter.ProductGroupKey) : query;

                }
                else if (filter.ProductQueryType == ProductQueryType.Trending || filter.ProductQueryType == ProductQueryType.Suggestions)
                {
                    query = query.Where(i => i.Enabled);

                    //query = query.Where(i => i.OrderDetails.Count() > 1 && i.OrderDetails.FirstOrDefault().Order.OrderDate >= DateTime.Now).OrderByDescending(i => i.Id).Take(filter.PageSize);
                }
                else if (filter.ProductQueryType == ProductQueryType.Featured)
                {
                    query = query.Where(i => i.Enabled).Skip(filter.Skip).Take(filter.PageSize).OrderByDescending(i => i.Id);
                }
            }
            return query;
        }

        private static IQueryable<ProductVariant> GetVariantFilteredWhereQuery(IQueryable<ProductVariant> query, ProductFilter filter)
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

                    query = filter.SubCategoryId != null ? query.Where(i => i.Product.SubCategoryId == filter.SubCategoryId) : query;

                    query = filter.BrandId != null ? query.Where(i => i.Product.BrandId == filter.BrandId) : query;

                    query = !(string.IsNullOrWhiteSpace(filter.Search)) ? query.Where(i => i.Product.ProductName.StartsWith(filter.Search) ||
                                                                                            i.Product.ProductName.Contains(" " + filter.Search) ||
                                                                                           i.Product.Description.Contains(filter.Search) ||
                                                                                           filter.Search.Contains(i.Product.ProductName) ||
                                                                                           i.Product.Brand.BrandName.StartsWith(filter.Search) ||
                                                                                           i.Product.Brand.BrandName.Contains(filter.Search) ||
                                                                                           filter.Search.Contains(i.Product.Brand.BrandName) ||
                                                                                           i.Product.SubCategory.SubCategoryName.StartsWith(filter.Search) ||
                                                                                           i.Product.SubCategory.SubCategoryName.Contains(filter.Search) ||
                                                                                           filter.Search.Contains(i.Product.SubCategory.SubCategoryName)
                                                                                        ) : query;

                    query = filter.ProductGroupId != 0 ? query.Where(i => i.Product.ProductGroupId == filter.ProductGroupId) : query;

                    query = filter.ProductGroupKey != null ? query.Where(i => i.Product.ProductGroup.RouteKey == filter.ProductGroupKey) : query;

                    query = !(string.IsNullOrWhiteSpace(filter.Ids)) ? query.Where(i => filter.Ids.StartsWith(i.Id + ",") ||
                                                                                      filter.Ids.Contains("," + i.Id + ",")
                                                                                     ) : query;


                    query = !(string.IsNullOrWhiteSpace(filter.SubCategoryKey)) ? query.Where(i => i.Product.SubCategory.RouteKey.Equals(filter.SubCategoryKey)) : query;

                    query = query.OrderBy(i => i.Product.ProductName.ToLower().StartsWith(filter.Search.ToLower()) ? 0 :
                                               (i.Product.Brand.BrandName.ToLower().StartsWith(filter.Search.ToLower()) ? 1 :
                                               i.Product.SubCategory.SubCategoryName.ToLower().StartsWith(filter.Search.ToLower())
                    ? 2 : 3));
                }
                else if (filter.ProductQueryType == ProductQueryType.Variants)
                {
                    var list = filter.Ids.Split(',').ToList();

                    query = query.Where(i => list.Contains(i.Id + ""));
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

        private static IQueryable<ProductVariant> GetVariantsFilteredQuery(ProductFilter filter, XOGEntities context = null)
        {
            if (context == null)
            {
                using (var _context = new XOGEntities())
                {
                    if (_context == null)
                    {
                        throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                    }
                    return GetVariantsFilteredQuery(filter, _context);
                }
            }
            return GetVariantFilteredWhereQuery(context.ProductVariants, filter);
        }


        internal object GetList<T>(ProductFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetList<T>(_context, filter, listType, model);
            }
        }

        internal object GetList<T>(XOGEntities context, ProductFilter filter = null, ListingType listType = ListingType.GridList, object model = null)
        {
            //Name Array is For Search Suggestion in Home Page Search 
            if (filter != null && filter.ProductQueryType == ProductQueryType.Suggestions)
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
            else if (filter != null && filter.ProductQueryType == ProductQueryType.Variants)
            {
                var query = GetVariantsFilteredQuery(filter, context);
                return query.MapToProductVariantModelList<T>(model, listType);
            }
            else
            {
                var query = GetFilteredQuery(filter, context);
                return query.MapToProductModelList<T>(model, listType);
            }
        }

        internal object GetProductByNameOrId<T>(long id = -1, string title = "", bool isAdmin = false)
        {
            using (var _context = new XOGEntities())
            {
                if (_context == null)
                {
                    throw new Exception(Constants.Messages.DB_CONTEXT_INIT_FAILED.ColonNextLine());
                }
                return GetProductByNameOrId<T>(_context, id, title, isAdmin);
            }
        }

        internal object GetProductByNameOrId<T>(XOGEntities context, long id = -1, string title = "", bool isAdmin = false)
        {
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

            return query.FirstOrDefault().MapToProductModel<T>();
        }

        internal async Task<DBStatus> EditAsync(Product model, XOGEntities context = null)
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

                /*
                 * Remove variants from db which has been removed from the model that is being edited
                 */
                var modelVariants = model.ProductVariants.ToList();

                var existingVariants = context.ProductVariants.Where(item => item.ProductId == model.Id).ToList();

                var variantsToRemove = existingVariants.Where(item => modelVariants.Count(v => v.Id == item.Id) == 0).ToList();

                context.ProductVariants.RemoveRange(variantsToRemove);

                foreach (var item in modelVariants)
                {
                    var local = context.ProductVariants.Local.FirstOrDefault(i => i.Id == item.Id);

                    if (local != null)
                    {
                        context.Entry(local).State = EntityState.Detached;
                    }

                    if (item.Id > 0)
                    {
                        context.ProductVariants.Attach(item);

                        context.Entry(item).State = EntityState.Modified;
                    }
                }

                var variantsToAdd = modelVariants.Where(item => existingVariants.Count(v => v.Id == item.Id) == 0).ToList();

                context.ProductVariants.AddRange(variantsToAdd);





                var modelMroductImages = model.ProductImages.ToList();

                var existingImages = context.ProductImages.Where(item => item.ProductId == model.Id).ToList();

                var imagesToRemove = existingImages.Where(item => modelMroductImages.Count(v => v.ImageUrl == item.ImageUrl) == 0).ToList();

                context.ProductImages.RemoveRange(imagesToRemove);

                foreach (var modelImage in modelMroductImages)
                {
                    var existingImg = context.ProductImages.FirstOrDefault(i => i.ImageUrl == modelImage.ImageUrl);

                    var local = context.ProductImages.Local.FirstOrDefault(i => i.ImageUrl == modelImage.ImageUrl);

                    if (local != null)
                    {
                        context.Entry(local).State = EntityState.Detached;
                    }

                    if (existingImg != null)
                    {
                        modelImage.Id = existingImg.Id;

                        if (existingImg.Id > 0)
                        {
                            context.ProductImages.Attach(modelImage);

                            context.Entry(modelImage).State = EntityState.Modified;
                        }
                    }
                }

                var productImagesToAdd = modelMroductImages.Where(item => existingImages.Count(v => v.ImageUrl == item.ImageUrl) == 0).ToList();

                context.ProductImages.AddRange(productImagesToAdd);

                context.Products.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                model.ProductGroupId = model.ProductGroupId == -1 ? null : model.ProductGroupId;

                model.ProductGroup = model.ProductGroupId == -1 ? null : context.ProductGroups.Where(i => i.Id == model.ProductGroupId).FirstOrDefault();

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_UPDATING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal DBStatus Add(Product model, XOGEntities context = null)
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

                context.ProductVariants.AddRange(model.ProductVariants);

                context.SaveChanges();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> AddAsync(Product model, XOGEntities context = null)
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

                model.ProductVariants.ToList().ForEach(item =>
                {

                    item.ProductId = model.Id;
                });

                context.ProductVariants.AddRange(model.ProductVariants);

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_ADDING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteAsync(long Id, XOGEntities context = null)
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

                var variant = context.ProductVariants.FirstOrDefault(i => i.Id == Id);

                if (variant == null)
                {
                    return DBStatus.DoesntExist;
                }

                var count = context.ProductVariants.Count(i => i.ProductId == variant.ProductId);

                if (count == 1)
                {
                    var product = context.Products.Where(i => i.Id == variant.ProductId).SingleOrDefault();

                    var imageList = product.ProductImages.Select(i => i.ImageUrl).ToList();

                    //imageList.AddRange(product.ImageUrl.Split(','));

                    foreach (var imageUrl in imageList)
                    {
                        if (File.Exists(imageUrl.MapPath()))
                        {
                            File.Delete(imageUrl.MapPath());
                        }
                    }

                    context.ProductImages.RemoveRange(product.ProductImages);

                    context.Products.Remove(product);
                }
                else
                {
                    context.ProductVariants.Remove(variant);
                }

                await context.SaveChangesAsync();

                return DBStatus.Success;
            }
            catch (Exception ex)
            {
                ErrorLogger.LogError(Constants.Messages.ERROR_DELETING_PRODUCT.ColonNextLine() + ex.ToString());

                return DBStatus.Error;
            }
        }

        internal async Task<DBStatus> DeleteMultipleAsync(ProductFilter productFilters, XOGEntities context = null)
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

        internal long GetProductsCount(XOGEntities context = null)
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