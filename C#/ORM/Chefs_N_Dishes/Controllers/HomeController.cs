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
            List<Chef> chefs = db.Chefs.ToList();
            return View("Index", chefs);
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
            IndexViewModel allchefs = new IndexViewModel();
            allchefs.AllChefs = db.Chefs.ToList();
            return View("NewDish", allchefs);
        }

        [HttpPost("create/dish")]
        public IActionResult CreateDish(Dishes newDish)
        {
            IndexViewModel allchefs = new IndexViewModel();
            allchefs.AllChefs = db.Chefs.ToList();

            if (ModelState.IsValid)
            {
                db.Add(newDish);
                db.SaveChanges();
                return RedirectToAction("Dishes", newDish);
            }
            else
            {
                return RedirectToAction("Dishes");
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
