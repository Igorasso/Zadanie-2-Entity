using Microsoft.AspNetCore.Mvc;
using P01WebApplicationMVC.Models;
using System.Diagnostics;

namespace P01WebApplicationMVC.Controllers
{
    //[Route] atrybuty
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //ViewData["Users"] = ... tak się nie robi
            List<User> users = new List<User>()
            {
                new User
                {
                    FirstName = "adam", LastName = "nowak"
                },
                 new User
                {
                    FirstName = "janusz", LastName = "kowalski"
                },
            };

            return View(users);
        }
        [Route("/Home/Hello")]
        [Route("/Home/Witaj")]
        public string Plain()
        {
            return "jakis tam string";
        }

        public string Search1(string name, int year)
        {
            //HttpContext.Request.Query["name"]
            return $"name = {name}, year = {year}";
        }

        [Route("Home/Search2/{itemId:int}")]
        public string Search2(int itemId)
        {
          return $"itemId = {itemId}";
        }

        public IActionResult SessionExample()
        {
            HttpContext.Session.SetString("CurrentTime", DateTime.Now.ToString());
            HttpContext.Session.SetInt32("Counter", 1234);
            return View();
        }

        public IActionResult JsonTest()
        {
            return Json(new
            {
                Success = true, Name = "Adam Nowak"
            });
        }


        public IActionResult Teapot()
        {
            return StatusCode(StatusCodes.Status418ImATeapot, "Jakis error");
        }

        public IActionResult RedirectTest()
        {
            return RedirectPermanent("http://tvn24.pl");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}