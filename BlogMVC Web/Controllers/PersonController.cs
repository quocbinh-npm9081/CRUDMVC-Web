using BlogMVC_Web.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace BlogMVC_Web.Controllers
{
    public class PersonController : Controller
    {
        private readonly DataBaseContext _context;

        public PersonController(DataBaseContext context) {
            _context = context;
        }

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
        public IActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Person person) {
            if(!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                _context.Add(person);
                _context.SaveChanges();
                TempData["submit_msg"] = "Added person successfully";
                return RedirectToAction("AddPerson");

            }
            catch (Exception ex)
            {
                TempData["submit_msg"] = "Add failse";
                return View();
            }
        }
    }
}
