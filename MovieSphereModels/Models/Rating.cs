

namespace MovieSphereModels.Models;

public class Rating
{
    public int Id { get; set; }
    public int Score { get; set; }

    //ForeignKeys
    public int MovieId { get; set; }
    public string UserId { get; set; }

    //NavigationProperties
    public Movie Movie { get; set; }
    public ApplicationUser User { get; set; }
}