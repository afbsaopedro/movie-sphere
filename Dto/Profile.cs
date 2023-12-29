using MovieSphere.Models;

namespace MovieSphere.Dto
{
    public record Profile(ApplicationUser user, IEnumerable<Movie> favourites, IEnumerable<Movie> watchlist);
}
