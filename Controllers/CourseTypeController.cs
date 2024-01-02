using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieSphere.Data;
using MovieSphere.Models;

namespace MovieSphere.Controllers
{
    [Authorize(Roles = "Admin, Developer")]
    public class CourseTypeController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CourseTypeController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        // GET: CourseTypeController
        public ActionResult Index()
        {
            var data = _applicationDbContext.CourseTypes.ToList();
            return View(data);
        }

        // GET: CourseTypeController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = _applicationDbContext.CourseTypes.FirstOrDefault(ct => ct.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: CourseTypeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseTypeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    CourseType newCourseType = new CourseType();

                    newCourseType.Type = collection["Type"];

                    _applicationDbContext.CourseTypes.Add(newCourseType);
                    _applicationDbContext.SaveChanges();
                    return RedirectToAction(nameof(Details), new { id = newCourseType.Id });
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseTypeController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = _applicationDbContext.CourseTypes.FirstOrDefault(ct => ct.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: CourseTypeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            CourseType courseType = new CourseType();
            courseType.Id = int.Parse(collection["Id"]);
            courseType.Type = collection["Type"];

            if (id != courseType.Id)
            {
                return NotFound();
            }

            try
            {
                if (ModelState.IsValid)
                {
                    _applicationDbContext.Update(courseType);
                    _applicationDbContext.SaveChanges();

                    return RedirectToAction(nameof(Details), new { id = courseType.Id });
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseTypeController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = _applicationDbContext.CourseTypes.FirstOrDefault(ct => ct.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: CourseTypeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var courseType = _applicationDbContext.CourseTypes.FirstOrDefault(e => e.Id == id);

            if (courseType == null)
            {
                return NotFound();
            }

            _applicationDbContext.CourseTypes.Remove(courseType);
            _applicationDbContext.SaveChanges();

                return RedirectToAction(nameof(Index)); 
        }
    }
}
