using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugTrackerWithAuthentication.Models
{
    public class ProjectModel //UI Model
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "The {0} must have only {1} characters.", MinimumLength = 3)]
        public string Key { get; set; }
        
        public string Type { get; set; }
        public string Category { get; set; }
        public string URL { get; set; }
        public string ProjectLead { get; set; }

    }
}