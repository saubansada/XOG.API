using System.Threading.Tasks;
using System.Web.Http;
using XOG.Abstracts;
using XOG.AppCode.BLL;
using XOG.AppCode.Mappers;
using XOG.AppCode.Models.FilterModels;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Controllers
{
    [RoutePrefix("api/productgroup")]
    public class ProductGroupController : CrudApiController<ProductGroupFilterRequestVM, ProductGroupRequestVM>
    {
        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async override Task<IHttpActionResult> List([FromUri] ProductGroupFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();
              
            res.Data = new ProductGroupBL().GetList<ProductGroupViewModel>((IProductGroupFilter)filter);

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }

        [HttpGet]
        [Route("get-select-list")]
        public override IHttpActionResult GetSelectListAsync([FromUri] ProductGroupFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new ProductGroupBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public async override Task<IHttpActionResult> GetAsync(long id)
        {
            var res = new ReturnObject<ProductGroupViewModel>();

            res.Data = new ProductGroupBL().GetProductGroupByNameOrId<ProductGroupViewModel>(id: id);

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }

        [HttpPost]
        [Route("add")]
        public override async Task<IHttpActionResult> AddAsync(ProductGroupRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToProductGroupEntity();

            res.Data = await new ProductGroupBL().AddAsync(entity);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Saved Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                return BadRequest("Error Occurred while saving");
            }

            return Ok(res);
        }

        [HttpPut]
        [Route("edit")]
        public override async Task<IHttpActionResult> EditAsync(ProductGroupRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToProductGroupEntity();

            res.Data = await new ProductGroupBL().EditAsync(entity);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Saved Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                return BadRequest("Error Occurred while saving");
            }

            return Ok(res);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public override async Task<IHttpActionResult> DeleteAsync(int id)
        {
            var res = new ReturnObject<DBStatus>();

            res.Data = await new ProductGroupBL().DeleteAsync(id);

            res.IsSuccess = res.Data == DBStatus.Success;

            res.Result = ApiResult.Success;

            res.Message = "Deleted Successfully!";

            if (!res.IsSuccess)
            {
                res.Result = ApiResult.Failure;

                string message = res.Data == DBStatus.Error ? "Error occurred while deleting!" : "Category doesn't exist!";

                return BadRequest(message);
            }

            return Ok(res);
        }
    }
}
