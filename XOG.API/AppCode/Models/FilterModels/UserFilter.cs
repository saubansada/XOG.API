using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XOG.AppCode.Models.FilterModels
{
    public class UserFilter : BaseFilter
    {
        public string Search { get; set; }

        public UserType UserType { get; set; } = UserType.Any;

        public bool Enabled { get; set; } = true;
    }
}