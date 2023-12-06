using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models;

public class Course
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? Tag { get; set; }

    //NavigationProperties
    public ICollection<ApplicationUser>? UsersInCourse { get; set; }
}