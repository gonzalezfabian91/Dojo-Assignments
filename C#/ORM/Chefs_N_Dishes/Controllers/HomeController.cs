using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chefs_N_Dishes.Models;
using Microsoft.EntityFrameworkCore;

namespace Chefs_N_Dishes.Controllers
{
    public class HomeController : Controller
    {
        private Chefs_N_DishesContext db;
        public HomeController(Chefs_N_DishesContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewModel allchefs = new ViewModel();
            allchefs.AllChefs = db.Chefs.Include(u => u.CreatedDishes).ToList();
            // List<Chef> chefs = db.Chefs.ToList();
            return View("Index", allchefs);
        }

        [HttpGet("new")]
        public IActionResult NewChef()
        {
            return View("NewChef");
        }

        [HttpPost("create/chef")]
        public IActionResult CreateChef(Chef newchef)
        {
            if (ModelState.IsValid)
            {
                db.Add(newchef);
                db.SaveChanges();
                return RedirectToAction("Index", newchef);
            }
            else
            {
                return RedirectToAction("NewChef");
            }
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            List<Dishes> dishes = db.Dishes.Include(d => d.Creator).ToList();
            return View("Dishes", dishes);
        }

        [HttpGet("new/dish")]
        public IActionResult NewDish()
        {
            ViewModel allchefs = new ViewModel();
            allchefs.AllChefs = db.Chefs.ToList();
            return View("NewDish", allchefs);
        }

        [HttpPost("create/dish")]
        public IActionResult CreateDish(ViewModel newDish)
        {
            if (ModelState.IsValid)
            {
                db.Add(newDish.Dish);
                db.SaveChanges();
                return RedirectToAction("Dishes");
            }
            ViewModel allchefs = new ViewModel();
            allchefs.AllChefs = db.Chefs.ToList();
            return View("Dishes", allchefs);
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
