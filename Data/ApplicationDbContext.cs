﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApplicationUser>()
            .HasMany(au => au.FavouriteMovies)
            .WithMany(m => m.UsersWhoFavourited)
            .UsingEntity(j => j.ToTable("UserFavouriteMovies"));

        modelBuilder.Entity<ApplicationUser>()
            .HasMany(au => au.Watchlist)
            .WithMany(m => m.UsersInWatchlist)
            .UsingEntity(j => j.ToTable("UserWatchlist"));

        modelBuilder.Entity<ApplicationUser>()
            .HasOne(au => au.Course)
            .WithMany(c => c.UsersInCourse)
            .HasForeignKey(au => au.CourseId);
        
        base.OnModelCreating(modelBuilder);
    }
}