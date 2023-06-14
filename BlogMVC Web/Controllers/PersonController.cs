using Microsoft.AspNetCore.Mvc;

namespace BlogMVC_Web.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            //ways passing data to view
            // ViewBag and ViewData can send data only from ControllerToView


            ViewBag.greeting = "Hello Preson 1";
            ViewData["greeting2"] = "Hello Preson 2";
            //TempData can send data from one controller method to another controller
            TempData["greeting2"] = "Its Tempalte msg";
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson() {
            return View();       
        }
    }
}
