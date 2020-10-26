using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class ProjectProcessor
    {
        public static int CreateProject(string projectName, string key, string projectType,
            string category, string URL, string projectLead)
        {
            ProjectModel data = new ProjectModel(projectName, key, projectType, category, URL, projectLead);
            string sql = @"insert into dbo.tblProjects (Name, Key, Type, Category,
                            URL, ProjectLead) 
                            values (@projectName, @key, @projectType, 
                            @category, @URL, @projectLead);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<ProjectModel> LoadProjects()
        {
            string sql = @"select Id, Name, [Key], Type, Category,
                            URL, ProjectLead from dbo.tblProjects";
            return SqlDataAccess.LoadData<ProjectModel>(sql);
        }
    }
}
