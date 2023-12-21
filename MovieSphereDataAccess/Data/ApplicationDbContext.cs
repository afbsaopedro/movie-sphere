using Microsoft.EntityFrameworkCore;
using MovieSphereModels.Models;

namespace MovieSphereDataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Administração de Publicidade e Marketing", Tag = "APM"},
                new Course { Id = 2, Name = "Design de Animação", Tag = "DA" },
                new Course { Id = 3, Name = "Design de Comunicação", Tag = "DC" },
                new Course { Id = 4, Name = "Engenharia Civil", Tag = "EC" },
                new Course { Id = 5, Name = "Engenharia de Produção de Biocombustíveis", Tag = "EPBio" },
                new Course { Id = 6, Name = "Engenharia Informática", Tag = "EI" },
                new Course { Id = 7, Name = "Gestão", Tag = "Ges" },
                new Course { Id = 8, Name = "Gestão (pós-laboral)", Tag = "GesPL" },
                new Course { Id = 9, Name = "Contabilidade e Finanças", Tag = "CF" },
                new Course { Id = 10, Name = "Design de Identidade Digital", Tag = "DID" },
                new Course { Id = 11, Name = "Gestão de Pequenas e Médias Empresas", Tag = "GPME" },
                new Course { Id = 12, Name = "Informática", Tag = "Info" },
                new Course { Id = 13, Name = "Tecnologias de Valorização Ambiental e Produção de Energia", Tag = "TVAPE" },
                new Course { Id = 14, Name = "Animação e Produção 3D", Tag = "AP3D" },
                new Course { Id = 15, Name = "Bioenergias", Tag = "BioEn" },
                new Course { Id = 16, Name = "Construção e Reabilitação de Edifícios", Tag="CRE"},
                new Course { Id = 17, Name = "Contabilidade", Tag="Conta"},
                new Course { Id = 18, Name = "Desenvolvimento para a Web e Dispositivos Móveis", Tag = "DWDM" },
                new Course { Id = 19, Name = "Design de Som e Produção Musical", Tag = "DSPM" },
                new Course { Id = 20, Name = "Design Multimédia e Audiovisuais", Tag = "DMA" },
                new Course { Id = 21, Name = "Gestão de Vendas e Marketing", Tag = "GVM" },
                new Course { Id = 22, Name = "Manutenção Eletromecânica", Tag = "ME" },
                new Course { Id = 23, Name = "Programação Ágil e Segurança de Sistemas de Informação", Tag = "PASSI" },
                new Course { Id = 24, Name = "Secretariado de Administração", Tag = "SAmin" },
                new Course { Id = 25, Name = "Tecnologias e Programação de Sistemas de Informação", Tag = "TPSI" },
                new Course { Id = 26, Name = "Animação", Tag = "Anim" },
                new Course { Id = 27, Name = "Data Science and Digital Transformation", Tag = "DSDT" },
                new Course { Id = 28, Name = "Hidrogénio", Tag = "Hidro" },
                new Course { Id = 29, Name = "Renewable Energies and Environment", Tag = "REE" }
                );

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Oppenheimer", ReleaseYear = 2023, Description = "The world forever changes. The story of J. Robert Oppenheimer's role in the development of the atomic bomb during World War II.", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg" },
                new Movie { Id = 2, Title = "Barbie", ReleaseYear = 2023, Description = "She's everything. He's just Ken. Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg" },
                new Movie { Id = 3, Title = "Van Helsing", ReleaseYear = 2004, Description = "The One Name They All Fear. Famed monster slayer Gabriel Van Helsing is dispatched to Transylvania to assist the last of the Valerious bloodline in defeating Count Dracula. Anna Valerious reveals that Dracula has formed an unholy alliance with Dr. Frankenstein's monster and is hell-bent on exacting a centuries-old curse on her family.", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg" },
                new Movie { Id = 4, Title = "The Mummy", ReleaseYear = 1999, Description = "The legend you know. The adventure you have yet to imagine. Dashing legionnaire Rick O'Connell stumbles upon the hidden ruins of Hamunaptra while in the midst of a battle to claim the area in 1920s Egypt. It has been over three thousand years since former High Priest Imhotep suffered a fate worse than death as a punishment for a forbidden love—along with a curse that guarantees eternal doom upon the world if he is ever awoken.", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg" },
                new Movie { Id = 5, Title = "The Mummy Returns", ReleaseYear = 2001, Description = "The most powerful force on earth is about to be unleashed by the two people who should know better. Rick and Evelyn O’Connell, along with their 8-year-old son Alex, discover the key to the legendary Scorpion King’s might: the fabled Bracelet of Anubis. Unfortunately, a newly resurrected Imhotep has designs on the bracelet as well, and isn’t above kidnapping its new bearer, Alex, to gain control of Anubis’s otherworldly army.", ImageUrl = "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/8Gxv8gSFCU0XGDykEGv7zR1n2ua.jpg" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
