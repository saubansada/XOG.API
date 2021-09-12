using System;
using System.Web.Mvc;
using XOG.AppCode.BLL;
using XOG.AppCode.DAL;
using XOG.AppCode.Helpers;
using XOG.AppCode.Models.FilterModels;
using XOG.Areas.MyAdmin.Models.JsonModels;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Areas.MyAdmin.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
        public PartialViewResult UpdateUserRole(string userId)
        {
            UpdateUserRoleModel model = new UpdateUserRoleModel();
            try
            {
                using (var context = new XOGEntities())
                {

                    model.ContentModel = UsersBL.GetUserInfo(userId, context, modelType: ModelType.AdminView);

                    model.Id = ((UserAdminVM)model.ContentModel).Id;

                    model.UserRoles = UsersBL.GetRoles(userId: userId);

                    var _userRoles = ((UserAdminVM)model.ContentModel).Roles;

                    for (var i = 0; i < model.UserRoles.Count; i++)
                    {
                        if (model.UserRoles[i].Value == _userRoles[i])
                        {
                            model.UserRoles[i].Selected = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine("Error" + ex.ToString());
            }

            return PartialView(model);
        }


        /*[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
        public PartialViewResult DeleteConfirmation(DeleteModel model)
        {
            switch (model.Type)
            {
                case RecordType.Product:
                    model.contentModel = ProductBL.GetProductByNameOrId(id: model.Id, type: modelType, isAdmin: true);
                    break;

                case RecordType.Category:
                    model.contentModel = CategoryBL.GetCategoryByNameOrId(id: model.Id, type: modelType, isAdmin: true);
                    break;

                case RecordType.SubCategory:
                    model.contentModel = SubCategoryBL.GetSubCategoryByNameOrId(id: model.Id, type: modelType, isAdmin: true);
                    break;

                case RecordType.Brand:
                    model.contentModel = BrandBL.GetBrandByNameOrId(id: model.Id, type: modelType, isAdmin: true);

                    break;

                case RecordType.Order:
                    break;

                case RecordType.OrderDetail:
                    break;
            }
            return PartialView(model);
        }*/
         
        //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
        //public PartialViewResult DeleteMultipleConfirmation(DeleteMultipleModel model)
        //{
        //    switch (model.Type)
        //    {
        //        case RecordType.Product:
        //            model.contentModel = ProductBL.GetTList(filter: new ProductFilter() { Ids = model.Ids }, type: modelType, listType: ListingType.List);
        //            break;

        //        case RecordType.Category:
        //            model.contentModel = new CategoryBL().GetList(filter: new CategoryFilter() { Ids = model.Ids }, type: modelType, listType: ListingType.List);
        //            break;

        //        case RecordType.SubCategory:
        //            model.contentModel = SubCategoryBL.GetTList(filter: new SubCategoryFilter() { Ids = model.Ids }, type: modelType, listType: ListingType.List);
        //            break;

        //        case RecordType.Brand:
        //            model.contentModel = BrandBL.GetTList(filter: new BrandFilter() { Ids = model.Ids }, type: modelType, listType: ListingType.List);
        //            break;

        //        case RecordType.Order:
        //            break;

        //        case RecordType.OrderDetail:
        //            break;
        //    }
        //    return PartialView(model);
        //}

        [HttpGet]
        public JsonResult GetSelectList(RecordType recordType, short id = -1)
        {
            var jc = new JSONConfirmation();

            if (id != -1)
            {
                switch (recordType)
                {
                    case RecordType.Category:
                        {
                            jc.Message = "Error while fetching categories!";
                            CategoryFilterRequestVM filters = new CategoryFilterRequestVM();
                            filters.ProductDivision = (ProductDivision)id;
                            jc.Object = new CategoryBL().GetList<OListItem>(filter: filters, listType: ListingType.List, model: id).ToSelectList();
                        }
                        break;
                    case RecordType.SubCategory:
                        {
                            jc.Message = "Error while fetching sub-categories!";
                            SubCategoryFilter filters = new SubCategoryFilter();
                            filters.CategoryId = id;
                            jc.Object = new SubCategoryBL().GetList<OListItem>(filter: filters, type: ModelType.OListItem, listType: ListingType.List, model: id).ToSelectList();
                        }
                        break;
                    case RecordType.Division:
                        {
                            jc.Message = "Error while fetching product types!";
                            jc.Object = EnumsBL.GetProductDivisionList().ToSelectList();
                        }
                        break;

                }
                jc.IsSuccess = true;
            }
            else
            {
                jc.IsSuccess = false;
                jc.Message = "Please select the category.";
            }

            return Json(jc, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GenerateSiteMap()
        {
            var jc = new JSONConfirmation();

            if (SiteMapBL.GenerateSiteMap())
            {
                jc.IsSuccess = true;
                jc.Message = "SiteMap Generated Successfully";
            }
            else
            {
                jc.IsSuccess = false;
                jc.Message = "Some Error Occurred While Generating SiteMap!";
            }

            return Json(jc, JsonRequestBehavior.AllowGet);
        }
    }
}