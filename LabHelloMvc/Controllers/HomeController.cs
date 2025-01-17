using LabHelloMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabHelloMvc.Controllers
{
    public class HomeController : Controller
    {
        //Constructor
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            //Create a list of people (persons)?
            List<Person> people = new List<Person>();
            
            Person person1 = new Person
            {
                PersonID = 1,
                FirstName = "Emily",
                LastName = "Dunn"
            };

            Person person2 = new Person
            {
                PersonID = 2,
                FirstName = "John",
                LastName = "Smith"
            };

            //Add people to the list
            people.Add(person1);
            people.Add(person2);
           
            return View(people);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
