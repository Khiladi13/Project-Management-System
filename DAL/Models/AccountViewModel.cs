using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ProjectManagementSystem.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }   

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First Name Required!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "Only Alphabets Are Allowed!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last Name Required!")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "Only Alphabets Are Allowed!")]
        public string LastName { get; set; }


        //[Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password Required." )]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        //[RegularExpression("^(?!.*([A-Za-z0-9]))(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$", ErrorMessage = "Password Must Be Unique!!! [It Must contains Digit, Lower Case, Upper Case, Unique Chars, Length-(8 and Maximum 15 character)]")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm passWord required.")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8), Compare("Password")]
        //[RegularExpression("^(?!.*([A-Za-z0-9]))(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$", ErrorMessage = "Password Must Be Unique!!! [It Must contains Digit, Lower Case, Upper Case, Unique Chars, Length-(8 and Maximum 15 character)]")]

        public string ConfirmPassword { get; set; }

        public bool ShowRegisterForm { get; set; } = true;
    }


}