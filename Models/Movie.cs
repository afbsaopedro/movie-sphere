using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models;

public class Movie
{
    [Key]
    public Guid Id { get; set; }
    // public string ApiReference { get; set; } DUH
    public string Title { get; set; }
    public DateTime ReleaseYear { get; set; }
    
    //NavigationProperties
    public ICollection<ApplicationUser> UsersWhoFavourited { get; set; }
    public ICollection<ApplicationUser> UsersInWatchlist { get; set; }
}