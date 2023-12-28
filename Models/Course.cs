using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MovieSphere.Models
{
    public class Course
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Course tag is mandatory")]
        public string Tag { get; set; }

        //ForeignKeys
        [DisplayName("Course Type ID")]
        public int CourseTypeId { get; set; }

        //NavigationProperties
        [ForeignKey("CourseTypeId")]
        [DisplayName("Type")]
        public CourseType CourseType { get; set; }
        public ICollection<ApplicationUser>? UsersInCourse { get; set; }
    }
}
