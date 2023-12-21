

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSphereModels.Models;

public class Movie
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Display(Name = "Year of Release")]
    public int ReleaseYear { get; set; } // Change to DateTime instead of int

    public string Description { get; set; }

    public string ImageUrl {  get; set; }

    //NavigationProperties
    [NotMapped]
    public ICollection<ApplicationUser>? UsersWhoFavourited { get; set; }

    [NotMapped]
    public ICollection<ApplicationUser>? UsersInWatchlist { get; set; }

    [NotMapped]
    public ICollection<Rating>? Ratings { get; set; }

    [NotMapped]
    public ICollection<Comment>? Comments { get; set; }
}