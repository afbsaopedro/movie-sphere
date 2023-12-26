using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models
{
    public class Movie
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("API Reference")]
        public string ApiReference { get; set; }

        //NavigationProperties
        public ICollection<ApplicationUser> UsersWhoFavourited { get; set; }
        public ICollection<ApplicationUser> UsersInWatchlist { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public ICollection<Comment> Comments { get;}
    }
}
