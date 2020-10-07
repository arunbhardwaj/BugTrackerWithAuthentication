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
            string summary, string description, string priority)
        {
            IssueModel data = new IssueModel(projectName, createdBy, issueType, summary, description, priority);
            string sql = @"insert into dbo.tblIssues (ProjectName, CreatedBy, IssueType, Summary,
                            Description, Priority) values (@projectName, @createdBy, @issueType, 
                            @summary, @description, @priority);";
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<IssueModel> LoadIssues()
        {
            string sql = @"select Id, ProjectName, CreatedBy, IssueType, 
                            Summary, Description, Priority from dbo.tblIssues";
            return SqlDataAccess.LoadData<IssueModel>(sql);
        }
    }
}
