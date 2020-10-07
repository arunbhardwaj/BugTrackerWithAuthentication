using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string URL { get; set; }
        public UserModel ProjectLead { get; set; }
        public ProjectModel(int Id, string name, string key, string type,
            string category, string url)
        {
            
        }
    }
}
