using System.Linq;
using login_registration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace login_registration.Controllers
{
    public class UserController : Controller
    {
        private login_registrationContext db;
        public UserController(login_registrationContext context)
        {
            db = context;
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            User user = new User();
            return View("Register", user);
        }

        [HttpPost("make/registration")]
        public IActionResult MakeReg(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Any(e => e.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already being used.");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                db.Add(newUser);
                db.SaveChanges();
                HttpContext.Session.SetInt32("User", newUser.UserId);
                return RedirectToAction("Success");
            }
            else
            {
                return View("Register");
            }
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("loggingin")]
        public IActionResult Makelog(Login loginUser)
        {
            if (ModelState.IsValid)
            {
                var userInDb = db.Users.FirstOrDefault(u => u.Email == loginUser.Email);

                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email or Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.Password);

                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email or Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("User", userInDb.UserId);
                return RedirectToAction("Success");
            }
            return View("Login");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            var userId = HttpContext.Session.GetInt32("User");
            if (db.Users.Any(u => u.UserId == userId))
            {
                return View("Success");
            }
            else
            {
                return RedirectToAction("Register");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}