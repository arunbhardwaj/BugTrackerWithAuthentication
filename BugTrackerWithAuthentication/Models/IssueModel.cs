using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerWithAuthentication.Models
{
    public class IssueModel
    {
        public int Id { get; set; }
        public string Project { get; set; }
        public string IssueType { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public ArrayList Labels { get; set; }
        public string Environment { get; set; }

    }
}