

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSphere.Models;

public class Course
{
    [Key]
    [DisplayName("ID")]
    public int Id { get; set; }

    [Required(ErrorMessage ="Course name is mandatory")]
    [DisplayName("Course Name")]
    [MaxLength(64, ErrorMessage = "Can not be longer than 64 characters")]
    [MinLength(5, ErrorMessage = "Must be at least 5 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage ="Course tag is mandatory")]
    [DisplayName("Course Tag")]
    [MaxLength(6,ErrorMessage ="Can not be longer than 6 characters")]
    [MinLength(2,ErrorMessage="Must be at least 2 characters")]
    public string Tag { get; set; }

    //NavigationProperties
    [NotMapped]
    public ICollection<ApplicationUser>? UsersInCourse { get; set; }
}