using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugTrackerWithAuthentication.Models
{
    public class IssueModel //UI Model
    {
        public int Id { get; set; }

        [Display(Name = "Project")]
        public string ProjectName { get; set; }

        public string CreatedBy { get; set; }

        [Display(Name = "Issue type")]
        public string IssueType { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Priority level")]
        public string Priority { get; set; }

        public ArrayList Labels { get; set; }

        [Display(Name = "Environment details")]
        public string Environment { get; set; }

    }
}