using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieSphere.Models;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using System.Text;

namespace MovieSphere.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Course> Courses { get; set; }
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
                .UsingEntity(um => um.ToTable("UsersWatchlist"));

            modelBuilder.Entity<CourseType>().HasData(
                new CourseType { Id = 1, Type = "Licenciatura" },
                new CourseType { Id = 2, Type = "Mestrado" },
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

            string dev = "Developer";
            string admn = "Admin";
            string mnger = "Manager";

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "49379abf-f146-406b-9ef7-059723ba41a9", Name = dev, NormalizedName = dev.ToUpper() },
                new IdentityRole { Name = admn, NormalizedName = admn.ToUpper() },
                new IdentityRole { Name = mnger, NormalizedName = mnger.ToUpper() }
            );

            var pwdHasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "2a5da078-3a9c-4636-a2d9-45014ccc5815",
                    UserName = "d.olival@moviesphere.com",
                    Email = "d.olival@moviesphere.com",
                    NormalizedEmail = "D.OLIVAL@MOVIESPHERE.COM",
                    NormalizedUserName = "D.OLIVAL@MOVIESPHERE.COM",
                    PasswordHash = pwdHasher.HashPassword(null, "dolival"),
                    DisplayName = "dolival",
                    CreationDate = DateTime.Now,
                    FirstName = "Diogo",
                    LastName = "Olival",
                    DateOfBirth = new DateOnly(1991, 1, 2),
                    PlaceOfOrigin = "Madeira",
                    Bio = "Teacher @ ESTG.",
                    IsPrivate = true,
                    CourseId = 6,
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "f8c79463-5df6-4736-a0ba-87218377f287",
                    UserName = "leonor.caldeira@moviesphere.com",
                    Email = "leonor.caldeira@moviesphere.com",
                    NormalizedEmail = "leonor.caldeira@moviesphere.com".ToUpper(),
                    NormalizedUserName = "leonor.caldeira@moviesphere.com".ToUpper(),
                    PasswordHash = pwdHasher.HashPassword(null, "leonor"),
                    DisplayName = "Leo-caldeira",
                    CreationDate = DateTime.Now,
                    FirstName = "Leonor",
                    LastName = "Caldeira",
                    DateOfBirth = new DateOnly(1991, 1, 2),
                    PlaceOfOrigin = "Portalegre",
                    Bio = "CTeSP TPSI! Brevemente Engenharia Informática!",
                    IsPrivate = true,
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "8426038e-905e-4397-a95d-98a4a10b8231",
                    UserName = "andre.saopedro@moviesphere.com",
                    Email = "andre.saopedro@moviesphere.com",
                    NormalizedEmail = "andre.saopedro@moviesphere.com".ToUpper(),
                    NormalizedUserName = "andre.saopedro@moviesphere.com".ToUpper(),
                    PasswordHash = pwdHasher.HashPassword(null, "andre"),
                    DisplayName = "afbsaopedro",
                    CreationDate = DateTime.Now,
                    FirstName = "André",
                    LastName = "São Pedro",
                    DateOfBirth = new DateOnly(1996, 11, 30),
                    PlaceOfOrigin = "Portalegre",
                    Bio = "Movie Sphere",
                    IsPrivate = true,
                    EmailConfirmed = true
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "49379abf-f146-406b-9ef7-059723ba41a9",
                    UserId = "2a5da078-3a9c-4636-a2d9-45014ccc5815"
                }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    ApiReference = 872585
                },
                new Movie
                {
                    Id = 2,
                    ApiReference = 76600
                },
                new Movie
                {
                    Id = 3,
                    ApiReference = 507089
                }
            );

            modelBuilder.Entity<Rating>().HasData(
                new Rating
                {
                    Id = 1,
                    Score = 5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MovieId = 1,
                    ApplicationUserId = "8426038e-905e-4397-a95d-98a4a10b8231"
                }
            );

            modelBuilder.Entity<Comment>().HasData(
                new Comment
                {
                    Id = 1,
                    Content = "The best movie of 2023!",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MovieId = 1,
                    ApplicationUserId = "8426038e-905e-4397-a95d-98a4a10b8231"
                },
                new Comment
                {
                    Id = 2,
                    Content = "Não achei piada nenhuma. Nem sei que pontuação dar...",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    MovieId = 3,
                    ApplicationUserId = "f8c79463-5df6-4736-a0ba-87218377f287"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
