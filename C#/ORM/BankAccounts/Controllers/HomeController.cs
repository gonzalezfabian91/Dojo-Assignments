using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BankAccounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Controllers
{
    public class HomeController : Controller
    {
        private BankAccountsContext db;
        public HomeController(BankAccountsContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Register()
        {
            User user = new User();
            return View("Register");
        }

        [HttpPost("create/registration")]
        public IActionResult CreateReg(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (db.Users.Any(e => e.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already being used");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                db.Add(newUser);
                db.SaveChanges();
                HttpContext.Session.SetInt32("User", newUser.UserId);
                return RedirectToAction("Account", new {userId = newUser.UserId});
            }
            else
            {
                return View("Register");
            }
        }

        [HttpGet("login")]
        public IActionResult LogIn()
        {
            return View("LogIn");
        }

        [HttpPost("create/login")]
        public IActionResult CreateLogin(Login loginUser)
        {
            if (ModelState.IsValid)
            {
                var userInDb = db.Users.FirstOrDefault(u => u.Email == loginUser.Email);

                if (userInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email or Password");
                    return View("LogIn");
                }

                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(loginUser, userInDb.Password, loginUser.Password);

                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email or Password");
                    return View("LogIn");
                }

                HttpContext.Session.SetInt32("User", userInDb.UserId);
                return RedirectToAction("Account", new {userId = userInDb.UserId});
            }
            return View("LogIn");
        }

        [HttpGet("account/{userId}")]
        public IActionResult Account(int userId)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("User");
            var loggedUser = db.Users.FirstOrDefault(u => u.UserId == loggedUserId);
            
            if (db.Users.Any(u => u.UserId == loggedUserId))
            {
                if (loggedUserId != userId)
                {
                    return RedirectToAction("Account", new { userId = loggedUserId});
                }

                BAViewModel trans = new BAViewModel();
                trans.CurrentUser = db.Users.Include(u => u.Transactions).FirstOrDefault(u => u.UserId == loggedUserId);
                trans.AllUserTransaction = db.Users.Include(u => u.Transactions).FirstOrDefault(u => u.UserId == loggedUserId).Transactions.OrderByDescending(t => t.CreatedAt).ToList();
                return View("Account", trans);
            }
            return RedirectToAction("LogIn");
        }

        [HttpPost("transaction")]
        public IActionResult Maketrans(BAViewModel change)
        {
            int? loggedUserId = HttpContext.Session.GetInt32("User");
            User loggedUser = db.Users.FirstOrDefault(u => u.UserId == loggedUserId);

            if (ModelState.IsValid)
            {
                if (change.Transaction.Amount > 0 && loggedUser.Balance < change.Transaction.Amount)
                {
                    ModelState.AddModelError("Amount", "Insuffisiant funds");
                }

                change.Transaction.UserId = (int)loggedUserId;
                loggedUser.Balance += change.Transaction.Amount;
                db.Transactions.Update(change.Transaction);
                db.Users.Update(loggedUser);
                db.SaveChanges();
                return RedirectToAction("Account", new {userId = loggedUserId});
            }
            return View("Account", change);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
