using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieSphere.Migrations
{
    /// <inheritdoc />
    public partial class AddDateToCommentReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24d22674-582a-4d64-a739-a4f9dca89900");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f7e49bf-c7ba-415a-bb07-52a53d0a2bd2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9548b906-eeea-45fe-9449-33c2f31ff29a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e28fbb33-0dc7-49fe-8942-37b5c7f2a5b9");

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "383f5fd1-bea4-4117-968c-bc10a86d8845", null, "Developer", null },
                    { "83ef4aea-bb17-4639-8fc1-7f4fa447fe3e", null, "Admin", null },
                    { "8fa78dd0-74c5-4551-89b7-01345b08d69f", null, "Manager", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "CourseId", "CreationDate", "DateOfBirth", "DisplayName", "Email", "EmailConfirmed", "FirstName", "IsPrivate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfOrigin", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "44340f8a-5df6-44e0-b2cc-6b217e20bee8", 0, "Teacher @ ESTG.", "b57a0454-c923-46dc-949f-bf7604cd9ce5", 6, new DateTime(2024, 1, 11, 19, 28, 8, 378, DateTimeKind.Local).AddTicks(8853), new DateOnly(1991, 1, 2), "dolival", "d.olival@moviesphere.com", true, "Diogo", true, "Olival", false, null, "D.OLIVAL@MOVIESPHERE.COM", "D.OLIVAL@MOVIESPHERE.COM", "AQAAAAIAAYagAAAAECE1HZaYiuPpKuYlfun/FW+7/d3zLpQyaKhf7blPs2YlddnytL6XD4W4/MGwDSJ0pw==", null, false, "Madeira", "2ba368ad-85f4-4108-878b-4baffa75230f", false, "d.olival@moviesphere.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "383f5fd1-bea4-4117-968c-bc10a86d8845");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83ef4aea-bb17-4639-8fc1-7f4fa447fe3e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8fa78dd0-74c5-4551-89b7-01345b08d69f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44340f8a-5df6-44e0-b2cc-6b217e20bee8");

            migrationBuilder.DropColumn(
                name: "date",
                table: "Comments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24d22674-582a-4d64-a739-a4f9dca89900", null, "Admin", null },
                    { "5f7e49bf-c7ba-415a-bb07-52a53d0a2bd2", null, "Manager", null },
                    { "9548b906-eeea-45fe-9449-33c2f31ff29a", null, "Developer", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "CourseId", "CreationDate", "DateOfBirth", "DisplayName", "Email", "EmailConfirmed", "FirstName", "IsPrivate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfOrigin", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e28fbb33-0dc7-49fe-8942-37b5c7f2a5b9", 0, "Teacher @ ESTG.", "8c83d3d0-6eb6-4527-a903-ef0aee0b9397", 6, new DateTime(2024, 1, 11, 18, 49, 14, 34, DateTimeKind.Local).AddTicks(4965), new DateOnly(1991, 1, 2), "dolival", "d.olival@moviesphere.com", true, "Diogo", true, "Olival", false, null, "D.OLIVAL@MOVIESPHERE.COM", "D.OLIVAL@MOVIESPHERE.COM", "AQAAAAIAAYagAAAAEAgABO96E8+3AwMb/avuhP10S25NR7zBFRekBp6zoJ6RB4+Na3pYsdFoCgx9kzMoJA==", null, false, "Madeira", "5fdc929a-d59d-4825-a866-e0104c08981d", false, "d.olival@moviesphere.com" });
        }
    }
}
