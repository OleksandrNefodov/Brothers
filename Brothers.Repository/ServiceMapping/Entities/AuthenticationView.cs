using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Brothers.Repository.ServiceMapping.Entities
{
    public class AuthenticationView
    {
        [Display(Name = "UserName")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide e-mail")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некорректный адрес")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter the password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please repeat password")]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        [Display(Name = "Confirm password")]
        public string PasswordConfirm { get; set; }
    }
}