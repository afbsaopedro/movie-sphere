using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieSphere.Migrations
{
    /// <inheritdoc />
    public partial class AddFeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "632a3b2b-6340-4d93-bad6-ab75183e3a41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71bf90b5-2c7d-442e-9f96-08055bd1586e");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Comments",
                newName: "UpdatedAt");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Ratings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Ratings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62bbfc2d-5d45-44f4-a352-b052cd64a853");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c48682c0-a219-4299-80f9-afbe5bcbeb67");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Ratings");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Comments");

            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Comments",
                newName: "Date");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "632a3b2b-6340-4d93-bad6-ab75183e3a41", null, "Admin", "ADMIN" },
                    { "71bf90b5-2c7d-442e-9f96-08055bd1586e", null, "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a5da078-3a9c-4636-a2d9-45014ccc5815",
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4bf6f5b-176a-41db-bdf1-475f7942d2d8", new DateTime(2024, 1, 12, 15, 30, 27, 914, DateTimeKind.Local).AddTicks(829), "AQAAAAIAAYagAAAAEDfOY9LQEG7705sxi5BvgQqZRaFcLFP5QHy+iPKM2caCAsQxFa7l+mgXSoyxjFTH1A==", "39f038f8-0bf5-4adc-bf78-2b3167bcee3a" });
        }
    }
}
