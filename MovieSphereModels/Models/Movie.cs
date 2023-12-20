

namespace MovieSphereModels.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseYear { get; set; }

    public string Description { get; set; }
    
    //NavigationProperties
    public ICollection<ApplicationUser>? UsersWhoFavourited { get; set; }
    public ICollection<ApplicationUser>? UsersInWatchlist { get; set; }
    public ICollection<Rating>? Ratings { get; set; }
    public ICollection<Comment>? Comments { get; set; }
}