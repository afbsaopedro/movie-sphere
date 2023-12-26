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
    public class CourseTypeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CourseTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CourseType
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseTypes.ToListAsync());
        }

        // GET: CourseType/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseType = await _context.CourseTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseType == null)
            {
                return NotFound();
            }

            return View(courseType);
        }

        // GET: CourseType/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourseType/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Type")] CourseType courseType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseType);
        }

        // GET: CourseType/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseType = await _context.CourseTypes.FindAsync(id);
            if (courseType == null)
            {
                return NotFound();
            }
            return View(courseType);
        }

        // POST: CourseType/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Type")] CourseType courseType)
        {
            if (id != courseType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseTypeExists(courseType.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(courseType);
        }

        // GET: CourseType/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseType = await _context.CourseTypes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseType == null)
            {
                return NotFound();
            }

            return View(courseType);
        }

        // POST: CourseType/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseType = await _context.CourseTypes.FindAsync(id);
            if (courseType != null)
            {
                _context.CourseTypes.Remove(courseType);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseTypeExists(int id)
        {
            return _context.CourseTypes.Any(e => e.Id == id);
        }
    }
}
