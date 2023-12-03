using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models;

public class Course
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Tag { get; set; }
    
    //NavigationProperties
    public ICollection<ApplicationUser> UsersInCourse { get; set; }
}