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
            var request = await _httpClient.GetAsync($"search/movie?api_key=78e79bb8d580d1c4f9fd02f5d3ebe37f&query={query}&include_adult=false&language=en-US&page={page}&");

            var content = await request.Content.ReadAsStringAsync();

            var response = JsonSerializer.Deserialize<MoviesResponse>(content);

            return response;
        }

        public async Task<Dto.Movie> GetMovieById(int id)
        {
            var request = await _httpClient.GetAsync($"movie/{id}?language=en-US&api_key=78e79bb8d580d1c4f9fd02f5d3ebe37f");

            var content = await request.Content.ReadAsStringAsync();

            var response = JsonSerializer.Deserialize<Dto.Movie>(content);

            var movie = await _applicationDbContext.Movies
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

            return response;
        }

        public async Task<MoviesResponse> PopularMovies(int page)
        {

            var request = await _httpClient.GetAsync($"movie/popular?api_key=78e79bb8d580d1c4f9fd02f5d3ebe37f&language=en-US&page={page}");

            var content = await request.Content.ReadAsStringAsync();

            var response = JsonSerializer.Deserialize<MoviesResponse>(content);

            return response;
        }
    }
}
