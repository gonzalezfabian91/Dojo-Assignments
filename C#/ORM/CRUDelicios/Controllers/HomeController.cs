using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicios.Models;

namespace CRUDelicios.Controllers
{
    public class HomeController : Controller
    {
        private CRUDeliciousContext db;
        public HomeController(CRUDeliciousContext context)
        {
            db = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> dishes = db.Dishes
                .OrderByDescending(d => d.CreatedAt)
                .Take(5)
                .ToList();
            return View("Index", dishes);
        }

        [HttpGet("new")]
        public IActionResult NewDish()
        {
            return View("Create");
        }

        [HttpPost("create")]
        public IActionResult Create(Dish newDish)
        {
            db.Add(newDish);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("{dishId}")]
        public IActionResult Dish(int dishId)
        {
            Dish getDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View("Dish", getDish);
        }

        [HttpGet("edit/{dishId}")]
        public IActionResult Edit(int dishId)
        {
            Dish getDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            return View("Edit", getDish);
        }

        [HttpPost("update/{dishId}")]
        public IActionResult Update(Dish updish, int dishId)
        {
            Dish getDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            getDish.ChefName = updish.ChefName;
            getDish.DishName = updish.DishName;
            getDish.Calories = updish.Calories;
            getDish.Tastiness = updish.Tastiness;
            getDish.Description = updish.Description;
            getDish.UpdatedAt = DateTime.Now;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("delete/{dishId}")]
        public IActionResult Delete(int dishId)
        {
            Dish getDish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
            db.Dishes.Remove(getDish);
            db.SaveChanges();
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
