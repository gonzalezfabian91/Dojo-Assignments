using Microsoft.AspNetCore.Mvc;
namespace Portfolio1.Controlers
{
    public class HomeControllers : Controller
    {
        [HttpGet]
        [Route("/")]
        public string Index()
        {
            return "This is my index";
        }

        [HttpGet]
        [Route("projects")]
        public string projects()
        {
            return "These are my projects";
        }

        [HttpGet]
        [Route("contact")]
        public string contact()
        {
            return "This is my Contact";
        }
    }
}