using Microsoft.EntityFrameworkCore;
using MovieSphere.Models;

namespace MovieSphere.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Tecnologias e Programação de Sistemas de Informação",Tag = "TPSI"},
                new Course { Id = 2, Name = "Engenharia Informática", Tag = "EI" },
                new Course { Id = 3, Name = "Gestão", Tag = "Ges" }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
