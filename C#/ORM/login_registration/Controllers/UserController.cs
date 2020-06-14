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
    }
}