using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_with_Validations.Models;

namespace Dojo_Survey_with_Validations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Survey survey = new Survey();
            return View("Index", survey);
        }

        [HttpPost("info")]
        public IActionResult Info(Survey survey)
        {
            if(ModelState.IsValid)
            {
                var newSurvey = survey;
                return View("Info", survey);
            }
            else
            {
                return View("Index", survey);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
