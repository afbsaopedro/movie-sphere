using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models;

public class Movie
{
    [DisplayName("ID")]
    public Guid? Id { get; set; }
    
    [DisplayName("Title")]
    public string? Title { get; set; }
    
    [DisplayName("Year of Release")]
    public DateTime? ReleaseYear { get; set; }
    
    //NavigationProperties
    [DisplayName("Users who favourited the movie")]
    public ICollection<ApplicationUser>? UsersWhoFavourited { get; set; }
    
    [DisplayName("Users with movie in watchlist")]
    public ICollection<ApplicationUser>? UsersInWatchlist { get; set; }
    
    [DisplayName("Movie Ratings")]
    public ICollection<Rating>? Ratings { get; set; }
    
    [DisplayName("Movie Comments")]
    public ICollection<Comment>? Comments { get; set; }
}