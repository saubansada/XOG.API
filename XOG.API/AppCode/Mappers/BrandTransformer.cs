using System.Linq;
using XOG.AppCode.DAL;
using XOG.Helpers;
using XOG.Models;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.AppCode.Models;
using XOG.Util;
using XOG.Models.ViewModels;

namespace XOG.AppCode.Transformers
{
    public static class BrandTransformer
    {
        public static object TransformToBrandModelListing(this IQueryable<Brand> query, object obj = null, ModelType type = ModelType.Default, ListingType listType = ListingType.List)
        {
            if (query == null)
            {
                return null;
            }

            var _query = (IQueryable<object>)query;
              
            if (type == ModelType.AdminView)
            {
                _query = query.Select(model => new BrandAdminModel()
                {
                    Id = model.Id,
                    BrandDescription = model.BrandDescription,
                    BrandUrl = model.BrandUrl,
                    BrandName = model.BrandName
                });
            }
            else if (type == ModelType.UserView)
            {
                _query = query.Select(model => new BrandViewModel
                {
                    Id = model.Id,
                    BrandDescription = model.BrandDescription,
                    BrandUrl = model.BrandUrl,
                    BrandName = model.BrandName
                });
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return query.Select(model => new OListItem
                {
                    Text = model.BrandName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id : false
                }).ToList();
            } 

            if (listType == ListingType.Queryable)
            {
                return _query;
            }
            else if (listType == ListingType.GridList && obj != null)
            {
                _query =_query.UpdateGridModelList((GridModel)obj);
            }
            return _query.ToList();
        }

        public static object TransformToBrandModel(this Brand model, ModelType type = ModelType.Default, object obj = null)
        {
            if (type == ModelType.AdminView)
            {
                return model == null ? null : new BrandAdminModel()
                {
                    Id = model.Id,
                    BrandDescription = model.BrandDescription,
                    BrandUrl = model.BrandUrl,
                    BrandName = model.BrandName
                };
            }
            else if (type == ModelType.UserView)
            {
                return new BrandViewModel
                {
                    Id = model.Id,
                    BrandDescription = model.BrandDescription,
                    BrandUrl = model.BrandUrl,
                    BrandName = model.BrandName
                };
            }
            else if (type == ModelType.OListItem && obj.isNullOrWholeNumber())
            {
                int id = obj.NullReverse();
                return new OListItem
                {
                    Text = model.BrandName,
                    Value = model.Id.ToString(),
                    Selected = id != -1 ? model.Id == id: false
                };
            }
            else
            {
                return model;
            }
        }

        public static IQueryable<Brand> GetBrandDALQueryable(IQueryable<BaseModel> query, ModelType type = ModelType.Default, object obj = null)
        {
            return query == null ? null : query.Select(model => TransformToBrandDALObject(model, type, obj));
        }

        public static Brand TransformToBrandDALObject(this BaseModel model, ModelType type = ModelType.Default, object obj = null)
        {
            Brand Brand = null;

            if (model is BrandAdminModel)
            {
                var _model = (BrandAdminModel)model;
                Brand = new Brand()
                {
                    Id = _model.Id,
                    BrandDescription = _model.BrandDescription,
                    BrandUrl = _model.BrandUrl,
                    BrandName = _model.BrandName
                };
            }
            else if (model is BrandViewModel)
            {
                var _model = (BrandViewModel)model;
                Brand = new Brand()
                {
                    Id = _model.Id,
                    BrandDescription = _model.BrandDescription,
                    BrandUrl = _model.BrandUrl,
                    BrandName = _model.BrandName
                };
            }
            return Brand;
        }
          
    }
}