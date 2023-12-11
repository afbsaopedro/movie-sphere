using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models;

public class Course
{
    [DisplayName("ID")]
    public Guid? Id { get; set; }
    
    [DisplayName("Name")]
    public string? Name { get; set; }
    
    [DisplayName("Course Tag")]
    public string? Tag { get; set; }

    //NavigationProperties
    [DisplayName("Users in Course")]
    public ICollection<ApplicationUser>? UsersInCourse { get; set; }
}