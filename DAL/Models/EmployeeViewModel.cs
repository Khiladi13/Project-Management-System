using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectManagementSystem.Models
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name Required!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "Only Alphabets Are Allowed!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required!")]
        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "Only Alphabets Are Allowed!")]
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string[] Genders = new[] { "Male", "Female"};

        [Required(ErrorMessage ="Email Required!")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password Required!")]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        public string Password { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public Nullable<System.DateTime> DateOfBirth { get; set; }


        [RegularExpression(@"^\d{4}-\d{4}-\d{4}$", ErrorMessage = "AadharCard Number should be in '0000-0000-0000' this format.")]
        public string AadharCardNo { get; set; }


        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string ContactNo { get; set; }

        [RegularExpression(@"^[1-3]", ErrorMessage = "Choose suitable role for user." )]
        public Role Role { get; set; }
        
        public bool Status { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
    }
}