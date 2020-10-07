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

        [Display(Name = "Issue Type")]
        public string IssueType { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Priority Level")]
        public string Priority { get; set; }

        public ArrayList Labels { get; set; }

        [Display(Name = "Environment Details")]
        public string Environment { get; set; }

    }
}