namespace XOG.Areas.MyAdmin.Controllers
{
    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
    //public class CategoryController : AppController
    //{ 
    //public ActionResult Index(PagerArgs args = null, CategoryFilter filter = null, long detailId = -1)
    //{
    //    args = args == null ? new PagerArgs() : args;

    //    var pageModel = new CategoryPageViewModel();

    //    pageModel.filter = filter == null ? new CategoryFilter() : filter;

    //    args.PageSize = pageModel.filter.PageSize.ToString();

    //    pageModel.gridModel = Utilities.GetGridModel(args, "Id");

    //    using (var context = CategoryBL.GetXOGContext())
    //    {
    //        pageModel.gridModel.ListData = CategoryBL.GetList<CategoryViewModel>(context, pageModel.filter, model : pageModel.gridModel);

    //        if (detailId != -1)
    //        {
    //            pageModel.detailModel = new CategoryBL().GetCategoryByNameOrId<CategoryViewModel>(context, detailId);
    //        }
    //    }

    //    return View(pageModel);
    //}

    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
    //public ActionResult Add()
    //{
    //    CategorySaveRequestVM model = new CategorySaveRequestVM(); 

    //    model.ProductDivisionList = EnumsBL.GetProductDivisionList().ToSelectList();

    //    return View(model);
    //}

    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<JsonResult> Add(CategorySaveRequestVM model)
    //{
    //    var jc = new JSONConfirmation();

    //    jc.IsSuccess = false;

    //    jc.Message = "Some Error Occurred while Adding Category";

    //    if (ModelState.IsValid)
    //    {
    //        var category = model.TransformToCategoryDALObject();

    //        jc.IsSuccess = DBStatus.Success == await CategoryBL.AddAsync(category);

    //        jc.Message = jc.IsSuccess ? "Category Added Successfully" : jc.Message;
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
    //    CategoryAdminVM model = (CategoryAdminVM)CategoryBL.GetCategoryByNameOrId(id : id ?? -1, type : ModelType.AdminView, isAdmin: true);

    //    model.ProductDivisionList = EnumsBL.GetProductDivisionList().ToSelectList();

    //    return View(model);
    //}


    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<JsonResult> Edit(CategoryAdminVM model)
    //{
    //    var jc = new JSONConfirmation();

    //    jc.IsSuccess = false;

    //    jc.Message = "Some Error Occurred while Updating Category";

    //    if (ModelState.IsValid)
    //    {
    //        var Category = model.TransformToCategoryDALObject();

    //        jc.IsSuccess = DBStatus.Success == await CategoryBL.EditAsync(Category);

    //        jc.Message = jc.IsSuccess ? "Category Updated Successfully" : jc.Message;
    //    }
    //    else
    //    {
    //        jc.Message = "Invalid Data";
    //    }

    //    return Json(jc);
    //}

    //[OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<ActionResult> DeleteConfirmed(long id = -1, string ids = "")
    //{
    //    var jc = new JSONConfirmation();

    //    jc.Message = "Some Error Occurred while Deleting Category";

    //    if (id != -1)
    //    {
    //        jc.IsSuccess = DBStatus.Success == await CategoryBL.DeleteAsync(id);
    //        jc.Message = jc.IsSuccess ? "Category Deleted Successfully" : jc.Message;
    //    }
    //    else
    //    {
    //        jc.IsSuccess = DBStatus.Success == await CategoryBL.DeleteMultipleAsync(new CategoryFilter() { Ids = ids });
    //        jc.Message = jc.IsSuccess ? "Selected Categories Deleted Successfully" : jc.Message;
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
    //            StoragePath = LocalStorages.Storage_Category_Image_Uploads
    //        });

    //        return Json(fr);
    //    }
    //    return Json(null);
    //}
    //}
}