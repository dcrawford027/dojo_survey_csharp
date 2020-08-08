using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.Locations = new List<string>()
            {
                "San Jose", "Seattle", "McLean", "Boise"
            };

            ViewBag.Languages = new List<string>()
            {
                "C#", "Java", "Python", "Ruby"
            };

            return View("Index");
        }

        [HttpPost("Result")]
        public IActionResult Result(Survey yourSurvey)
        {
            
            return View("Result", yourSurvey);
        }
    }
}