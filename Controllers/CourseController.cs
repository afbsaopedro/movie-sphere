using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieSphere.Data;
using MovieSphere.Models;

namespace MovieSphere.Controllers
{
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CourseController(ApplicationDbContext context)
        {
            _applicationDbContext = context;
        }

        // GET: Course
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _applicationDbContext.Courses.Include(c => c.CourseType);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Course/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _applicationDbContext.Courses
                .Include(c => c.CourseType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Course/Create
        public IActionResult Create()
        {
            ViewData["CourseTypeId"] = new SelectList(_applicationDbContext.CourseTypes, "Id", "Id");
            return View();
        }

        // POST: Course/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            if (ModelState.IsValid)
            {
                Course newCourse = new Course();

                newCourse.Name = collection["Name"];
                newCourse.Tag = collection["Tag"];
                newCourse.CourseTypeId = int.Parse(collection["CourseTypeId"]);

                ViewData["CourseTypeId"] = new SelectList(_applicationDbContext.CourseTypes, "Id", "Type", newCourse.CourseTypeId);

                _applicationDbContext.Courses.Add(newCourse);
                _applicationDbContext.SaveChanges();

                return RedirectToAction(nameof(Details), new {id = newCourse.Id});
            }
            
            return RedirectToAction(nameof(Index));
        }

        // GET: Course/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _applicationDbContext.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            ViewData["CourseTypeId"] = new SelectList(_applicationDbContext.CourseTypes, "Id", "Id", course.CourseTypeId);
            return View(course);
        }

        // POST: Course/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            Course course = new Course();
            course.Id = id;
            course.Name = collection["Name"];
            course.Tag = collection["Tag"];
            course.CourseTypeId = int.Parse(collection["CourseTypeId"]);

            if (id != course.Id)
            {
                return NotFound();
            }

            try
            {
                if (ModelState.IsValid)
                {
                    _applicationDbContext.Courses.Update(course);
                    _applicationDbContext.SaveChanges();

                    return RedirectToAction(nameof(Details), new { id = course.Id });
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _applicationDbContext.Courses
                .Include(c => c.CourseType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Course/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _applicationDbContext.Courses.FindAsync(id);
            if (course != null)
            {
                _applicationDbContext.Courses.Remove(course);
            }

            await _applicationDbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _applicationDbContext.Courses.Any(e => e.Id == id);
        }
    }
}
