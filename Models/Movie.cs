using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models;

public class Movie
{
    public Guid? Id { get; set; }
    public string? Title { get; set; }
    public DateTime? ReleaseYear { get; set; }
    
    //NavigationProperties
    public ICollection<ApplicationUser>? UsersWhoFavourited { get; set; }
    public ICollection<ApplicationUser>? UsersInWatchlist { get; set; }
    public ICollection<Rating>? Ratings { get; set; }
    public ICollection<Comment>? Comments { get; set; }
}