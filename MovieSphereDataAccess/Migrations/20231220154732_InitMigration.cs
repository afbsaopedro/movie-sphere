using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieSphereDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name", "Tag" },
                values: new object[,]
                {
                    { 1, "Administração de Publicidade e Marketing", "APM" },
                    { 2, "Design de Animação", "DA" },
                    { 3, "Design de Comunicação", "DC" },
                    { 4, "Engenharia Civil", "EC" },
                    { 5, "Engenharia de Produção de Biocombustíveis", "EPBio" },
                    { 6, "Engenharia Informática", "EI" },
                    { 7, "Gestão", "Ges" },
                    { 8, "Gestão (pós-laboral)", "GesPL" },
                    { 9, "Contabilidade e Finanças", "CF" },
                    { 10, "Design de Identidade Digital", "DID" },
                    { 11, "Gestão de Pequenas e Médias Empresas", "GPME" },
                    { 12, "Informática", "Info" },
                    { 13, "Tecnologias de Valorização Ambiental e Produção de Energia", "TVAPE" },
                    { 14, "Animação e Produção 3D", "AP3D" },
                    { 15, "Bioenergias", "BioEn" },
                    { 16, "Construção e Reabilitação de Edifícios", "CRE" },
                    { 17, "Contabilidade", "Conta" },
                    { 18, "Desenvolvimento para a Web e Dispositivos Móveis", "DWDM" },
                    { 19, "Design de Som e Produção Musical", "DSPM" },
                    { 20, "Design Multimédia e Audiovisuais", "DMA" },
                    { 21, "Gestão de Vendas e Marketing", "GVM" },
                    { 22, "Manutenção Eletromecânica", "ME" },
                    { 23, "Programação Ágil e Segurança de Sistemas de Informação", "PASSI" },
                    { 24, "Secretariado de Administração", "SAmin" },
                    { 25, "Tecnologias e Programação de Sistemas de Informação", "TPSI" },
                    { 26, "Animação", "Anim" },
                    { 27, "Data Science and Digital Transformation", "DSDT" },
                    { 28, "Hidrogénio", "Hidro" },
                    { 29, "Renewable Energies and Environment", "REE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
