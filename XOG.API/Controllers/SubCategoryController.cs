﻿using System.Threading.Tasks;
using System.Web.Http;
using XOG.Abstracts;
using XOG.AppCode.BLL;
using XOG.AppCode.Mappers;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;

namespace XOG.Controllers
{
    [RoutePrefix("api/subcategory")]
    public class SubCategoryController : CrudApiController<SubCategoryFilterRequestVM, SubCategoryRequestVM>
    {
        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public async override Task<IHttpActionResult> List([FromUri] SubCategoryFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();
              
            res.Data = new SubCategoryBL().GetList<SubCategoryViewModel>(filter);

            res.IsSuccess = true;

            return Ok(await Task.FromResult(res));
        }

        [HttpGet]
        [Route("get-select-list")]
        public override IHttpActionResult GetSelectListAsync([FromUri] SubCategoryFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new SubCategoryBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public async override Task<IHttpActionResult> GetAsync(long id)
        {
            var res = new ReturnObject<SubCategoryViewModel>();

            res.Data = new SubCategoryBL().GetSubCategoryByNameOrId<SubCategoryViewModel>(id: id);

            res.IsSuccess = true;

            res.Result = ApiResult.Success;

            return Ok(await Task.FromResult(res));
        }

        [HttpPost]
        [Route("add")]
        public override async Task<IHttpActionResult> AddAsync(SubCategoryRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToSubCategoryEntity();

            res.Data = await new SubCategoryBL().AddAsync(entity);

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
        public override async Task<IHttpActionResult> EditAsync(SubCategoryRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToSubCategoryEntity();

            res.Data = await new SubCategoryBL().EditAsync(entity);

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

            res.Data = await new SubCategoryBL().DeleteAsync(id);

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
