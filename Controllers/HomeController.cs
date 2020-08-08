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
            Survey yourSurvey = new Survey();
            yourSurvey.Location = "San Jose";
            yourSurvey.Language = "C#";

            return View("Index", yourSurvey);
        }

        [HttpPost("Result")]
        public IActionResult Result(Survey yourSurvey)
        {
            if (ModelState.IsValid)
            {
                return View("Result", yourSurvey);
            }
            else 
            {
                return View("Index", yourSurvey);
            }
        }
    }
}