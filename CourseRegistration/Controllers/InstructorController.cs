using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructor _instructorRepo;
        private readonly ICourse _courseRepo;

        public InstructorController(IInstructor instructorRepo, ICourse courseRepo)
        {
            _instructorRepo = instructorRepo;
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            return View(_instructorRepo.GetAll());
        }
        public IEnumerable<string> GetCourseName(int id)
        {
            var result = _courseRepo.GetAll()
            .Where(s => s.CourseId == id)
            .Select(s => s.CourseName);
            return result;
        }
        // Get: InstructorController/Create
        public ActionResult Create()
        {
            ViewBag.Course = new SelectList(_courseRepo.GetAll(), "CourseId", "CourseName");
            return View();
        }
        // Post: InstructorController/Create
        [HttpPost]
        public ActionResult Create(Instructor input)
        {
            try
            {
                _instructorRepo.Create(input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            ViewBag.Course = new SelectList(_courseRepo.GetAll(), "CourseId", "CourseName");
            return View(_instructorRepo.GetById(id));
        }
        // Post: InstructorController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Instructor input)
        {
            try
            {
                _instructorRepo.Update(id, input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            return View(_instructorRepo.GetById(id));
        }
        public ActionResult Delete(int id)
        {
            return View(_instructorRepo.GetById(id));
        }
        // Post: InstructorController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Instructor input)
        {
            try
            {
                _instructorRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

