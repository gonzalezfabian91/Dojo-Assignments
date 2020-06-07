using Dojo_Survey.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dojo_Survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            Survey survey = new Survey();
            return View("index", survey);
        }

        [HttpPost("info")]
        public IActionResult Info(Survey survey)
        {
            return View("Info", survey);
        }
    }
}