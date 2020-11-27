using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finanzas.Models
{
    public class Bodeguero : IdentityUser
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
    }
}
