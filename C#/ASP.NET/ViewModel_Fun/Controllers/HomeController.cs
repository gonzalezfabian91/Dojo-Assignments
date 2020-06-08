using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string paragraph = "This is the paragraph for the first page.";
            return View("Index", paragraph);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = {1, 2, 3, 10, 43, 5};
            return View(numbers);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            List<User> users = new List<User>
            {
                new User(){FirstName = "Moose", LastName = "Phillips"},
                new User(){FirstName = "Sarah", LastName = "Johnson"},
                new User(){FirstName = "Jerry", LastName = "Samuel"},
                new User(){FirstName = "Rene", LastName = "Ricky"},
                new User(){FirstName = "Barbarah", LastName = "Smokes"}
            };
            return View("Users", users);
        }

        [HttpGet("user")]
        public new IActionResult User()
        {
            User user = new User()
            { 
                FirstName = "Moose",
                LastName = "Phillips"
            };
            return View("User", user);
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
