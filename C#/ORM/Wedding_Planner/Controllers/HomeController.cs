using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Wedding_Planner.Models;

namespace Wedding_Planner.Controllers
{
    public class HomeController : Controller
    {
        private Wedding_PlannerContext db;
        public HomeController(Wedding_PlannerContext context)
        {
        db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Any(user => user.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use");
                    return View("Index"); //to display error messages
                }
                // hash pw
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                newUser.Password = hasher.HashPassword(newUser, newUser.Password);
                
                db.Add(newUser);
                db.SaveChanges();

                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("Dashboard", "Wedding", new {userId = newUser.UserId});
            }
            else
            {
                return View("Index"); //to display error messages
            }
        }

        [HttpPost("login")]
        public IActionResult Login(Login login)
        {
            if (ModelState.IsValid)
            {
                //check email
                var userInDb = db.Users.FirstOrDefault(u => u.Email == login.LoginEmail);

                if (userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email or Password");
                    return View("Index"); //to display error messages
                }

                //check password
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LoginPassword);

                if (result == 0)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email or Password");
                    return View("Index"); //to display error message
                }

                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard", "Wedding", new {userId = userInDb.UserId});
            }
            return View("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
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
