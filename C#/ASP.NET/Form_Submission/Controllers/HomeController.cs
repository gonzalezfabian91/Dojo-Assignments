using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Form_Submission.Models;

namespace Form_Submission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            User user = new User();
            return View("Index", user);
        }

        [HttpPost("user")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                var newUser = user;
                return View("Success");
            }
            else
            {
                return View("Index", user);
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
