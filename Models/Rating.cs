

namespace MovieSphere.Models;

public class Rating
{
    public Guid? RatingId { get; set; }
    public int? Score { get; set; }

    //ForeignKeys
    public Guid? MovieId { get; set; }
    public string? UserId { get; set; }

    //NavigationProperties
    public Movie? Movie { get; set; }
    public ApplicationUser? User { get; set; }
}