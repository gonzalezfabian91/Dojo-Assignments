using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wedding_Planner.Models;

namespace Wedding_Planner.Controllers
{
    public class WeddingController : Controller
    {
        private Wedding_PlannerContext db;

        private int? uid
        {
            get
            {
                return HttpContext.Session.GetInt32("UserId");
            }
        }

        private bool isLoggedIn
        {
            get
            {
                return uid != null;
            }
        }
        public WeddingController(Wedding_PlannerContext context)
        {
        db = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View("Dashboard");
        }

        [HttpGet("new_wedding")]
        public IActionResult NewWedding()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("NewWedding");
        }

        [HttpPost("new_wedding/create")]
        public IActionResult CreateNewWedding(Wedding new_wedding)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index", "Home");
            }
            if (ModelState.IsValid)
            {
                db.Add(new_wedding);
                db.SaveChanges();
                return RedirectToAction("Dashboard", new_wedding);
            }
            return View("NewWedding");
        }
    }
}