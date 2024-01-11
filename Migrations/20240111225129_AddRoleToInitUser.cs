using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieSphere.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleToInitUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49379abf-f146-406b-9ef7-059723ba41a9", null, "Developer", null },
                    { "9f088804-c96b-4d92-9728-ac02a77d076c", null, "Admin", null },
                    { "e1f0ec7c-d318-4fbf-ac76-0cae478c92a0", null, "Manager", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "CourseId", "CreationDate", "DateOfBirth", "DisplayName", "Email", "EmailConfirmed", "FirstName", "IsPrivate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfOrigin", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2a5da078-3a9c-4636-a2d9-45014ccc5815", 0, "Teacher @ ESTG.", "f3f3e376-aa50-4a42-8cee-c89ac6d1eb5d", 6, new DateTime(2024, 1, 11, 22, 51, 28, 477, DateTimeKind.Local).AddTicks(319), new DateOnly(1991, 1, 2), "dolival", "d.olival@moviesphere.com", true, "Diogo", true, "Olival", false, null, "D.OLIVAL@MOVIESPHERE.COM", "D.OLIVAL@MOVIESPHERE.COM", "AQAAAAIAAYagAAAAEKml+iitDXWp49zFFM1oLkMPQF5YfkUc7WuAovXPMML8pmn7wyjjvXPtQbL6kWmnZg==", null, false, "Madeira", "86c7bfff-2845-487c-8e44-9e3b06baee2c", false, "d.olival@moviesphere.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "49379abf-f146-406b-9ef7-059723ba41a9", "2a5da078-3a9c-4636-a2d9-45014ccc5815" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f088804-c96b-4d92-9728-ac02a77d076c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1f0ec7c-d318-4fbf-ac76-0cae478c92a0");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "49379abf-f146-406b-9ef7-059723ba41a9", "2a5da078-3a9c-4636-a2d9-45014ccc5815" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49379abf-f146-406b-9ef7-059723ba41a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a5da078-3a9c-4636-a2d9-45014ccc5815");

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
    }
}
