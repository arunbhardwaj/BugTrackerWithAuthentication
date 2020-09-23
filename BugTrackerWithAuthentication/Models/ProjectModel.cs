using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerWithAuthentication.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string URL { get; set; }

    }
}