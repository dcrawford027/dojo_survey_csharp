using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Result(string name, string location, string language, string comment="")
        {
            ViewBag.Name = name;
            ViewBag.Location = location;
            ViewBag.Language = language;
            ViewBag.Comment = comment;
            return View("Result");
        }
    }
}