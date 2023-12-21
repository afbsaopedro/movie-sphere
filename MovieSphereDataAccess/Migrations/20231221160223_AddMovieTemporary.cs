using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieSphereDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddMovieTemporary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "The world forever changes. The story of J. Robert Oppenheimer's role in the development of the atomic bomb during World War II.", 2023, "Oppenheimer" },
                    { 2, "She's everything. He's just Ken. Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.", 2023, "Barbie" },
                    { 3, "The One Name They All Fear. Famed monster slayer Gabriel Van Helsing is dispatched to Transylvania to assist the last of the Valerious bloodline in defeating Count Dracula. Anna Valerious reveals that Dracula has formed an unholy alliance with Dr. Frankenstein's monster and is hell-bent on exacting a centuries-old curse on her family.", 2004, "Van Helsing" },
                    { 4, "The legend you know. The adventure you have yet to imagine. Dashing legionnaire Rick O'Connell stumbles upon the hidden ruins of Hamunaptra while in the midst of a battle to claim the area in 1920s Egypt. It has been over three thousand years since former High Priest Imhotep suffered a fate worse than death as a punishment for a forbidden love—along with a curse that guarantees eternal doom upon the world if he is ever awoken.", 1999, "The Mummy" },
                    { 5, "The most powerful force on earth is about to be unleashed by the two people who should know better. Rick and Evelyn O’Connell, along with their 8-year-old son Alex, discover the key to the legendary Scorpion King’s might: the fabled Bracelet of Anubis. Unfortunately, a newly resurrected Imhotep has designs on the bracelet as well, and isn’t above kidnapping its new bearer, Alex, to gain control of Anubis’s otherworldly army.", 2001, "The Mummy Returns" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
