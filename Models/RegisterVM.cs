using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MovieSphere.Models
{
    public class RegisterVM
    {
        [Display(Name = "E-mail Address")]
        [Required(ErrorMessage = "E-mail address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirming password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }



        [DisplayName("Display Name")]
        public string? DisplayName { get; set; }

        public DateTime? CreationDate { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string? FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string? LastName { get; set; }

        [DisplayName("Birthday")]
        public DateTime? DateOfBirth { get; set; }

        [DisplayName("Where are you from?")]
        public string? PlaceOfOrigin { get; set; }
        public string? Bio { get; set; }
        public bool? IsPrivate { get; set; }
        public int? CourseId { get; set; }

    }
}
