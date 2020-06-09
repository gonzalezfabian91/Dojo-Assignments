using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Random_Passcode.Models;
using Random_Passcode;

namespace Random_Passcode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string password = Random_Passcode.Models.PasscodeGenerator.RandomPassword(14);
            HttpContext.Session.SetInt32("Count", 1);
            ViewBag.Password = password;
            ViewBag.Count = HttpContext.Session.GetInt32("Count");
            return View("Index");
        }

        [HttpGet("generate")]
        public IActionResult Generate()
        {
            int Count = (int)HttpContext.Session.GetInt32("Count") + 1;
            HttpContext.Session.SetInt32("Count", 1);
            string password = Random_Passcode.Models.PasscodeGenerator.RandomPassword(14);
            ViewBag.Password = password;
            ViewBag.Count = HttpContext.Session.GetInt32("Count") + 1;
            return View("Index");
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
