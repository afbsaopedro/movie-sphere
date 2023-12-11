using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MovieSphere.Models;

public class ApplicationUser : IdentityUser
{
    [DisplayName("Creation Date")]
    public DateTime? CreationDate { get; set; }
    
    [DisplayName("First Name")]
    public string? FirstName { get; set; }
    
    [DisplayName("Last Name")]
    public string? LastName { get; set; }
    
    [DisplayName("Date of Birth")]
    public DateTime? DateOfBirth { get; set; }
    
    [DisplayName("Origin")]
    public string? PlaceOfOrigin { get; set; }
    
    [DisplayName("Biography")]
    public string? Bio { get; set; }
    
    [DisplayName("Is the profile private?")]
    public bool? IsPrivate { get; set; }
    
    //ForeignKeys
    [DisplayName("Course ID")]
    public Guid? CourseId { get; set; }
    
    //NavigationProperties
    [DisplayName("Favourite Movies")]
    public ICollection<Movie>? FavouriteMovies { get; set; }
    
    [DisplayName("Watchlist")]
    public ICollection<Movie>? Watchlist { get; set; }
    
    [DisplayName("User's Ratings")]
    public ICollection<Rating>? Ratings { get; set; }
    
    [DisplayName("User's Comments")]
    public ICollection<Comment>? Comments { get; set; }
    
    [DisplayName("User's Course")]
    public Course? Course { get; set; }
    
    [DisplayName("User's Roles")]
    public ICollection<Role>? Roles { get; set; }

}