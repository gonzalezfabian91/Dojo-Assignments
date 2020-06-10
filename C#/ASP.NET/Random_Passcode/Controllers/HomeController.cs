using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Random_Passcode.Models;

namespace Random_Passcode.Controllers
{
    public class HomeController : Controller
    {

        private string GeneratePass
        {
            get
            {
                return HttpContext.Session.GetString("passcode");
            }
            set
            {
                HttpContext.Session.SetString("passcode", value);
            }
        }

        public string Passcode()
        {
            string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string passcode = "";
            Random random = new Random();
            for(var i = 0; i <= 14; i++)
            {
                passcode += valid[random.Next(valid.Length)];
            }
            return passcode;
        }

        public int? IncrementCount
        {
            get
            {
                return HttpContext.Session.GetInt32("count");
            }
            set 
            {
                HttpContext.Session.SetInt32("count", 1);
            }
        }

        public int Count(int count)
        {
            count ++;
            return count;
        }

        // [HttpPost("")]
        public IActionResult Index()
        {
            int? count = HttpContext.Session.GetInt32("count");
            if (count == null)
            {
                HttpContext.Session.SetInt32("count", 0);
            }
            else
            {
                HttpContext.Session.SetInt32("count",(int)count + 1);
            }
            ViewBag.Passcode = GeneratePass;
            ViewBag.Count = count;
            return View("Index");
        }

        [HttpPost("")]
        public IActionResult RandPasscode()
        {
            GeneratePass = Passcode();
            return RedirectToAction("Index");
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
