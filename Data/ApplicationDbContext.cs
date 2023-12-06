using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieSphere.Models;

namespace MovieSphere.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Rating> Ratings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilders go here MISSING !!!!!
        
        base.OnModelCreating(modelBuilder);
    }
}