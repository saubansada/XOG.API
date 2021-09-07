using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class SubCategoryViewModel : BaseModel
    {
        public short Id { get; set; }

        public string RouteKey { get; set; }

        public short CategoryId { get; set;  }

        public List<SelectListItem> Categories { get; set; }

        public string SubCategoryDescription { get; set; }
         
        public string SubCategoryName { get; set; }
    } 
}