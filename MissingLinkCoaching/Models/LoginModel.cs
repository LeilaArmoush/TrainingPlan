using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Umbraco.Core.Services;

namespace MissingLinkCoaching.Models
{
    public class LoginModel
    {
        [Display(Name = "Username")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Passsword")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}