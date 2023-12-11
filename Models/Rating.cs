using System.ComponentModel;

namespace MovieSphere.Models;

public class Rating
{
    [DisplayName("ID")]
    public Guid? RatingId { get; set; }
    
    [DisplayName("Rating Score")]
    public int? Score { get; set; }

    //ForeignKeys
    [DisplayName("Movie ID")]
    public Guid? MovieId { get; set; }
    
    [DisplayName("User ID")]
    public string? UserId { get; set; }

    //NavigationProperties
    [DisplayName("Movie")]
    public Movie? Movie { get; set; }
    
    [DisplayName("User")]
    public ApplicationUser? User { get; set; }
}