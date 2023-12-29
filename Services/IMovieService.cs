using MovieSphere.Dto;

namespace MovieSphere.Services
{
    public interface IMovieService
    {
        public Task<MoviesResponse> FindMovie(string query, int page);
        public Task<Movie> GetMovieById(int id);

        public Task<MoviesResponse> PopularMovies(int page);
    }
}
