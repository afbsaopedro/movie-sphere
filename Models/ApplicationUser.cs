using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSphere.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? DisplayName { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? PlaceOfOrigin { get; set; }
        public string? Bio { get; set; }
        public bool? IsPrivate { get; set; }

        //ForeignKeys
        public int? CourseId { get; set; }

        //NavigationProperties
        public ICollection<Movie>? FavouriteMovies { get; set; }
        public ICollection<Movie>? Watchlist { get; set; }
        public ICollection<Rating>? Ratings { get; set; }
        public ICollection<Comment>? Comments { get; set; }

        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
    }
}
