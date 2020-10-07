using DataLibrary.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBIssueModel = DataLibrary.Models.IssueModel;
using UIIssueModel = BugTrackerWithAuthentication.Models.IssueModel;


namespace BugTrackerWithAuthentication.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        [Route("dashboard")]
        public ActionResult Dashboard()
        {
            ViewBag.Message = "System Dashboard";

            return View();
        }

        public ActionResult ViewIssues()
        {
            ViewBag.Message = "Issue List";
            var data = IssueProcessor.LoadIssues();
            List<DBIssueModel> issues = new List<DBIssueModel>();

            foreach (var issue in data)
            {
                issues.Add(new DBIssueModel
                {
                    Id = issue.Id,
                    ProjectName = issue.ProjectName,
                    CreatedBy = issue.CreatedBy,
                    IssueType = issue.IssueType,
                    Summary = issue.Summary,
                    Description = issue.Description,
                    Priority = issue.Priority,
                    Environment = issue.Environment

                });
            }
            return View(issues);
        }

        public ActionResult CreateIssue()
        {
            ViewBag.Message = "Create a new Issue";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateIssue(UIIssueModel model)
        {


            return View();
        }
    }
}