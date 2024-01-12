using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieSphere.Data;
using MovieSphere.Dto;
using MovieSphere.Models;
using MovieSphere.Services;
using System.Diagnostics;

namespace MovieSphere.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IMovieService _movieService;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IMovieService movieService)
        {
            _logger = logger;
            _context = context;
            _movieService = movieService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Feed()
        {
            var ratings = _context.Ratings.ToList();
            var reviews = _context.Comments.ToList();

            var feedItems = new List<FeedItem>();

            foreach (var rating in ratings)
            {
                var dbMovie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == rating.MovieId);
                var movie = await _movieService.GetMovieById(dbMovie.ApiReference);
                var feedItem = new FeedItem(
                    FeedItemType.Rating,
                    rating.Score,
                    rating.ApplicationUser,
                    movie,
                    rating.UpdatedAt
                );

                feedItems.Add(feedItem);
            }

            foreach (var review in reviews)
            {
                var dbMovie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == review.MovieId);
                var movie = await _movieService.GetMovieById(dbMovie.ApiReference);
                var feedItem = new FeedItem(
                    FeedItemType.Review,
                    review.Content,
                    review.ApplicationUser,
                    movie,
                    review.UpdatedAt
                );

                feedItems.Add(feedItem);
            }

            var feed = new Feed(feedItems.OrderByDescending(i => i.CreatedAt).ToList());

            return View(feed);
        }
    }
}
