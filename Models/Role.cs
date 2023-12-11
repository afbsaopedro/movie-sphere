using System.ComponentModel;
using Microsoft.AspNetCore.Identity;

namespace MovieSphere.Models;

public class Role : IdentityRole
{
    [DisplayName("Role Tag")]
    public string? Tag { get; set; }
    
    [DisplayName("Users with role")]
    public ICollection<ApplicationUser>? UsersWithRole { get; set; }
}