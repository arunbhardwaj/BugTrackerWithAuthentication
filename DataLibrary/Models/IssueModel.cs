using DataLibrary.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    class IssueModel
    {
        public int Id { get; set; }
        public ProjectModel Project { get; set; }
        public UserModel CreatedBy { get; set; }
        public string IssueType { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public ArrayList Labels { get; set; }
        public string Environment { get; set; }
        

    }
}
