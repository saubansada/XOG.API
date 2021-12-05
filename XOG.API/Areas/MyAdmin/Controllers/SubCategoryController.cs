//using System.Threading.Tasks;
//using System.Web.Mvc;
//using XOG.AppCode.BLL;
//using XOG.AppCode.Helpers;
//using XOG.AppCode.Models.FilterModels;
//using XOG.Filters;
//using XOG.Models;
//using XOG.Util;

//namespace XOG.Areas.MyAdmin.Controllers
//{
//    [OFAuthorize(Roles = "Developer, Admin, Staff")]
//    public class SubCategoryController : Controller
//    {
//        public ActionResult Index(PagerArgs args = null, SubCategoryFilter filter = null, long detailId = -1)
//        {
//            args = args == null ? new PagerArgs() : args;

//            var pageModel = new SubCategoryPageViewModel();

//            pageModel.filter = filter == null ? new SubCategoryFilter() : filter;
              
//            args.PageSize = filter.PageSize.ToString();

//            pageModel.gridModel = Utilities.GetGridModel(args, "Id");

//            using (var context = SubCategoryBL.GetXOGContext())
//            {
//                pageModel.gridModel.ListData = SubCategoryBL.GetTList(context, filter, type: ModelType.AdminView, model: pageModel.gridModel);

//                if (detailId != -1)
//                {
//                    pageModel.detailModel = (SubCategoryVM)SubCategoryBL.GetSubCategoryByNameOrId(context, type: ModelType.AdminView, id: detailId, isAdmin:true);
//                }
//            }

//            return View(pageModel);
//        }

//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        public ActionResult Add(short SubCategory = -1)
//        {
//            SubCategoryVM model = new SubCategoryVM();

//            model.CategoryList = new CategoryBL().GetList<OListItem>(listType: ListingType.List, model: SubCategory).ToSelectList();

//            var categorylist = model.CategoryList;

//            model.CategoryId = SubCategory;

//            return View(model);
//        }

//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<JsonResult> Add(SubCategoryVM model)
//        {
//            var jc = new JSONConfirmation();

//            jc.IsSuccess = false;

//            jc.Message = "Some Error Occurred while Adding Sub Category";

//            if (ModelState.IsValid)
//            {
//                var subCategory = model.TransformToSubCategoryDALObject();

//                jc.IsSuccess = DBStatus.Success == await SubCategoryBL.AddAsync(subCategory);

//                jc.Message = jc.IsSuccess ? "Sub-Category Added Successfully" : jc.Message;
//            }
//            else
//            {

//                jc.Message = "Invalid Data";
//            }

//            return Json(jc);
//        }

//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        public ActionResult Edit(long? id)
//        {
//            SubCategoryVM model = (SubCategoryVM)SubCategoryBL.GetSubCategoryByNameOrId(id: id ?? -1, type: ModelType.AdminView, isAdmin: true);

//            model.CategoryList = new CategoryBL().GetList<OListItem>(listType: ListingType.List).ToSelectList();

//            return View(model);
//        }

//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<JsonResult> Edit(SubCategoryVM model)
//        {
//            var jc = new JSONConfirmation();

//            jc.IsSuccess = false;

//            jc.Message = "Some Error Occurred while Updating Sub-Category";

//            if (ModelState.IsValid)
//            {
//                var SubCategory = model.TransformToSubCategoryDALObject();

//                jc.IsSuccess = DBStatus.Success == await SubCategoryBL.EditAsync(SubCategory);

//                jc.Message = jc.IsSuccess ? "Sub-Category Updated Successfully" : jc.Message;
//            }
//            else
//            {
//                jc.Message = "Invalid Data";
//            }

//            return Json(jc);
//        }

//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> DeleteConfirmed(long id = -1, string ids = "")
//        {
//            var jc = new JSONConfirmation();

//            jc.Message = "Some Error Occurred while Delete Sub Category";

//            if (id != -1)
//            {
//                jc.IsSuccess = DBStatus.Success == await SubCategoryBL.DeleteAsync(id);
//                jc.Message = jc.IsSuccess ? "Sub Category Delete Successfully" : jc.Message;
//            }
//            else
//            {
//                jc.IsSuccess = DBStatus.Success == await SubCategoryBL.DeleteMultipleAsync(new SubCategoryFilter() { Ids = ids });
//                jc.Message = jc.IsSuccess ? "Selected Sub Categories Delete Successfully" : jc.Message;
//            }
             
//            return Json(jc);
//        }

//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        [HttpPost]
//        public JsonResult UploadFile()
//        {
//            FileUploadResult fr = null;

//            if (Request.Files.Count > 0)
//            {
//                var image = Request.Files[0];

//                fr = Utilities.UploadFile(image, new FileUploadSettings
//                {
//                    FileType = FileType.Image,
//                    MaxSize = 5,
//                    StoragePath = LocalStorages.Storage_Sub_Category_Image_Uploads
//                });

//                return Json(fr);
//            }
//            return Json(null);
//        }
         
//    }
//}