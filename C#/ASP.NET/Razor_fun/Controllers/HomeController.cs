using Microsoft.AspNetCore.Mvc;

namespace Razor_fun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View("index");
        }
    }
}