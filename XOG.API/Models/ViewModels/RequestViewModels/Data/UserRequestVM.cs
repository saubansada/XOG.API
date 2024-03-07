using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class UserRequestVM : BaseModel
    {
        public string Id { get; set; }

        public UserType UserType { get; set; }

        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public string AlternateMobileNumber { get; set; }
         
        public List<string> RoleIds { get; set; }
    } 
}