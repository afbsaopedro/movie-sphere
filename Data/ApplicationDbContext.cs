using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieSphere.Models;
using System.Reflection.Emit;

namespace MovieSphere.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get;set; }
        public DbSet<CourseType> CourseTypes { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.FavouriteMovies)
                .WithMany(m => m.UsersWhoFavourited)
                .UsingEntity(um => um.ToTable("UsersFavourited"));

            modelBuilder.Entity<ApplicationUser>()
                .HasMany(u => u.Watchlist)
                .WithMany(m => m.UsersInWatchlist)
                .UsingEntity( um => um.ToTable("UsersWatchlist"));

            modelBuilder.Entity<CourseType>().HasData(
                new CourseType { Id = 1, Type = "Licenciatura" },
                new CourseType { Id = 2, Type = "Mestrado"},
                new CourseType { Id = 3, Type = "CTeSP" },
                new CourseType { Id = 4, Type = "Pós-Graduação" }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Administração de Publicidade e Marketing", Tag = "APM", CourseTypeId = 1 },
                new Course { Id = 2, Name = "Design de Animação", Tag = "DA", CourseTypeId = 1 },
                new Course { Id = 3, Name = "Design de Comunicação", Tag = "DC", CourseTypeId = 1 },
                new Course { Id = 4, Name = "Engenharia Civil", Tag = "EC", CourseTypeId = 1 },
                new Course { Id = 5, Name = "Engenharia de Produção de Biocombustíveis", Tag = "EPBio", CourseTypeId = 1 },
                new Course { Id = 6, Name = "Engenharia Informática", Tag = "EI", CourseTypeId = 1 },
                new Course { Id = 7, Name = "Gestão", Tag = "Ges", CourseTypeId = 1 },
                new Course { Id = 8, Name = "Gestão (pós-laboral)", Tag = "GesPL", CourseTypeId = 1 },
                new Course { Id = 9, Name = "Contabilidade e Finanças", Tag = "CF", CourseTypeId = 2 },
                new Course { Id = 10, Name = "Design de Identidade Digital", Tag = "DID", CourseTypeId = 2 },
                new Course { Id = 11, Name = "Gestão de Pequenas e Médias Empresas", Tag = "GPME", CourseTypeId = 2 },
                new Course { Id = 12, Name = "Informática", Tag = "Info", CourseTypeId = 2 },
                new Course { Id = 13, Name = "Tecnologias de Valorização Ambiental e Produção de Energia", Tag = "TVAPE", CourseTypeId = 2 },
                new Course { Id = 14, Name = "Animação e Produção 3D", Tag = "AP3D", CourseTypeId = 3 },
                new Course { Id = 15, Name = "Bioenergias", Tag = "BioEn", CourseTypeId = 3 },
                new Course { Id = 16, Name = "Construção e Reabilitação de Edifícios", Tag = "CRE", CourseTypeId = 3 },
                new Course { Id = 17, Name = "Contabilidade", Tag = "Conta", CourseTypeId = 3 },
                new Course { Id = 18, Name = "Desenvolvimento para a Web e Dispositivos Móveis", Tag = "DWDM", CourseTypeId = 3 },
                new Course { Id = 19, Name = "Design de Som e Produção Musical", Tag = "DSPM", CourseTypeId = 3 },
                new Course { Id = 20, Name = "Design Multimédia e Audiovisuais", Tag = "DMA", CourseTypeId = 3 },
                new Course { Id = 21, Name = "Gestão de Vendas e Marketing", Tag = "GVM", CourseTypeId = 3 },
                new Course { Id = 22, Name = "Manutenção Eletromecânica", Tag = "ME", CourseTypeId = 3 },
                new Course { Id = 23, Name = "Programação Ágil e Segurança de Sistemas de Informação", Tag = "PASSI", CourseTypeId = 3 },
                new Course { Id = 24, Name = "Secretariado de Administração", Tag = "SecAmin", CourseTypeId = 3 },
                new Course { Id = 25, Name = "Tecnologias e Programação de Sistemas de Informação", Tag = "TPSI", CourseTypeId = 3 },
                new Course { Id = 26, Name = "Animação", Tag = "Anim", CourseTypeId = 4 },
                new Course { Id = 27, Name = "Data Science and Digital Transformation", Tag = "DSDT", CourseTypeId = 4 },
                new Course { Id = 28, Name = "Hidrogénio", Tag = "Hidro", CourseTypeId = 4 },
                new Course { Id = 29, Name = "Renewable Energies and Environment", Tag = "REE", CourseTypeId = 4 }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
