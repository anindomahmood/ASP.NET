using IntroToMVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace IntroToMVC.Controllers
{
    public class studentController : Controller
    {
        public IActionResult Index()
        {
            student[] Students = new student[5];

            {
                for (int i = 0; i < Students.Length; i++)
                {
                    var Student = new student
                    {
                        Id = i + 1,
                        Name = $"Student {i + 1}",
                        Age = 18 + i
                    };
                    Students[i] = Student;
                }
            }
            ;
            return View(Students);
        }

        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {

            return View();
        }
    }
}
