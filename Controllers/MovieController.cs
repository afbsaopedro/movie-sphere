using Microsoft.AspNetCore.Mvc;
using MovieSphere.Data;
using MovieSphere.Services;
using Microsoft.AspNetCore.Identity;
using MovieSphere.Models;
using Microsoft.EntityFrameworkCore;

namespace MovieSphere.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMovieService _movieService;
        private UserManager<ApplicationUser> _userManager;

        public MovieController(ApplicationDbContext context, IMovieService movieService, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _movieService = movieService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Popular(int? page)
        {
            var movies = await _movieService.PopularMovies(page??1);

            return View(movies);
        }



        //Post
        public async Task<IActionResult> MovieSearch(int? page, string query)
        {
            var movies = await _movieService.FindMovie(query??"", page ?? 1);

            return View(movies);
        }

        public async Task<IActionResult> Details(int id)
        {
            var movie = await _movieService.GetMovieById(id);

            return View(movie);
        }

        public async Task<IActionResult> AddToWatchlist(IFormCollection collection)
        {
            var movieId = int.Parse(collection["Id"]);

            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.ApiReference == movieId);

            var user = await _userManager.GetUserAsync(User);


            if (movie == null)
            {
                movie = new Models.Movie();
                movie.ApiReference = movieId;
                _context.Movies.Add(movie);
            }

            if (user.Watchlist == null) {
                user.Watchlist = new List<Models.Movie>();
            }

            user.Watchlist.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
