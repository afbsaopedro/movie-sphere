using System.ComponentModel;

namespace MovieSphere.Models;

public class Comment
{
    [DisplayName("ID")]
    public Guid? Id { get; set; }
    
    [DisplayName("Content")]
    public string? Content { get; set; }

    //ForeignKeys
    [DisplayName("Movie ID")]
    public Guid? MovieId { get; set; }
    
    [DisplayName("User's ID")]
    public string? UserId { get; set; }

    // NavigationProperties
    [DisplayName("Movie")]
    public Movie? Movie { get; set; }
    
    [DisplayName("User")]
    public ApplicationUser? User { get; set; }
}