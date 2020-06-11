using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dojodachi.Models;
using Microsoft.AspNetCore.Http;

namespace Dojodachi.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Dojo dojodachi = new Dojo();
            HttpContext.Session.SetObjectAsJson("Dojo", dojodachi);
            return View("Index", dojodachi);
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            Random like = new Random();
            Random full = new Random();

            if (get.Meals <= 0)
            {
                get.Message = "No Food to feed your dog bro.";
            }
            else if (like.Next(5) == 1)
            {
                get.Meals -= 1;
                get.Message = "Your puppy didnt like that you need to go buy new food.";
                get.Image = "/images/Mad.jpg";
            }
            else
            {
                get.Meals -= 1;
                get.Fullness += full.Next(5,10);
                get.Message = $"Your pup ate the food you gave it. Meal -1, Fullness {full.Next(5,10)}";
                get.Image = "/images/Eating.jpg";
            }

            if (get.Happiness >= 100 && get.Fullness >= 100 && get.Energy >= 100)
            {
                get.Message = "Your a good pet owner. Congrats!";
                get.Image = "/images/Happy.jpg";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Success");
            }
            else if (get.Happiness <= 0 || get.Fullness <= 0)
            {
                get.Message = "You kiled your puppy!! You bastard!!";
                get.Image = "/images/Sad.jpg";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Failure");
            }
            HttpContext.Session.SetObjectAsJson("Dojo", get);
            return View("Index", get);
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            Random like = new Random();
            Random happy = new Random();

            if (get.Energy <= 0)
            {
                get.Message = "Your puppy has no energy to play have gim take a nap so her can energize.";
            }
            else if (like.Next(5) == 1)
            {
                get.Energy -= 5;
                get.Message = "Your puppy didnt like the game that you guys played.";
                get.Image = "/images/Mad.jpg";
            }
            else
            {
                get.Energy -= 5;
                get.Happiness += happy.Next(5,10);
                get.Message = $"Your puppy had a blast!! His energy went down by 5 but his happines raised by {happy.Next(5,10)}";
                get.Image = "/images/Playing.jpg";
            }

            if (get.Happiness >= 100 && get.Fullness >= 100 && get.Energy >= 100)
            {
                get.Message = "Your a good pet owner. Congrats!";
                get.Image = "/images/Happy.jpg";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Success");
            }
            else if (get.Happiness <= 0 || get.Fullness <= 0)
            {
                get.Message = "You kiled your puppy!! You bastard!!";
                get.Image = "/images/Sad.jpg";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Failure");
            }
            HttpContext.Session.SetObjectAsJson("Dojo", get);
            return View("Index", get);
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            Random like = new Random();
            Random meal = new Random();

            if (get.Energy <= 0)
            {
                get.Message = "Your puppy doesnt have the energy to work have him take a nap so he can re energize.";
            }
            else
            {
                get.Energy -= 5;
                get.Meals += meal.Next(1,3);
                get.Message = $"Your puppy put in work and has earned {meal.Next(1,3)} meals.";
                get.Image = "/images/Working.jpg";
            }

            if (get.Happiness >= 100 && get.Fullness >= 100 && get.Energy >= 100)
            {
                get.Message = "Your a good pet owner. Congrats!";
                get.Image = "/images/Working.jpg";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Success");
            }
            else if (get.Happiness <= 0 || get.Fullness <= 0)
            {
                get.Message = "You kiled your puppy!! You bastard!!";
                get.Image = "/images/Sad.jpg";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Failure");
            }
            HttpContext.Session.SetObjectAsJson("Dojo", get);
            return View("Index", get);
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            get.Energy += 15;
            get.Fullness -= 5;
            get.Happiness -= 5;
            get.Message = "Your puppy took a nap and gained 15 Energy but has lost 5 Fullness and Happiness";
            get.Image = "/images/Sleeping.jpg";
            

            if (get.Happiness >= 100 && get.Fullness >= 100 && get.Energy >= 100)
            {
                get.Message = "Your a good pet owner. Congrats!";
                get.Image = "/images/Happy.jpg";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Success");
            }
            else if (get.Happiness <= 0 || get.Fullness <= 0)
            {
                get.Message = "You kiled your puppy!! You bastard!!";
                get.Image = "/images/Sad.jpg";
                HttpContext.Session.SetObjectAsJson("Dojo", get);
                return RedirectToAction("Failure");
            }
            HttpContext.Session.SetObjectAsJson("Dojo", get);
            return View("Index", get);
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            return View("Success", get);
        }
        
        [HttpGet("failure")]
        public IActionResult Failure()
        {
            Dojo get = HttpContext.Session.GetObjectFromJson<Dojo>("Dojo");
            return View("Failure", get);
        }
        
        [HttpGet("reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
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
