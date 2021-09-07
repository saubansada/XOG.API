using System.Web.Mvc;
using XOG.Abstracts;
using XOG.AppCode.BLL;
using XOG.AppCode.Models.FilterModels;
using XOG.Areas.MyAdmin.Models.ViewModels;
using XOG.Filters;
using XOG.Models;
using XOG.Util;

namespace XOG.Areas.MyAdmin.Controllers
{
    [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
    public class OrderController : AppController
    {
        public ActionResult Index(PagerArgs args = null, OrderFilter filter = null, long detailId = -1)
        {
            //args = args == null ? new PagerArgs() : args;

            //var pageModel = new OrdersPageViewModel();

            //pageModel.filter = filter == null ? new OrderFilters() : filter;

            //args.PageSize = pageModel.filter.Limit.ToString();

            //pageModel.gridModel = Utilities.GetGridModel(args, "Id");

            //using (var context = OrderBL.GetXOGContext())
            //{
            //    pageModel.gridModel.ListData = OrderBL.GetTList(context, pageModel.filter, ModelType.AdminView, listType: ListingType.GridList, model: pageModel.gridModel);
            //}
 
            string listUrl = Url.Action("OrdersList", "Order");

            return View((object)listUrl);
        }

        public ActionResult OrdersList(PagerArgs args = null, OrderFilter filter = null, long detailId = -1)
        {
            args = args == null ? new PagerArgs() : args;

            var pageModel = new OrdersPageViewModel();

            pageModel.filter = filter == null ? new OrderFilter() : filter;

            args.PageSize = pageModel.filter.PageSize.ToString();


            pageModel.gridModel = Utilities.GetGridModel(args, "Id");

            using (var context = OrderBL.GetXOGContext())
            {
                pageModel.gridModel.ListData = OrderBL.GetTList(context, pageModel.filter, ModelType.AdminView, listType: ListingType.GridList, model: pageModel.gridModel);

            }

            return PartialView(pageModel);
        }


        public PartialViewResult OrderDetails(long detailId = -1)
        {
            var pageModel = new OrdersPageViewModel();

            if (detailId > -1)
            {
                using (var context = OrderBL.GetXOGContext())
                {

                    pageModel.detailModel = (OrderAdminVM)OrderBL.GetOrder(context, userId: CurrentUser.ID, id: detailId, modelType: ModelType.AdminView);

                }
            }
            return PartialView(pageModel);
        }
    }
}