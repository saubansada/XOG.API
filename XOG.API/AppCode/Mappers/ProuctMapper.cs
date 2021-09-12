using System;
using System.Collections.Generic;
using System.Linq;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Util;

namespace XOG.AppCode.Mappers
{
    public static class ProuctMapper
    {
        public static object MapToProductModelList<T>(this IQueryable<Product> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(ProductViewModel))
            {
                _query = query.Select(model => new ProductViewModel
                {
                    Id = model.Id,
                    CategoryName = model.SubCategory.Category.CategoryName,
                    SubCategoryId = model.SubCategoryId,
                    SubCategoryName = model.SubCategory.SubCategoryName,
                    BrandId = model.BrandId,
                    BrandName = model.Brand.BrandName,
                    ProductName = model.ProductName,
                    Description = model.Description,
                    ProductImages = model.ProductImages.Select(i => i.ImageUrl).ToList(),
                    ProductVariants = model.ProductVariants.Select(item => new ProductVariantViewModel
                    {
                        Id = item.Id,
                        Mrp = item.Mrp,
                        Cost = item.Cost,
                        DiscountPercentage = item.DiscountPercentage,
                        Gst = item.Gst,
                        MaxPurchase = item.MaxPurchase,
                        Measure = item.Measure,
                        ProductId = item.ProductId,
                        StocksAvailable = item.StocksAvailable,
                        Volume = item.Volume
                    }).ToList()
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.ProductName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).ToList();
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();
                return query.Select(model => model.ProductName).ToArray();
            }

            if (listType == ListingType.Queryable)
            {
                return _query;
            }
            else if (listType == ListingType.GridList && obj != null)
            {
                _query = _query.UpdateGridModelList((GridModel)obj);
            }
            return _query.ToList();
        }

        public static T MapToProductModel<T>(this Product model, object obj = null)
        {
            if (typeof(T) == typeof(ProductViewModel))
            {
                var _obj = new ProductViewModel
                {
                    Id = model.Id, 
                    CategoryId = model.SubCategory.Category.Id,
                    CategoryName = model.SubCategory.Category.CategoryName,
                    SubCategoryId = model.SubCategoryId,
                    SubCategoryName = model.SubCategory.SubCategoryName,
                    BrandId = model.BrandId,
                    BrandName = model.Brand.BrandName,
                    ProductName = model.ProductName,
                    Description = model.Description,
                    ProductVariants = model.ProductVariants.Select(item => new ProductVariantViewModel
                    {
                        Id = item.Id,
                        Mrp = item.Mrp,
                        Cost = item.Cost,
                        DiscountPercentage = item.DiscountPercentage,
                        Gst = item.Gst,
                        MaxPurchase = item.MaxPurchase,
                        Measure = item.Measure,
                        ProductId = item.ProductId,
                        StocksAvailable = item.StocksAvailable,
                        Volume = item.Volume
                    }).ToList()
                };
                return (T)Convert.ChangeType(_obj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem))
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.ProductName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                };
                return (T)Convert.ChangeType(returnObj, typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(model, typeof(T));
            }
        }

        public static IQueryable<Product> MapToProductEntity(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToProductEntity(model, obj));
        }

        public static Product MapToProductEntity(this BaseModel model, object obj = null)
        {
            Product product = null;
            if (model is ProductRequestVM)
            {
                var _model = (ProductRequestVM)model;
                product = new Product()
                {
                    Id = _model.Id,
                    SubCategoryId = _model.SubCategoryId,
                    BrandId = _model.BrandId,
                    ProductName = _model.ProductName,
                    ProductVariants = _model.ProductVariants == null || _model.ProductVariants.Count == 0 ? new List<ProductVariant>() :
                                 _model.ProductVariants.Select(item => new ProductVariant
                                 {
                                     Id = item.Id,
                                     Mrp = item.Mrp,
                                     Cost = item.Cost,
                                     DiscountPercentage = item.DiscountPercentage,
                                     Gst = item.Gst,
                                     MaxPurchase = item.MaxPurchase,
                                     Measure = item.Measure,
                                     ProductId = item.ProductId,
                                     StocksAvailable = item.StocksAvailable,
                                     Volume = item.Volume
                                 }).ToList(),
                    Description = _model.Description,
                    ProductImages = new List<ProductImage>(),
                    ImageUrl = string.Join(",", _model.ProductImages),
                };

                foreach (string image in _model.ProductImages)
                {
                    product.ProductImages.Add(new ProductImage() { ImageUrl = image.Replace("~/", ""), ProductId = product.Id });
                }
            }

            return product;
        }

    }
}