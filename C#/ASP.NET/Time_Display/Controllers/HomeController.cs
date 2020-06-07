using System;
using Microsoft.AspNetCore.Mvc;

namespace Time_Display.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult idex()
        {
            DateTime CurrentTime = DateTime.Now;
            ViewBag.Time = CurrentTime.ToString("dddd, MMMM dd yyyy h:mm tt");
            return View("index");
        }
    }
}