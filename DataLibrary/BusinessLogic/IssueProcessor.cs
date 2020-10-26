using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class IssueProcessor
    {
        public static int CreateIssue(string projectName, string createdBy, string issueType,
            string summary, string description, string priority, string environmentDetails)
        {
            IssueModel data = new IssueModel(projectName, createdBy, issueType, summary, description, priority, environmentDetails);
            string sql = @"insert into dbo.tblIssues (ProjectName, CreatedBy, IssueType, Summary,
                            Description, Priority, Environment) values (@projectName, @createdBy, @issueType, 
                            @summary, @description, @priority, @environmentDetails);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<IssueModel> LoadIssues()
        {
            string sql = @"select Id, ProjectName, CreatedBy, IssueType, 
                            Summary, Description, Priority, Environment from dbo.tblIssues";
            return SqlDataAccess.LoadData<IssueModel>(sql);
        }
    }
}
