using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieSphere.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCommentReviewDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Comments",
                newName: "Date");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8073d9ae-5a64-49cc-b033-d3ef1f645202", null, "Admin", null },
                    { "d513944b-eeec-4bfd-9edf-129ed8967365", null, "Developer", null },
                    { "fbef3039-a719-417a-9959-a222ec88d672", null, "Manager", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "CourseId", "CreationDate", "DateOfBirth", "DisplayName", "Email", "EmailConfirmed", "FirstName", "IsPrivate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfOrigin", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d887d18a-41ba-4bec-86a6-333573c13045", 0, "Teacher @ ESTG.", "01e27fd4-094d-4f16-a0a0-4d7a4bc16184", 6, new DateTime(2024, 1, 11, 19, 29, 35, 417, DateTimeKind.Local).AddTicks(8033), new DateOnly(1991, 1, 2), "dolival", "d.olival@moviesphere.com", true, "Diogo", true, "Olival", false, null, "D.OLIVAL@MOVIESPHERE.COM", "D.OLIVAL@MOVIESPHERE.COM", "AQAAAAIAAYagAAAAEHwP+RlO1XdEH89b6Nap6vuyRfIEawDJrY8MmbB7c1CTbNbAQEVLBUqvUQGpDw++AQ==", null, false, "Madeira", "a5c9f37a-14df-4076-93da-914969432dfb", false, "d.olival@moviesphere.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8073d9ae-5a64-49cc-b033-d3ef1f645202");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d513944b-eeec-4bfd-9edf-129ed8967365");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fbef3039-a719-417a-9959-a222ec88d672");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d887d18a-41ba-4bec-86a6-333573c13045");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Comments",
                newName: "date");

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
    }
}
