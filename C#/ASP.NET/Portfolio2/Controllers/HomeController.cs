using Microsoft.AspNetCore.Mvc;

namespace Portfolio2.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View("index");
        }

        [HttpGet("projects")]
        public ViewResult projects()
        {
            return View("projects");
        }
        
        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View("contact");
        }

        // [HttpGet("success")]
        // public RedirectToActionResult success()
        // {
        //     return RedirectToAction("index");
        // }

    }
}