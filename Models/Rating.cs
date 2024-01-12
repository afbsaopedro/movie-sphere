using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSphere.Models
{
    public class Rating
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        public int Score { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        //ForeignKeys
        [DisplayName("Movie ID")]
        public int MovieId { get; set; }

        [DisplayName("User ID")]
        public string ApplicationUserId { get; set; }

        //NavigationProperties
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
