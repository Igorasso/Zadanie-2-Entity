using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P02EFtest.Data;
using P02EFtest.Models;
using System.Diagnostics;

namespace P01EFtest.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ILogger<EmployeeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public EmployeeController(ILogger<EmployeeController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            IList<Employee> employees = await _dbContext.Employees.ToListAsync();


            return View(employees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create()
        {
            int x = _dbContext.Employees.Count() == 0 ? 1 : _dbContext.Employees.Max(x => x.Id) + 1;
            var p = new Employee { Id = x, Email = "", Name = "", Address = "", PhoneNumber = "" };
            return View(p);

        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {

            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var p = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (p == null)
            {
                return NotFound();
            }
            return View(p);

        }

        [HttpPost]
        public IActionResult DeleteConfirmed(Employee employee)
        {
            var p = _dbContext.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();
            if (p == null)
            {
                return NotFound();
            }

            _dbContext.Employees.Remove(p);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var employee = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }


        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            //update
            var p = _dbContext.Employees.Where(x => x.Id == employee.Id).FirstOrDefault();
            if (p == null)
            {
                return NotFound();
            }
            _dbContext.Employees.Remove(p);
            _dbContext.Employees.Add(employee);
            //_dbContext.Employees.Add(new Employee());
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var employee = _dbContext.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
    }
}
