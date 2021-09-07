using System.Threading.Tasks;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.AppCode.Transformers;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Controllers
{
    [RoutePrefix("api/subcategory")]
    public class SubCategoryController : ApiController
    {
        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public IHttpActionResult List([FromUri] SubCategoryFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();
              
            res.Data = new SubCategoryBL().GetList<SubCategoryViewModel>(filter);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get-select-list")]
        public IHttpActionResult GetSelectListAsync([FromUri] SubCategoryFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new SubCategoryBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public IHttpActionResult GetA(int id)
        {
            var res = new ReturnObject<SubCategoryViewModel>();

            res.Data = new SubCategoryBL().GetSubCategoryByNameOrId<SubCategoryViewModel>(id: id);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> AddAsync(SubCategoryRequestVM request)
        {
            var res = new ReturnObject<object>();

            var entity = request.MapToSubCategoryEntity<SubCategoryRequestVM>();

            res.Data = await new SubCategoryBL().AddAsync(entity);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpPut]
        [Route("edit")]
        public async Task<IHttpActionResult> EditAsync(SubCategoryRequestVM request)
        {
            var res = new ReturnObject<object>();

            var entity = request.MapToSubCategoryEntity<SubCategoryRequestVM>();

            res.Data = await new SubCategoryBL().EditAsync(entity);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IHttpActionResult> DeleteAsync(int id)
        {
            var res = new ReturnObject<object>();

            res.Data = await new SubCategoryBL().DeleteAsync(id);

            res.IsSuccess = true;

            return Ok(res);
        }
    }
}
