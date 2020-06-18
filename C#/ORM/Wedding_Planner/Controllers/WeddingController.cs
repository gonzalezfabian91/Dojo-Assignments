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
            if (isLoggedIn == false)
            {
                return RedirectToAction("Index", "Home");
            }
            
            return View("Dashboard");
        }
    }
}