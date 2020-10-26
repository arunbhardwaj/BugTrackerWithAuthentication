using DataLibrary.BusinessLogic;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBIssueModel = DataLibrary.Models.IssueModel;
using UIIssueModel = BugTrackerWithAuthentication.Models.IssueModel;
using DBProjectModel = DataLibrary.Models.ProjectModel;
using UIProjectModel = BugTrackerWithAuthentication.Models.ProjectModel;



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
            List<UIIssueModel> issues = new List<UIIssueModel>();

            foreach (var issue in data)
            {
                issues.Add(new UIIssueModel
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

        public ActionResult ViewProjects()
        {
            ViewBag.Message = "Projects List";
            var data = ProjectProcessor.LoadProjects();
            List<UIProjectModel> projects = new List<UIProjectModel>();

            foreach (var project in data)
            {
                projects.Add(new UIProjectModel
                {
                    Id = project.Id,
                    Name = project.Name,
                    Key = project.Key,
                    Type = project.Type,
                    Category = project.Category,
                    URL = project.URL,
                    ProjectLead = project.ProjectLead.ToString()

                });
            }
            return View(projects);
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
            if (ModelState.IsValid)
            {
                IssueProcessor.CreateIssue(model.ProjectName,
                    //put username here.
                    User.Identity.GetUserName(),
                    model.IssueType,
                    model.Summary,
                    model.Description,
                    model.Priority,
                    model.Environment);
                return RedirectToAction("ViewIssues");
            }

            return View();
        }

        public ActionResult CreateProject()
        {
            ViewBag.Message = "Create a new Project";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateProject(UIProjectModel model)
        {
            if (ModelState.IsValid)
            {
                ProjectProcessor.CreateProject(model.Name,
                    model.Key,
                    model.Type,
                    model.Category,
                    model.URL,
                    model.ProjectLead
                    //put username here.
                    //User.Identity.GetUserName(),
                );
                return RedirectToAction("ViewProjects");
            }

            return View();
        }
    }
}