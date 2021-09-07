using System.Collections.Generic;
using System.Linq;
using XOG.AppCode.DAL;
using XOG.AppCode.Models;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.Helpers;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Util;

namespace XOG.AppCode.Transformers
{
    public static class ProductTransformer
    {   
        public static object TransformToProductModelListing(this IQueryable<Product> query, object obj = null, ModelType type = ModelType.Default, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;
            
            if (type == ModelType.AdminView)
            {
                _query = query.Select(model => new ProductAdminVM()
                {
                    Id = model.Id,
                    SubCategoryId = model.SubCategoryId,
                    BrandId = model.BrandId,
                    ProductName = model.ProductName,
                    Mrp = model.Mrp,
                    Measure = (MeasureType)model.Measure,
                    Gst = model.Gst,
                    Cost = model.Cost,
                    Volume = model.Volume,
                    StocksAvailable = model.StocksAvailable,
                    DiscountPercentage = model.DiscountPercentage,
                    Description = model.Description,
                    ProductImage = model.ProductImages.Select(i => i.ImageUrl).ToList(),
                    Enabled = model.Enabled,
                    MaxPurchase = model.MaxPurchase
                });
            }
            else if (type == ModelType.UserView)
            {
                _query = query.Select(model => new ProductViewModel
                {
                    Id = model.Id,
                    SubCategoryId = model.SubCategoryId,
                    SubCategoryName = model.SubCategory.SubCategoryName,
                    BrandId = model.BrandId,
                    BrandName = model.Brand.BrandName,
                    ProductName = model.ProductName,
                    Mrp = model.Mrp,
                    Measure = model.Measure,
                    Gst = model.Gst,
                    Volume = model.Volume,
                    Cost = model.Cost,
                    StocksAvailable = model.StocksAvailable,
                    DiscountPercentage = model.DiscountPercentage,
                    Description = model.Description,
                    ProductImages = model.ProductImages.Select(i => i.ImageUrl).ToList(),
                    MaxPurchase = model.MaxPurchase
                });
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.ProductName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).ToList();
            } 
            else if (type == ModelType.NameArray)
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
         
        public static object TransformToProductModel(this Product model, ModelType type = ModelType.Default, object obj = null)
        {
            if (type == ModelType.AdminView)
            {
                return model == null ? null : new ProductAdminVM()
                {
                    Id = model.Id,
                    CategoryId = model.SubCategory.Category.Id, 
                    SubCategoryId = model.SubCategoryId,
                    BrandId = model.BrandId,
                    ProductName = model.ProductName,
                    Mrp = model.Mrp,
                    Measure = (MeasureType)model.Measure,
                    Gst = model.Gst,
                    Cost = model.Cost,
                    Volume = model.Volume,
                    StocksAvailable = model.StocksAvailable,
                    DiscountPercentage = model.DiscountPercentage,
                    Description = model.Description,
                    ProductImage = model.ProductImages.Select(i => i.ImageUrl).ToList(),
                    Enabled = model.Enabled,
                    MaxPurchase = model.MaxPurchase
                };
            }
            else if (type == ModelType.UserView)
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
                    Mrp = model.Mrp,
                    Measure = model.Measure,
                    Gst = model.Gst,
                    Volume = model.Volume,
                    Cost = model.Cost,
                    ProductImages = model.ProductImages.Select(i => i.ImageUrl).ToList(),
                    StocksAvailable = model.StocksAvailable,
                    DiscountPercentage = model.DiscountPercentage,
                    Description = model.Description,
                    MaxPurchase = model.MaxPurchase
                }; 
                return _obj;
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return new OListItem
                {
                    Text = model.ProductName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                };
            }
            else
            { 
                return model;
            }
        }
          
        public static IQueryable<Product> GetProductDALQueryable(IQueryable<BaseModel> query, ModelType type = ModelType.Default, object obj = null)
        {
            return query == null ? null : query.Select(model => TransformToProductDALObject(model, type, obj));
        }

        public static Product TransformToProductDALObject(this BaseModel model, ModelType type = ModelType.Default, object obj = null)
        {
            Product product = null;

            if (model is ProductAdminVM)
            {
                var _model = (ProductAdminVM)model;
                //_model.ProductImage = _model.ProductImage.Substring(_model.ProductImage.LastIndexOf('/') + 1, _model.ProductImage.Length);
                product = new  Product()
                {
                    Id = _model.Id,
                    SubCategoryId = _model.SubCategoryId,
                    BrandId = _model.BrandId,
                    ProductName = _model.ProductName,
                    Mrp = _model.Mrp,
                    Measure = (short)_model.Measure,
                    Volume = _model.Volume.ToString(),
                    Gst = _model.Gst,
                    Cost = _model.Cost, 
                    StocksAvailable = _model.StocksAvailable,
                    DiscountPercentage = _model.DiscountPercentage,
                    Description = _model.Description,
                    Enabled = _model.Enabled,
                    MaxPurchase = _model.MaxPurchase
                }; 
                foreach (string image in _model.ProductImage)
                {
                    product.ProductImages.Add(new ProductImage() { ImageUrl = image.Replace("~/", ""), ProductId = product.Id });
                }
            }
            else if (model is ProductViewModel)
            {
                var _model = (ProductViewModel)model; 
                product = new Product()
                {
                    Id = _model.Id,
                    SubCategoryId = _model.SubCategoryId,
                    BrandId = _model.BrandId, 
                    ProductName = _model.ProductName,
                    Mrp = _model.Mrp,
                    Measure = (short)_model.Measure,
                    Volume = _model.Volume.ToString(),
                    Gst = _model.Gst, 
                    Cost = _model.Cost,
                    StocksAvailable = _model.StocksAvailable,
                    DiscountPercentage = _model.DiscountPercentage,
                    Description = _model.Description,
                    ProductImages = new List<ProductImage>(),
                    ImageUrl = string.Join(",", _model.ProductImages),
                    MaxPurchase = _model.MaxPurchase
                };

                foreach(string image in _model.ProductImages) {
                    product.ProductImages.Add(new ProductImage() { ImageUrl = image.Replace("~/", ""), ProductId = product.Id });
                }

            }

            return product; 
        }
         
    }
}