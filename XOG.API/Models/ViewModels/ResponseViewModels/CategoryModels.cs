using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels
{
    public class CategoryViewModel : BaseModel
    {
        public short Id { get; set; }

        public string RouteKey { get; set; }

        public ProductDivision ProductDivision { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
    }

}