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
            base.OnModelCreating(modelBuilder);
        }
    }
}
