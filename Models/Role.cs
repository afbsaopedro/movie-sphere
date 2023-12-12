using System.Drawing;
using Microsoft.AspNetCore.Identity;

namespace MovieSphere.Models;

public class Role : IdentityRole
{
    public ICollection<ApplicationUser> UsersWithRole { get; set; }
}