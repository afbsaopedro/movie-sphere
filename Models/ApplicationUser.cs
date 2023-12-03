using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MovieSphere.Models;

public class ApplicationUser : IdentityUser
{
    public DateTime CreationDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string CountryOfOrigin { get; set; }
    public string PlaceOfOrigin { get; set; }
    public string Bio { get; set; }
    public bool IsPrivate { get; set; }
    
    //NavigationProperties
    public ICollection<Movie> FavouriteMovies { get; set; }
    public ICollection<Movie> Watchlist { get; set; }
    [ForeignKey("Course")]
    public Guid CourseId { get; set; }
    public Course Course { get; set; }
}