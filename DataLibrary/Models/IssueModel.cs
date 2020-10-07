using DataLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class IssueModel //Logic Model
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string CreatedBy { get; set; }
        public string IssueType { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public ArrayList Labels { get; set; }
        public string Environment { get; set; }
        
        public IssueModel()
        {

        }

        public IssueModel(string projectName, string createdBy, string issueType,
            string summary, string description, string priority)
        {
            ProjectName = projectName;
            CreatedBy = createdBy;
            IssueType = issueType;
            Summary = summary;
            Description = description;
            Priority = priority;

        }
    }
}
