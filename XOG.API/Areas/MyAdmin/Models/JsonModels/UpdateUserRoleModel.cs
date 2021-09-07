using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XOG.Models;

namespace XOG.Areas.MyAdmin.Models.JsonModels
{
    public class UpdateUserRoleModel
    {
        public string Id { get; set; }

        public List<OListItem> UserRoles { get; set; }

        public object ContentModel { get; set; }
    }
}