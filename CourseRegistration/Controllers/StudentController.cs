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
    public class StudentController : Controller
    {
        private readonly IStudent _studentRepo;
        private readonly ICourse _courseRepo;

        public StudentController(IStudent studentRepo, ICourse courseRepo)
        {
            _studentRepo = studentRepo;
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            return View(_studentRepo.GetAll());
        }
        public IEnumerable<string> GetCourseName(int id)
        {
            var result = _courseRepo.GetAll()
            .Where(s => s.CourseId == id)
            .Select(s => s.CourseName);
            return result;
        }
        // Get: StudentController/Create
        public ActionResult Create()
        {
            ViewBag.Course = new SelectList(_courseRepo.GetAll(), "CourseId", "CourseName");
            return View();
        }
        // Post: StudentController/Create
        [HttpPost]
        public ActionResult Create(Student input)
        {
            try
            { 
                _studentRepo.Create(input);
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
            return View(_studentRepo.GetById(id));
        }
        // Post: StudentController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student input)
        {
            try
            {
                _studentRepo.Update(id, input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            return View(_studentRepo.GetById(id));
        }
        public ActionResult Delete(int id)
        {
            return View(_studentRepo.GetById(id));
        }
        // Post: StudentController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Student input)
        {
            try
            {
                _studentRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
