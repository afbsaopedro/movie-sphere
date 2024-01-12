using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using MovieSphere.Data;
using MovieSphere.Dto;
using MovieSphere.Models;
using System.Text.Json;

namespace MovieSphere.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;
        private readonly ApplicationDbContext _applicationDbContext;

        public MovieService(HttpClient httpClient, ApplicationDbContext applicationDbContext)
        {
            _httpClient = httpClient;
            _applicationDbContext = applicationDbContext;
        }

        public async Task<MoviesResponse> FindMovie(string query, int page)
        {
            var response = await _httpClient.GetFromJsonAsync<MoviesResponse>($"search/movie?api_key=78e79bb8d580d1c4f9fd02f5d3ebe37f&query={query}&include_adult=false&language=en-US&page={page}&");

            return response;
        }

        public async Task<Dto.Movie> GetMovieById(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<Dto.Movie>($"movie/{id}?language=en-US&api_key=78e79bb8d580d1c4f9fd02f5d3ebe37f");

            var movie = await _applicationDbContext.Movies
                .Include(m => m.UsersWhoFavourited)
                .Include(m => m.UsersInWatchlist)
                .Include(m => m.Comments)
                .ThenInclude(c => c.ApplicationUser)
                .Include(m => m.Ratings)
                .FirstOrDefaultAsync(x => x.ApiReference == id);

            if (movie == null)
            {
                movie = new Models.Movie();
                movie.ApiReference = id;
                _applicationDbContext.Movies.Add(movie);
                await _applicationDbContext.SaveChangesAsync();
            }

            if (movie.Comments is not null)
            {
                response.Comments = movie.Comments;
            }
            if (movie.Ratings is not null)
            {
                response.Ratings = movie.Ratings;
            }
            if (movie.UsersWhoFavourited is not null)
            {
                response.UsersWhoFavourited = movie.UsersWhoFavourited;
            }
            if (movie.UsersInWatchlist is not null)
            {
                response.UsersInWatchlist = movie.UsersInWatchlist;
            }

            return response;
        }

        public async Task<MoviesResponse> PopularMovies(int page)
        {
            var response = await _httpClient.GetFromJsonAsync<MoviesResponse>($"movie/popular?api_key=78e79bb8d580d1c4f9fd02f5d3ebe37f&language=en-US&page={page}");

            return response;
        }
    }
}
