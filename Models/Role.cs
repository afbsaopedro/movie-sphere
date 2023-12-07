using Microsoft.AspNetCore.Identity;

namespace MovieSphere.Models;

public class Role : IdentityRole
{
    public string Tag { get; set; }
    
    public ICollection<ApplicationUser> UsersWithRole { get; set; }
}