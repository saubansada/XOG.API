using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using XOG.AppCode.BLL;
using XOG.AppCode.DAL;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.AppCode.Models.FilterModels;
using XOG.Util;
using XOG.Models;
using XOG.AppCode.Helpers;
using System.Threading.Tasks;
using XOG.AppCode.Transformers;
using XOG.Models.ViewModels;
using XOG.Filters;
using System.Web.Http;

//namespace XOG.Areas.MyAdmin.Controllers
//{
    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")] 
    //public class ProductController : ApiController
    //{
    //    [HttpGet]
    //    public IHttpActionResult GetList()
    //    {
        //    args = args ?? new PagerArgs();

        //    var pageModel = new ProductsPageViewModel
        //    {
        //        filter = filter ?? new ProductFilter()
        //    };

        //    pageModel.filter.Enabled = false;
             
        //    args.PageSize = pageModel.filter.PageSize.ToString();

        //    pageModel.gridModel = Utilities.GetGridModel(args, "Id");

        //    using (var context = ProductBL.GetXOGContext())
        //    {
        //        pageModel.gridModel.ListData = ProductBL.GetTList(context, pageModel.filter, ModelType.AdminView, 
        //                    ListingType.GridList, pageModel.gridModel);
        //    }

     //       return Json("hello");
    //}

    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")] 
    //public ActionResult Add()
    //{
    //    ProductAdminVM model = new ProductAdminVM
    //    {
    //        BrandList = BrandBL.GetTList(type: ModelType.OListItem, listType: ListingType.List).ToSelectList(),

    //        ProductDivisionList = EnumsBL.GetProductDivisionList().ToSelectList(),

    //        CategoryList = SelectListHelper.ToSelectList(null, hasSelect: true, isSelectEnabled: false),

    //        SubCategoryList = SelectListHelper.ToSelectList(null, hasSelect: true, isSelectEnabled: false),

    //        MeasureList = EnumsBL.GetMeasureList().ToSelectList()
    //    };

    //    return View(model);
    //}

    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
    //[HttpPost]
    //[ValidateAntiForgeryToken] 
    //public async Task<JsonResult> Add(ProductAdminVM model)
    //{
    //    var jc = new JSONConfirmation
    //    {
    //        IsSuccess = false,

    //        Message = "Some Error Occurred while Adding Product"
    //    };

    //    if (ModelState.IsValid)
    //    {
    //        var product = model.TransformToProductDALObject();

    //        jc.IsSuccess = DBStatus.Success == await ProductBL.AddAsync(product);

    //        jc.Message = jc.IsSuccess ? "Product Added Successfully" : jc.Message;
    //    }
    //    else
    //    {

    //        jc.Message = "Invalid Data";
    //    }

    //    return Json(jc);
    //}

    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
    //public ActionResult Edit(long? id)
    //{
    //    ProductAdminVM model = (ProductAdminVM)ProductBL.GetProductByNameOrId(type: ModelType.AdminView, id: id ?? -1, isAdmin: true);

    //    model.BrandList = (List<SelectListItem>)BrandBL.GetTList(type : ModelType.OListItem, listType: ListingType.List).ToSelectList();

    //    model.ProductDivisionList = EnumsBL.GetProductDivisionList().ToSelectList();

    //    model.CategoryList = CategoryBL.GetTList(filter: new CategoryFilter() { ProductDivision = model.ProductDivision }, type: ModelType.OListItem, listType: ListingType.List, model: model.CategoryId).ToSelectList(hasSelect: true, value : "" + model.CategoryId);

    //    model.SubCategoryList = SubCategoryBL.GetTList(filter: new SubCategoryFilter() { CategoryId = model.CategoryId }, type: ModelType.OListItem, listType: ListingType.List, model: model.SubCategoryId).ToSelectList(hasSelect: true, value : "" + model.SubCategoryId );

    //    model.MeasureList = EnumsBL.GetMeasureList().ToSelectList();

    //    return View(model);
    //}

    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")] 
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<JsonResult> Edit(ProductAdminVM model)
    //{ 
    //    var jc = new JSONConfirmation
    //    {
    //        Message = "Some Error Occurred while Updating Product"
    //    };

    //    if (ModelState.IsValid)
    //    {
    //        var product = model.TransformToProductDALObject();

    //        jc.IsSuccess = DBStatus.Success == await ProductBL.EditAsync(product);

    //        jc.Message = jc.IsSuccess ? "Product Updated Successfully" : jc.Message;
    //    }
    //    else
    //    { 
    //        jc.Message = "Invalid Data";
    //    }

    //    return Json(jc);
    //}

    //[OFAuthorize(Roles = "Developer, Admin")]
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<ActionResult> DeleteConfirmed(long id = -1, string ids = "")
    //{
    //    var jc = new JSONConfirmation
    //    {
    //        Message = "Some Error Occurred while Delete Product"
    //    };

    //    if (id != -1)
    //    {
    //        jc.IsSuccess = DBStatus.Success == await ProductBL.DeleteAsync(id);
    //        jc.Message = jc.IsSuccess ? "Product Delete Successfully" : jc.Message;
    //    }
    //    else {
    //        jc.IsSuccess = DBStatus.Success == await ProductBL.DeleteMultipleAsync(new ProductFilter() { Ids = ids });
    //        jc.Message = jc.IsSuccess ? "Selected Products Delete Successfully" : jc.Message;
    //    }


    //    return Json(jc);
    //}

    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
    //[HttpPost]
    //public JsonResult UploadFile()
    //{
    //    FileUploadResult fr = null;

    //    if (Request.Files.Count > 0)
    //    {
    //        var image = Request.Files[0];

    //        fr = Utilities.UploadFile(image, new FileUploadSettings
    //        {
    //            FileType = FileType.Image,
    //            MaxSize = 5,
    //            StoragePath = LocalStorages.Storage_Product_Image_Uploads
    //        });

    //        return Json(fr);
    //    }
    //    return Json(null);
    //}

//}
//}
