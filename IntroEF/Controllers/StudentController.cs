using Microsoft.AspNetCore.Mvc;
using IntroEF.Models;
using IntroEF.EF;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace IntroEF.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Student.ToList();
            return View(students);
        }

        //Create

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Student.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //Delete
        public IActionResult Delete(int id)
        {
            var student = _context.Student.Find(id);
            if (student != null)
            {
                _context.Student.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        //Update/Edit

        public IActionResult Edit(int id)
        {
            var student = _context.Student.FirstOrDefault(s=>s.id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Update(int id, Student student)
        {
           
            if (ModelState.IsValid)
            {
                var std = _context.Student.FirstOrDefault(s => s.id == id);
                if (std == null)
                {
                    return NotFound();
                }

                std.name = student.name;
                std.department = student.department;
                std.program = student.program;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }
}
