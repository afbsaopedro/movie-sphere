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
            var movies = await _movieService.PopularMovies(page ?? 1);

            return View(movies);
        }



        //Post
        public async Task<IActionResult> MovieSearch(int? page, string query)
        {
            var movies = await _movieService.FindMovie(query ?? "", page ?? 1);

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

            if (user.Watchlist == null)
            {
                user.Watchlist = new List<Models.Movie>();
            }

            user.Watchlist.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> AddToFavourites(IFormCollection collection)
        {
            var movieId = int.Parse(collection["Id"]);

            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.ApiReference == movieId);

            var user = await _userManager.GetUserAsync(User);

            if (user.FavouriteMovies == null)
            {
                user.FavouriteMovies = new List<Models.Movie>();
            }

            user.FavouriteMovies.Add(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> RemoveFromFavourites(IFormCollection collection)
        {
            var movieId = int.Parse(collection["Id"]);

            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.ApiReference == movieId);

            var user = await _userManager.Users.Include(m => m.FavouriteMovies).FirstAsync(u => u.Id == _userManager.GetUserId(User));

            user.FavouriteMovies.Remove(movie);
            await _context.SaveChangesAsync();


            return RedirectToAction("Profile", "Account");
        }

        public async Task<IActionResult> RemoveFromWatchlist(IFormCollection collection)
        {
            var movieId = int.Parse(collection["Id"]);

            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.ApiReference == movieId);

            var user = await _userManager.Users.Include(m => m.Watchlist).FirstAsync(u => u.Id == _userManager.GetUserId(User));

            user.Watchlist.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction("Profile", "Account");
        }

        public async Task<IActionResult> Rate(IFormCollection collection)
        {
            var movieId = int.Parse(collection["Id"]);
            var movie = await _context.Movies
                .Include(m => m.Ratings)
                .FirstOrDefaultAsync(m => m.ApiReference == movieId);
            var user = await _userManager.GetUserAsync(User);

            movie.Ratings ??= [];

            var rating = movie.Ratings.FirstOrDefault(r => r.ApplicationUser == user);
            if (rating != null)
            {
                rating.Score = int.Parse(collection["Score"]);
            }
            else
            {
                rating = new Rating
                {
                    ApplicationUser = user,
                    Score = int.Parse(collection["Score"])
                };
                movie.Ratings.Add(rating);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Movie", new { id = movieId });
        }

        public async Task<IActionResult> AddComment(IFormCollection collection)
        {
            var movieId = int.Parse(collection["Id"]);
            var movie = await _context.Movies
                .Include(m => m.Comments)
                .FirstOrDefaultAsync(m => m.ApiReference == movieId);
            var user = await _userManager.GetUserAsync(User);

            movie.Comments ??= [];

            var comment = new Comment
            {
                ApplicationUser = user,
                Content = collection["Content"]
            };

            movie.Comments.Add(comment);

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Movie", new { id = movieId });
        }
    }
}
