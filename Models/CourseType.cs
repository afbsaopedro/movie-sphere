using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models
{
    public class CourseType
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }

        public string Type { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
