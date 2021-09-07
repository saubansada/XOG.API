using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XOG.AppCode.Models;
using XOG.AppCode.Models.FilterModels;
using XOG.Models;

namespace XOG.Areas.MyAdmin.Models.ViewModels
{
    public class UserAdminVM : BaseModel
    {
        public string Id { get; set; } = "";

        [Required(ErrorMessage = "RequiredEmail")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "InvalidEmailID")] //Key in Languages.xml
        public string Email { get; set; }

        [Required(ErrorMessage = "RequiredFirstName")]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "NoNumbersFirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "RequiredLastName")]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "NoNumbersLastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "RequiredPhoneNumber")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Mobile")]
        [MinLength(8, ErrorMessage = "MinLengthPhoneNumber")]
        [MaxLength(15, ErrorMessage = "MaxLengthPhoneNumber")]
        [RegularExpression(@"^(\+|-)?\d+$", ErrorMessage = "InvalidPhoneNumber")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "RequiredPassword")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(6, ErrorMessage = "MinLengthPassword")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [System.ComponentModel.DataAnnotations.Compare(nameof(Password), ErrorMessage = "PasswordsDontMatch")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please Select the Role")]
        [Display(Name = "User Role")]
        public string UserType { get; set; }

        public List<string> Roles { get; set; }

        public List<SelectListItem> UserRoles { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool EmailConfirmed { get; set; }

        public bool LockedOutEnabled { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public string AlternateMobileNumber { get; set; }

    }

    public class UsersPageViewModel
    {

        public UserFilter filter { get; set; }

        public GridModel gridModel { get; set; }

        public UserAdminVM detailModel { get; set; } = new UserAdminVM();
    }

}