using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieSphere.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddApplicationUserAndMovie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CountryOfOrigin",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfOrigin",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    ReleaseYear = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserFavouriteMovies",
                columns: table => new
                {
                    FavouriteMoviesId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UsersWhoFavouritedId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavouriteMovies", x => new { x.FavouriteMoviesId, x.UsersWhoFavouritedId });
                    table.ForeignKey(
                        name: "FK_UserFavouriteMovies_AspNetUsers_UsersWhoFavouritedId",
                        column: x => x.UsersWhoFavouritedId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFavouriteMovies_Movies_FavouriteMoviesId",
                        column: x => x.FavouriteMoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserWatchlist",
                columns: table => new
                {
                    UsersInWatchlistId = table.Column<string>(type: "TEXT", nullable: false),
                    WatchlistId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserWatchlist", x => new { x.UsersInWatchlistId, x.WatchlistId });
                    table.ForeignKey(
                        name: "FK_UserWatchlist_AspNetUsers_UsersInWatchlistId",
                        column: x => x.UsersInWatchlistId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserWatchlist_Movies_WatchlistId",
                        column: x => x.WatchlistId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserFavouriteMovies_UsersWhoFavouritedId",
                table: "UserFavouriteMovies",
                column: "UsersWhoFavouritedId");

            migrationBuilder.CreateIndex(
                name: "IX_UserWatchlist_WatchlistId",
                table: "UserWatchlist",
                column: "WatchlistId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserFavouriteMovies");

            migrationBuilder.DropTable(
                name: "UserWatchlist");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropColumn(
                name: "Bio",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CountryOfOrigin",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PlaceOfOrigin",
                table: "AspNetUsers");
        }
    }
}
