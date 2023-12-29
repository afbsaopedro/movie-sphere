using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using MovieSphere.Models;
using System.Text.Json;

namespace MovieSphere.Services
{
    public class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MoviesResponse> FindMovie(string query, int page)
        {
            var request = await _httpClient.GetAsync($"search/movie?api_key=78e79bb8d580d1c4f9fd02f5d3ebe37f&query={query}&include_adult=false&language=en-US&page={page}");

            var content = await request.Content.ReadAsStringAsync();

            var response = JsonSerializer.Deserialize<MoviesResponse>(content);

            return response;
        }

        public async Task<Movie> GetMovieById(int id)
        {
            var request = await _httpClient.GetAsync($"movie/{id}?language=en-US&api_key=78e79bb8d580d1c4f9fd02f5d3ebe37f");

            var content = await request.Content.ReadAsStringAsync();

            var response = JsonSerializer.Deserialize<Movie>(content);

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
