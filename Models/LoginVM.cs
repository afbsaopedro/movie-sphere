using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models
{
    public class LoginVM
    {
        [DisplayName("E-mail Address")]
        [Required(ErrorMessage = "E-mail address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
