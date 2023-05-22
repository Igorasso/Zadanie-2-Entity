using Microsoft.AspNetCore.Mvc;
using P01WebApplicationMVC.Models;

namespace P01WebApplicationMVC.Controllers
{
    public class PersonController : Controller
    {

        static IList<Person> peopleList = new List<Person>
        {
            new Person{PersonId = 1, PersonName = "Jacek",PersonAge = 37 },
            new Person{PersonId = 2, PersonName = "Marcin",PersonAge =40},
            new Person{PersonId = 3 ,PersonName = "Karolina",PersonAge =22},
            new Person{PersonId = 4, PersonName = "Anna",PersonAge =27},
            new Person{PersonId = 5, PersonName = "Robert",PersonAge =66},
            new Person{PersonId = 6, PersonName ="Beata",PersonAge =61},
            new Person{PersonId = 7, PersonName ="Agnieszka",PersonAge =26},
            new Person{PersonId = 8, PersonName ="Aleksandra",PersonAge =51},
            new Person{PersonId = 9, PersonName ="Maciej",PersonAge =30},
         
          
        };

     


        public PersonController()
        {

        }

        public IActionResult Create()
        {
            int x = 0;
            if (peopleList.Count == 0)
            {
                x = 1;
            }
            else
            {
                x = peopleList.Max(x => x.PersonId) + 1;
            }
            var p = new Person { PersonId = x, PersonAge = 0, PersonName = "" };
            return View(p);
           
        }
        [HttpPost]
        public IActionResult Create(Person person)
        {
           
            peopleList.Add(person);
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            return View(peopleList.OrderBy(x => x.PersonId).ToList()); // trzeba zrobić ToList bo OrderBy defaultowo zwraca inny typ. 
        }

        public IActionResult Edit(int Id)
        {
            var person = peopleList.Where(x=>x.PersonId == Id).FirstOrDefault();
            if(person == null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost]
        public IActionResult Edit(Person person)
        {
            //update
            var p = peopleList.Where(x => x.PersonId == person.PersonId).FirstOrDefault();
            if(p == null) { return NotFound(); }
            peopleList.Remove(p);
            peopleList.Add(person);
            return RedirectToAction("Index");
        }


    
        public IActionResult Delete (int Id)
        {
            //delete
            var p = peopleList.Where(x => x.PersonId == Id).FirstOrDefault();
            if (p == null) { return NotFound(); }

           // peopleList.Remove(p);
           // return RedirectToAction("Index");
           return View(p);
        }

		public IActionResult Details(int Id)
		{
			//delete
			var p = peopleList.Where(x => x.PersonId == Id).FirstOrDefault();
			if (p == null) { return NotFound(); }

			// peopleList.Remove(p);
			// return RedirectToAction("Index");
			return View(p);
		}
		[HttpPost]
        public IActionResult DeleteConfirmed(Person person)
        {
            //delte confirmed
            var p = peopleList.Where(x => x.PersonId == person.PersonId).FirstOrDefault();
            if (p == null) { return NotFound(); }
            peopleList.Remove(p);
            return RedirectToAction("Index");
            
        }

    }
}
