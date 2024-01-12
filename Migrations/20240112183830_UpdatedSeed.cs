using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieSphere.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62bbfc2d-5d45-44f4-a352-b052cd64a853");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c48682c0-a219-4299-80f9-afbe5bcbeb67");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "65fe13df-a855-4a93-9103-77c4fb635ef3", null, "Manager", "MANAGER" },
                    { "b4a66743-0737-4884-8dfd-00b9cdf38b20", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a5da078-3a9c-4636-a2d9-45014ccc5815",
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad8c0519-2fbc-4c05-82de-52e6ee070109", new DateTime(2024, 1, 12, 18, 38, 29, 368, DateTimeKind.Local).AddTicks(6591), "AQAAAAIAAYagAAAAEAPFB8bPlMCM9q+XbTZ48X5RnHxlmY/DY6e5YOgAnoK2KB85scItg7P6qekaQcbjhQ==", "d3babf45-8b63-4c81-90bb-074b8ebf4558" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "CourseId", "CreationDate", "DateOfBirth", "DisplayName", "Email", "EmailConfirmed", "FirstName", "IsPrivate", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PlaceOfOrigin", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8426038e-905e-4397-a95d-98a4a10b8231", 0, "Movie Sphere", "fc3a724e-409d-4e28-a2f5-9699ec472875", null, new DateTime(2024, 1, 12, 18, 38, 29, 536, DateTimeKind.Local).AddTicks(4033), new DateOnly(1996, 11, 30), "afbsaopedro", "andre.saopedro@moviesphere.com", true, "André", true, "São Pedro", false, null, "ANDRE.SAOPEDRO@MOVIESPHERE.COM", "ANDRE.SAOPEDRO@MOVIESPHERE.COM", "AQAAAAIAAYagAAAAECgrkOef9NFkREeJEY8fEIZSp87fvAOydBmAYmf9oabOmJa2QS/95PYyArHsu11OPw==", null, false, "Portalegre", "595d85e1-4d45-413d-bdf7-4e1b839250d7", false, "andre.saopedro@moviesphere.com" },
                    { "f8c79463-5df6-4736-a0ba-87218377f287", 0, "CTeSP TPSI! Brevemente Engenharia Informática!", "efb3648e-b74f-4dca-9e6a-c223fb251ba9", null, new DateTime(2024, 1, 12, 18, 38, 29, 452, DateTimeKind.Local).AddTicks(3209), new DateOnly(1991, 1, 2), "Leo-caldeira", "leonor.caldeira@moviesphere.com", true, "Leonor", true, "Caldeira", false, null, "LEONOR.CALDEIRA@MOVIESPHERE.COM", "LEONOR.CALDEIRA@MOVIESPHERE.COM", "AQAAAAIAAYagAAAAEF2XBukypgQtIELLlEdw0gQXvucXq4gvNZg9GzM8m2rh3eiPadAbkSFun+VSsHG7yw==", null, false, "Portalegre", "c0e53373-b120-4309-aae8-2c1ab4853bf6", false, "leonor.caldeira@moviesphere.com" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "ApiReference" },
                values: new object[,]
                {
                    { 1, 872585 },
                    { 2, 76600 },
                    { 3, 507089 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ApplicationUserId", "Content", "CreatedAt", "MovieId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "8426038e-905e-4397-a95d-98a4a10b8231", "The best movie of 2023!", new DateTime(2024, 1, 12, 18, 38, 29, 536, DateTimeKind.Local).AddTicks(5134), 1, new DateTime(2024, 1, 12, 18, 38, 29, 536, DateTimeKind.Local).AddTicks(5135) },
                    { 2, "f8c79463-5df6-4736-a0ba-87218377f287", "Não achei piada nenhuma. Nem sei que pontuação dar...", new DateTime(2024, 1, 12, 18, 38, 29, 536, DateTimeKind.Local).AddTicks(5153), 3, new DateTime(2024, 1, 12, 18, 38, 29, 536, DateTimeKind.Local).AddTicks(5155) }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ApplicationUserId", "CreatedAt", "MovieId", "Score", "UpdatedAt" },
                values: new object[] { 1, "8426038e-905e-4397-a95d-98a4a10b8231", new DateTime(2024, 1, 12, 18, 38, 29, 536, DateTimeKind.Local).AddTicks(4842), 1, 5, new DateTime(2024, 1, 12, 18, 38, 29, 536, DateTimeKind.Local).AddTicks(4843) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65fe13df-a855-4a93-9103-77c4fb635ef3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4a66743-0737-4884-8dfd-00b9cdf38b20");

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8426038e-905e-4397-a95d-98a4a10b8231");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8c79463-5df6-4736-a0ba-87218377f287");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62bbfc2d-5d45-44f4-a352-b052cd64a853", null, "Admin", "ADMIN" },
                    { "c48682c0-a219-4299-80f9-afbe5bcbeb67", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a5da078-3a9c-4636-a2d9-45014ccc5815",
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2817eed9-9f52-475a-8940-e134f0f2ccef", new DateTime(2024, 1, 12, 17, 29, 53, 879, DateTimeKind.Local).AddTicks(9821), "AQAAAAIAAYagAAAAEHieNb4IC7J+M5ARw3XT25xROmCB4w42y5TR9u/GaLpgR2uRN7ftmBDfT57/JG7dpA==", "fa08b37a-b221-4ee6-9c03-907ed4b2ea39" });
        }
    }
}
