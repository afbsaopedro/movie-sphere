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
    public DbSet<Role> Roles { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Rating> Ratings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comment>()
            .HasOne(c => c.Movie)
            .WithMany(m => m.Comments)
            .HasForeignKey(c => c.MovieId);

        modelBuilder.Entity<Comment>()
            .HasOne(c => c.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.UserId);
        
        modelBuilder.Entity<Course>()
            .HasMany(c => c.UsersInCourse)
            .WithOne(u => u.Course)
            .HasForeignKey(u => u.CourseId);

        modelBuilder.Entity<Movie>()
            .HasMany(m => m.UsersWhoFavourited)
            .WithMany(u => u.FavouriteMovies)
            .UsingEntity(join => join.ToTable("UsersFavourites"));

        modelBuilder.Entity<Movie>()
            .HasMany(m => m.UsersInWatchlist)
            .WithMany(u => u.Watchlist)
            .UsingEntity(join => join.ToTable("UsersWatchlist"));

        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Ratings)
            .WithOne(r => r.Movie)
            .HasForeignKey(r => r.MovieId);

        modelBuilder.Entity<Movie>()
            .HasMany(m => m.Comments)
            .WithOne(c => c.Movie)
            .HasForeignKey(c => c.MovieId);

        modelBuilder.Entity<Rating>()
            .HasOne(r => r.Movie)
            .WithMany(m => m.Ratings)
            .HasForeignKey(r => r.MovieId);

        modelBuilder.Entity<Rating>()
            .HasOne(r => r.User)
            .WithMany(u => u.Ratings)
            .HasForeignKey(r => r.UserId);

        modelBuilder.Entity<ApplicationUser>()
            .HasOne(u => u.Course)
            .WithMany(c => c.UsersInCourse)
            .HasForeignKey(u => u.CourseId);

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(u => u.FavouriteMovies)
            .WithMany(m => m.UsersWhoFavourited)
            .UsingEntity(join => join.ToTable("UsersFavourites"));

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(u => u.Watchlist)
            .WithMany(m => m.UsersInWatchlist)
            .UsingEntity(join => join.ToTable("UsersWatchlist"));

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(u => u.Ratings)
            .WithOne(r => r.User)
            .HasForeignKey(r => r.UserId);

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(u => u.Comments)
            .WithOne(c => c.User)
            .HasForeignKey(c => c.UserId);

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(u => u.Roles)
            .WithMany(r => r.UsersWithRole)
            .UsingEntity(join => join.ToTable("UserRoles"));

        modelBuilder.Entity<Role>()
            .HasMany(r => r.UsersWithRole)
            .WithMany(u => u.Roles)
            .UsingEntity(join => join.ToTable("UserRoles"));
            
        base.OnModelCreating(modelBuilder);
    }
}