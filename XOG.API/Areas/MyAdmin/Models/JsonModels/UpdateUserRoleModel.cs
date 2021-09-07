using System.Collections.Generic;
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