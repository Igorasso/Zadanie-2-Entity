using Microsoft.AspNetCore.Mvc;
using P01WebApplicationMVC.Models;

namespace P01WebApplicationMVC.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Country = "PL"
            };
            return View(student);
        }
        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            //TODO: SAVE TO DB
            return View(new Student());
        }
    }
}
