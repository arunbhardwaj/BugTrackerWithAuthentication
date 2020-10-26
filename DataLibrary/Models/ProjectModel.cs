using DataLibrary.BusinessLogic;
using DataLibrary.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ProjectModel //Logic Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Key { get; set; } //This is a 3 letter abbreviation of the Project unique to it. 
        public string Type { get; set; }
        public string Category { get; set; }
        public string URL { get; set; }
        public UserModel ProjectLead { get; set; }

        public ProjectModel()
        {

        }

        public ProjectModel(string name, string key, string type,
            string category, string url, string projectLead)
        {
            Name = name;
            Key = key;
            Type = type;
            Category = category;
            URL = url;
            ProjectLead = 
        }
    }
}
