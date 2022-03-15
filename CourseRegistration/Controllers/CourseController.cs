using CourseRegistration.Data.Interfaces;
using CourseRegistration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourse _courseRepo;
        private readonly IStudent _studentRepo;

        public CourseController(ICourse repo, IStudent studentRepo)
        {
            _courseRepo = repo;
            _studentRepo = studentRepo;
        }
        public IActionResult Index()
        {
            return View(_courseRepo.GetAll());
        }
        public IEnumerable<string> GetStudentByCourseId(int id)
        {
            var result = _studentRepo.GetAll()
            .Where(s => s.CourseId == id)
            .Select(s => s.FirstName + " " + s.LastName + "<br>");

            if (result == null || result.Count() == 0)
            {
                return new List<string> { "No student found!" };
            }
            return result;
        }
        // Get: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }
        // Post: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course input)
        {
            try
            {
                _courseRepo.Create(input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            return View(_courseRepo.GetById(id));
        }
        // Post: CourseController/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course input)
        {
            try
            {
                _courseRepo.Update(id, input);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            return View(_courseRepo.GetById(id));
        }
        public ActionResult Delete(int id)
        {
            return View(_courseRepo.GetById(id));
        }
        // Post: CourseController/Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Course input)
        {
            try
            {
                _courseRepo.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

