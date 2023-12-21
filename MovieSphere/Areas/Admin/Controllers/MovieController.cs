using Microsoft.AspNetCore.Mvc;
using MovieSphereDataAccess.Data;
using MovieSphereModels.Models;
using MovieSphereDataAccess.Repository.IRepository;

namespace MovieSphere.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MovieController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // Index Actions
        public IActionResult Index()
        {
            List<Movie> objMovieList = _unitOfWork.Movie.GetAll().ToList();
            return View(objMovieList);
        }

        // Create Actions
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie obj)
        {

            // Second custom validation
            if (obj.Title.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test is an invalid value");
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.Movie.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Movie created successfully";
                return RedirectToAction("Index");
            }

            return View();
        }

        // Edit Actions
        public IActionResult Edit(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }

            // Several ways to find and retrieve what you want from the database
            //
            Movie MovieFromDb = _unitOfWork.Movie.Get(c => c.Id == Id);


            if (MovieFromDb == null)
            {
                return NotFound();
            }

            return View(MovieFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Movie obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Movie.Update(obj);
                _unitOfWork.Save();
                TempData["success"] = "Movie updated successfully";
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

            Movie MovieFromDb = _unitOfWork.Movie.Get(c => c.Id == Id);

            if (MovieFromDb == null)
            {
                return NotFound();
            }

            return View(MovieFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? Id)
        {
            Movie obj = _unitOfWork.Movie.Get(c => c.Id == Id);

            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Movie.Remove(obj);
            _unitOfWork.Save();

            TempData["success"] = "Movie deleted successfully";
            return RedirectToAction("Index");
        }
    }
}
