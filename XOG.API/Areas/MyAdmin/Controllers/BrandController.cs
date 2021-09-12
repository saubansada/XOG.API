using System.Threading.Tasks;
using System.Web.Mvc;
using XOG.AppCode.BLL;
using XOG.AppCode.Helpers;
using XOG.AppCode.Models.FilterModels;
using XOG.AppCode.Transformers;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.Filters;
using XOG.Models;
using XOG.Util;

namespace XOG.Areas.MyAdmin.Controllers
{
//    [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
//    public class BrandController : Controller
//    {
//        public ActionResult Index(PagerArgs args = null, BrandFilter filter = null, long detailId = -1)
//        {
//            args = args == null ? new PagerArgs() : args;

//            var pageModel = new BrandPageViewModel();

//            pageModel.filter = filter == null ? new BrandFilter() : filter;

//            args.PageSize = pageModel.filter.PageSize.ToString();

//            pageModel.gridModel = Utilities.GetGridModel(args, "Id");

//            using (var context = BrandBL.GetXOGContext())
//            {
//                pageModel.gridModel.ListData = BrandBL.GetTList(context, pageModel.filter, ModelType.AdminView, listType: ListingType.GridList, model: pageModel.gridModel);

//                if (detailId != -1)
//                {
//                    pageModel.detailModel = (BrandAdminModel)BrandBL.GetBrandByNameOrId(context, ModelType.AdminView, detailId);
//                }
//            }

//            return View(pageModel);
//        }


//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        public ActionResult Add()
//        {
//            BrandAdminModel model = new BrandAdminModel()
//            {
//                ProductDivisionList = EnumsBL.GetProductDivisionList().ToSelectList()
//            };

//            return View(model);
//        }
         
//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<JsonResult> Add(BrandAdminModel model)
//        {
//            var jc = new JSONConfirmation();

//            jc.IsSuccess = false;

//            jc.Message = "Some Error Occurred while Adding Brand";

//            if (ModelState.IsValid)
//            {
//                var brand = model.MapTo();

//                jc.IsSuccess = DBStatus.Success == await BrandBL.AddAsync(brand);

//                jc.Message = jc.IsSuccess ? "Brand Added Successfully" : jc.Message;
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
//            BrandAdminModel model = (BrandAdminModel)BrandBL.GetBrandByNameOrId(id: id ?? -1, type: ModelType.AdminView, isAdmin: true);

//            model.ProductDivisionList = EnumsBL.GetProductDivisionList().ToSelectList();


//            return View(model);
//        }


//        [OFAuthorize(Roles = "Developer, Admin, SubAdmin")]
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public async Task<JsonResult> Edit(BrandAdminModel model)
//        {
//            var jc = new JSONConfirmation();

//            jc.IsSuccess = false;

//            jc.Message = "Some Error Occurred while Updating Brand";

//            if (ModelState.IsValid)
//            {
//                var Brand = model.TransformToBrandDALObject();

//                jc.IsSuccess = DBStatus.Success == await BrandBL.EditAsync(Brand);

//                jc.Message = jc.IsSuccess ? "Brand Updated Successfully" : jc.Message;
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

//            jc.Message = "Some Error Occurred while Deleting Brand";

//            if (id != -1)
//            {
//                jc.IsSuccess = DBStatus.Success == await BrandBL.DeleteAsync(id);
//                jc.Message = jc.IsSuccess ? "Brand Deleted Successfully" : jc.Message;
//            }
//            else
//            {
//                jc.IsSuccess = DBStatus.Success == await BrandBL.DeleteMultipleAsync(new BrandFilter() { Ids = ids });
//                jc.Message = jc.IsSuccess ? "Selected Categories Deleted Successfully" : jc.Message;
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
//                    StoragePath = LocalStorages.Storage_Brand_Image_Uploads
//                });

//                return Json(fr);
//            }
//            return Json(null);
//        }
//    }
}