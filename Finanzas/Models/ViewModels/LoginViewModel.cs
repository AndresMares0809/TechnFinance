using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finanzas.Models.ViewModels
{
    public class LoginViewModel
    {
        [StringLength(12)]
        public string RUC { set; get; }
        public string Password { set; get; }

    }
}
