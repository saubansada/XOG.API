﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XOG.AppCode.Models;

namespace XOG.Models.ViewModels.ResponseViewModels
{
    public class UserViewModel : BaseModel
    {
        public string Id { get; set; }

        public string UserType { get; set; }

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

        public List<UserRoleVM> Roles { get; set; }

        public UserAddressVM DefaultAddress { get; set; }
    }

    public class UserRoleVM
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }

    public class UserAddressVM
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string AreaCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string LandMark { get; set; }
        public string Country { get; set; }
        public string GPS { get; set; }
        public bool IsDefault { get; set; }
    }
}