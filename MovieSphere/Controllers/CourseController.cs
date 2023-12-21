using Microsoft.AspNetCore.Mvc;
using MovieSphereDataAccess.Data;
using MovieSphereModels.Models;
using MovieSphereDataAccess.Repository.IRepository;

namespace MovieSphere.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository db)
        {
            _courseRepository = db;
        }

        // Index Actions
        public IActionResult Index()
        {
            List<Course> objCourseList = _courseRepository.GetAll().ToList();
            return View(objCourseList);
        }

        // Create Actions
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course obj)
        {
            // Way to do custom validation
            if(obj.Name.ToLower() == obj.Tag.ToLower())
            {
                ModelState.AddModelError("Name", "The course name can not be the same as the course tag");
                ModelState.AddModelError("Tag", "The course tag can not be the same as the course name");
            }

            // Second custom validation
            if (obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is an invalid value");
            }

            if (ModelState.IsValid)
            {
                _courseRepository.Add(obj);
                _courseRepository.Save();
                TempData["success"] = "Course created successfully";
                return RedirectToAction("Index");
            }

            return View();
        }

        // Edit Actions
        public IActionResult Edit(int? Id)
        {
            if(Id == null || Id == 0)
            {
                return NotFound();
            }

            // Several ways to find and retrieve what you want from the database
            //
            Course CourseFromDb = _courseRepository.Get(c => c.Id == Id);
            //Course CourseFromDb = _db.Courses.Find(Id);
            //Course CourseFromDb = _db.Courses.Where(c=>c.Id==Id).FirstOrDefault();
            

            if (CourseFromDb == null)
            {
                return NotFound();
            }

            return View(CourseFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Course obj)
        {

            if (ModelState.IsValid)
            {
                _courseRepository.Update(obj);
                _courseRepository.Save();
                TempData["success"] = "Course updated successfully";
                return RedirectToAction("Index");
            }

            return View();
        }



        // Delete Actions
        public IActionResult Delete(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            Course CourseFromDb = _courseRepository.Get(c => c.Id == Id);

            if (CourseFromDb == null)
            {
                return NotFound();
            }

            return View(CourseFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {
            Course obj = _courseRepository.Get(c => c.Id == Id);

            if (obj == null)
            {
                return NotFound();
            }

            _courseRepository.Remove(obj);
            _courseRepository.Save();

            TempData["success"] = "Course deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
