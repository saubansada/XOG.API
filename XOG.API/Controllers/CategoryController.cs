﻿using System.Threading.Tasks;
using System.Web.Http;
using XOG.AppCode.BLL;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.Models.ViewModels.RequestViewModels.Filters;
using XOG.AppCode.Mappers;

namespace XOG.Controllers
{
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("get-list")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public IHttpActionResult List([FromUri] CategoryFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();
              
            res.Data = new CategoryBL().GetList<CategoryViewModel>(filter);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get-select-list")]
        public IHttpActionResult GetSelectListAsync([FromUri] CategoryFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new CategoryBL().GetList<OListItem>();

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get/{id}")]
        public IHttpActionResult GetCategory(int id)
        {
            var res = new ReturnObject<CategoryViewModel>();

            res.Data = new CategoryBL().GetCategoryByNameOrId<CategoryViewModel>(id: id);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IHttpActionResult> AddAsync(CategoryRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToCategoryEntity();

            res.Data = await new CategoryBL().AddAsync(entity);
             
            res.IsSuccess = res.Data == DBStatus.Success;
             
            if(!res.IsSuccess)
            {
                return BadRequest("Error Occurred while saving");
            }

            return Ok(res);
        }

        [HttpPut]
        [Route("edit")]
        public async Task<IHttpActionResult> EditAsync(CategoryRequestVM request)
        {
            var res = new ReturnObject<DBStatus>();

            var entity = request.MapToCategoryEntity();

            res.Data = await new CategoryBL().EditAsync(entity);

            res.IsSuccess = res.Data == DBStatus.Success;

            if (!res.IsSuccess)
            {
                return BadRequest("Error Occurred while saving");
            }
             
            return Ok(res);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IHttpActionResult> DeleteAsync(int id)
        {
            var res = new ReturnObject<DBStatus>();

            res.Data = await new CategoryBL().DeleteAsync(id);

            res.IsSuccess = res.Data == DBStatus.Success;

            if (!res.IsSuccess)
            {
                string message = res.Data == DBStatus.Error ? "Error occurred while deleting!" : "Category doesn't exist!";

                return BadRequest(message);
            }

            return Ok(res);
        }
    }
}
