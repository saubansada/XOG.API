﻿using System.ComponentModel.DataAnnotations;

namespace XOG.Models.ViewModels.RequestViewModels.Data
{
    public class SupplierSaveRequestVM
    {
        public int SupplierId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Company { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; internal set; }
    }
}