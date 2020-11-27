using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finanzas.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        [StringLength(12)]
        public string RUC { set; get; }
        [StringLength(8)]
        [Required]
        public string DNI { set; get; }
        public string RazonSocial { set; get; }
        public string Address { set; get; }
        [EmailAddress]
        public string Email { set; get; }
        public string Password { set; get; }
        [Compare("Password")]
        public string ConfirmPassword { set; get; }
    }
}
