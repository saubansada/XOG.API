using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class CustomerSaveRequestVM
    {
        public int CustomerId { get;set;} 

        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Phone { get; set; }

        public string Email { get; set; }
          
        public string City { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; internal set; }
    }
}