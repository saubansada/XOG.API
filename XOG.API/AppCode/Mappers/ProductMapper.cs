using System;
using System.Collections.Generic;
using System.Linq;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Util;

namespace XOG.AppCode.Mappers
{
    public static class ProductMapper
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
                    ProductCode = model.ProductCode,
                    SubCategoryName = model.SubCategory.SubCategoryName,
                    BrandId = model.BrandId,
                    BrandName = model.Brand.BrandName,
                    ProductName = model.ProductName,
                    Description = model.Description,
                    ProductGroupId = model.ProductGroupId ?? -1,
                    ProductImages = model.ProductImages.Select(i => i.ImageUrl).ToList(),
                    ProductVariants = model.ProductVariants.Select(item => new ProductVariantViewModel
                    {
                        Id = item.Id,
                        Mrp = item.Mrp,
                        Cost = item.Cost,
                        DiscountPercentage = item.DiscountPercentage,
                        Gst = item.Gst,
                        MaxPurchase = item.MaxPurchase,
                        MeasureName = item.QuantityMeasure.Acronym,
                        MeasureId = item.MeasureId,
                        ProductId = item.ProductId,
                        StocksAvailable = item.StocksAvailable,
                        Volume = item.Volume,
                        HSNCode = item.HSNCode,
                        Price = (item.Mrp - (item.Mrp * item.DiscountPercentage / 100))
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
                    ProductCode = model.ProductCode,
                    CategoryName = model.SubCategory.Category.CategoryName,
                    SubCategoryId = model.SubCategoryId,
                    SubCategoryName = model.SubCategory.SubCategoryName,
                    BrandId = model.BrandId,
                    ProductGroupId = model.ProductGroupId ?? -1,
                    BrandName = model.Brand.BrandName,
                    ProductName = model.ProductName,
                    Description = model.Description,
                    ProductImages = model.ProductImages.Select(item => item.ImageUrl).ToList(),
                    ProductVariants = model.ProductVariants.Select(item => new ProductVariantViewModel
                    {
                        Id = item.Id,
                        Mrp = item.Mrp,
                        Cost = item.Cost,
                        DiscountPercentage = item.DiscountPercentage,
                        Gst = item.Gst,
                        MaxPurchase = item.MaxPurchase,
                        MeasureName = item.QuantityMeasure.Acronym,
                        MeasureId = item.MeasureId,
                        ProductId = item.ProductId,
                        StocksAvailable = item.StocksAvailable,
                        Volume = item.Volume,
                        HSNCode = item.HSNCode,
                        Price = (item.Mrp - (item.Mrp * item.DiscountPercentage / 100)),
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
                    ProductCode = _model.ProductCode,
                    ProductName = _model.ProductName,
                    ProductGroupId = _model.ProductGroupId,
                    Enabled = _model.Enabled,
                    ProductVariants = _model.ProductVariants == null || _model.ProductVariants.Count == 0 ? new List<ProductVariant>() :
                                 _model.ProductVariants.Select(item => new ProductVariant
                                 {
                                     Id = item.Id,
                                     Mrp = item.Mrp,
                                     Cost = item.Cost,
                                     DiscountPercentage = item.DiscountPercentage,
                                     Gst = item.Gst,
                                     MaxPurchase = item.MaxPurchase,
                                     MeasureId = item.MeasureId,
                                     ProductId = item.ProductId,
                                     StocksAvailable = item.StocksAvailable,
                                     Volume = item.Volume,
                                     HSNCode = item.HSNCode, 
                                 }).ToList(),
                    Description = _model.Description,
                    ProductImages = new List<ProductImage>(),
                    ImageUrl = string.Join(",", _model.ProductImages ?? new List<string>()),
                };

                if (_model.ProductImages != null && _model.ProductImages.Count > 0)
                {
                    foreach (string image in _model.ProductImages)
                    {
                        product.ProductImages.Add(new ProductImage() { ImageUrl = image, ProductId = product.Id });
                    }
                }
            }

            return product;
        }

    }
}