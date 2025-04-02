using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceWebAppAngularjs.ViewModels.Account
{
    public class RigisterViewModel
    {
        [Required]
        [Display(Name ="Email")]
        [EmailAddress]
        public string  Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Password")]
        [StringLength(100,ErrorMessage ="The {0} must be atleast {2} and at max {1} char")]

        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
