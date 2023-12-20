using System.ComponentModel.DataAnnotations;

namespace MovieSphereModels.Models;

public class ApplicationUser
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }






    public DateTime CreationDate { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfOrigin { get; set; }
    public string? Bio { get; set; }
    public bool IsPrivate { get; set; }
    
    //ForeignKeys
    public int CourseId { get; set; }
    
    //NavigationProperties
    public ICollection<Movie>? FavouriteMovies { get; set; }
    public ICollection<Movie>? Watchlist { get; set; }
    public ICollection<Rating>? Ratings { get; set; }
    public ICollection<Comment>? Comments { get; set; }
    public Course Course { get; set; }
}