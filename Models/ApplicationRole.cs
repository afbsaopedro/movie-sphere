using Microsoft.AspNetCore.Identity;

namespace MovieSphere.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string Tag { get; set; }
    }
}
