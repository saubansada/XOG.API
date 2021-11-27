using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using XOG.Filters;
using XOG.Models;
using XOG.Models.ViewModels.RequestViewModels.Data;
using XOG.SettingsHelpers;

namespace XOG.Controllers
{
    [RoutePrefix("api/settings")]
    public class SettingsController : ApiController
    {
        [HttpGet]
        [Route("get/{name}")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public IHttpActionResult GetSettings(string name)
        {
            var res = new ReturnObject<string>();

            if (!KeywordsHelper.IsKeywordPresent(name))
            {
                KeywordsHelper.AddKeyword(name, "");
            }

            res.Data = KeywordsHelper.GetKeywordValueFromSettings(name);

            res.IsSuccess = true;

            return Ok(res);
        }

        [HttpPost]
        [Route("save/{name}")]
        [OFAuthorize(Roles = "Developer, Admin, SubAdmin, Staff")]
        public IHttpActionResult SaveTaxes(string name, SettingsVM model)
        {
            var res = new ReturnObject<bool>();

            if (!KeywordsHelper.AddKeyword(name, model.Taxes))
            {
                KeywordsHelper.SetKeywordValueToSettings(name, model.Taxes);
            }

            res.Data = true;

            return Ok(res);
        }
    }
}