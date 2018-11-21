using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results
        public IActionResult Results(string searchTerm)
        {
            bool C4 = string.IsNullOrEmpty(searchTerm);
            if (C4 == true)
            {
                ViewBag.columns = ListController.columnChoices;
                ViewBag.title = "Results";
                ViewBag.keyword = "empty";
                return View("Index");
            }
            else
            {
                ViewBag.columns = ListController.columnChoices;
                ViewBag.title = "Results";
                ViewBag.jobs = JobData.FindByValue(searchTerm);
                return View("Index");
            }       
        }
    }
}
