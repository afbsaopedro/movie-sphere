

namespace MovieSphere.Models;

public class Course
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Tag { get; set; }

    //NavigationProperties
    public ICollection<ApplicationUser>? UsersInCourse { get; set; }
}