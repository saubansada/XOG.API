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
    public static class ProductVariantMapper
    {
        public static object MapToProductVariantModelList<T>(this IQueryable<ProductVariant> query, object obj = null, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;

            if (typeof(T) == typeof(ProductVariantViewModel))
            {
                _query = query.Select(model => new ProductVariantViewModel
                {
                    Id = model.Id,
                    Mrp = model.Mrp,
                    Cost = model.Cost,
                    DiscountPercentage = model.DiscountPercentage,
                    Gst = model.Gst,
                    MaxPurchase = model.MaxPurchase,
                    MeasureName = model.QuantityMeasure.Acronym,
                    MeasureId = model.MeasureId,
                    ProductId = model.ProductId,
                    StocksAvailable = model.StocksAvailable,
                    Volume = model.Volume,
                    HSNCode = model.HSNCode,
                    Price = (model.Mrp - (model.Mrp * model.DiscountPercentage / 100)),
                    Product = new ProductViewModel
                    {
                        Id = model.Product.Id,
                        CategoryName = model.Product.SubCategory.Category.CategoryName,
                        SubCategoryId = model.Product.SubCategoryId,
                        ProductCode = model.Product.ProductCode,
                        SubCategoryName = model.Product.SubCategory.SubCategoryName,
                        BrandId = model.Product.BrandId,
                        BrandName = model.Product.Brand.BrandName,
                        ProductName = model.Product.ProductName,
                        Description = model.Product.Description,
                        ProductGroupId = model.Product.ProductGroupId ?? -1,
                        ProductImages = model.Product.ProductImages.Select(i => i.ImageUrl).ToList(),
                    }
                });
            }
            else if (typeof(T) == typeof(OListItem) && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.Product.ProductName + " - " + model.Volume + " " + model.QuantityMeasure.Acronym,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).ToList();
            }
            else if (typeof(T) == typeof(string[]))
            {
                int id = obj.NullReverse();
                return query.Select(model => model.Product.ProductName).ToArray();
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

        public static T MapToProductVariantModel<T>(this ProductVariant model, object obj = null)
        {
            if (typeof(T) == typeof(ProductVariantViewModel))
            {
                var _obj = new ProductVariantViewModel
                {
                    Id = model.Id,
                    Mrp = model.Mrp,
                    Cost = model.Cost,
                    DiscountPercentage = model.DiscountPercentage,
                    Gst = model.Gst,
                    MaxPurchase = model.MaxPurchase,
                    MeasureName = model.QuantityMeasure.Acronym,
                    MeasureId = model.MeasureId,
                    ProductId = model.ProductId,
                    StocksAvailable = model.StocksAvailable,
                    Volume = model.Volume,
                    HSNCode = model.HSNCode,
                    Price = (model.Mrp - (model.Mrp * model.DiscountPercentage / 100)),
                    Product = new ProductViewModel
                    {
                        Id = model.Product.Id,
                        CategoryName = model.Product.SubCategory.Category.CategoryName,
                        SubCategoryId = model.Product.SubCategoryId,
                        ProductCode = model.Product.ProductCode,
                        SubCategoryName = model.Product.SubCategory.SubCategoryName,
                        BrandId = model.Product.BrandId,
                        BrandName = model.Product.Brand.BrandName,
                        ProductName = model.Product.ProductName,
                        Description = model.Product.Description,
                        ProductGroupId = model.Product.ProductGroupId ?? -1,
                        ProductImages = model.Product.ProductImages.Select(i => i.ImageUrl).ToList(),
                    }
                };
                return (T)Convert.ChangeType(_obj, typeof(T));
            }
            else if (typeof(T) == typeof(OListItem))
            {
                int id = obj.NullReverse();
                var returnObj = new OListItem
                {
                    Text = model.Product.ProductName + " - " + model.Volume + " " + model.QuantityMeasure.Acronym,
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

        public static IQueryable<ProductVariant> MapToProductVariantEntity(IQueryable<BaseModel> query, object obj = null)
        {
            return query == null ? null : query.Select(model => MapToProductVariantEntity(model, obj));
        }

        public static ProductVariant MapToProductVariantEntity(this BaseModel model, object obj = null)
        {
            ProductVariant product = null;
            if (model is ProductVariantRequestVM)
            {
                var _model = (ProductVariantRequestVM)model;
                product = new ProductVariant()
                {
                    Id = _model.Id,
                    Mrp = _model.Mrp,
                    Cost = _model.Cost,
                    DiscountPercentage = _model.DiscountPercentage,
                    Gst = _model.Gst,
                    MaxPurchase = _model.MaxPurchase,
                    MeasureId = _model.MeasureId,
                    ProductId = _model.ProductId,
                    StocksAvailable = _model.StocksAvailable,
                    Volume = _model.Volume,
                    HSNCode = _model.HSNCode,
                };
            }

            return product;
        }

    }
}