using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace ProjectManagementSystem.Models
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Project Name Required!")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$", ErrorMessage = "Only Alphabets Are Allowed!")]
        [Display(Name = "project Name")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Project Description Required!")]
        public string ProjectDescription { get; set; }

        public Nullable<System.DateTime> StartDate { get; set; }

        public Nullable<System.DateTime> EndDate { get; set; }

        [Required]
        [Display(Name = "Project Manager")]
        public int ProjectManagerId { get; set; }

        [Required(ErrorMessage = "Choose suitable status for this project.")]
        public ProjectStatus ProjectStatus { get; set; }

        public Role CreatedBy { get; set; }

        public Role ModifyBy { get; set; }

    }
}