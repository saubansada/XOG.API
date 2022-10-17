using System.Threading.Tasks;
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
    [RoutePrefix("api/deliverytimings")]
    public class DeliveryTimingsController : CrudApiController<DeliveryTimingsFilterRequestVM, WeekDayStatusRequestVM>
    {
        [HttpPost]
        [Route("add")]
        public override async Task<IHttpActionResult> AddAsync(WeekDayStatusRequestVM request)
        {
            ReturnObject<DBStatus> obj = new ReturnObject<DBStatus>();

            var delivereyTiming = request.MapToDeliveryTimingEntity();

            var res = new DeliveryTimingBL().AddAsync(delivereyTiming);

            obj.Data = await res;

            return Ok(obj);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public override Task<IHttpActionResult> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        [HttpPut]
        [Route("edit")]
        public override async Task<IHttpActionResult> EditAsync(WeekDayStatusRequestVM request)
        {
            ReturnObject<DBStatus> obj = new ReturnObject<DBStatus>();

            var delivereyTiming = request.MapToDeliveryTimingEntity();

            var res = new DeliveryTimingBL().EditAsync(delivereyTiming);

            obj.Data = await res;

            return Ok(obj);
        }

        [HttpGet]
        [Route("get/{id}")]
        public override IHttpActionResult Get(int id)
        {
            throw new System.NotImplementedException();
        }

        [HttpGet]
        [Route("get-select-list")]
        public override IHttpActionResult GetSelectListAsync([FromUri] DeliveryTimingsFilterRequestVM filter)
        {
            var res = new ReturnObject<object>();

            res.Data = new DeliveryTimingBL().GetList<OListItem>(filter);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpGet]
        [Route("get-list")]
        public override IHttpActionResult List([FromUri] DeliveryTimingsFilterRequestVM filter)
        {

            var res = new ReturnObject<object>();

            res.Data = new DeliveryTimingBL().GetList<WeekDayStatusRequestVM>(filter);

            res.IsSuccess = true;

            return Ok(res);
        }
    }

}
