

namespace MovieSphere.Models;

public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; }

    //ForeignKeys
    public int MovieId { get; set; }
    public string UserId { get; set; }

    // NavigationProperties
    public Movie Movie { get; set; }
    public ApplicationUser User { get; set; }
}