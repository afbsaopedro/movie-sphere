using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieSphere.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRoleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f088804-c96b-4d92-9728-ac02a77d076c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1f0ec7c-d318-4fbf-ac76-0cae478c92a0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49379abf-f146-406b-9ef7-059723ba41a9",
                column: "NormalizedName",
                value: "DEVELOPER");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "632a3b2b-6340-4d93-bad6-ab75183e3a41");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71bf90b5-2c7d-442e-9f96-08055bd1586e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49379abf-f146-406b-9ef7-059723ba41a9",
                column: "NormalizedName",
                value: null);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9f088804-c96b-4d92-9728-ac02a77d076c", null, "Admin", null },
                    { "e1f0ec7c-d318-4fbf-ac76-0cae478c92a0", null, "Manager", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a5da078-3a9c-4636-a2d9-45014ccc5815",
                columns: new[] { "ConcurrencyStamp", "CreationDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3f3e376-aa50-4a42-8cee-c89ac6d1eb5d", new DateTime(2024, 1, 11, 22, 51, 28, 477, DateTimeKind.Local).AddTicks(319), "AQAAAAIAAYagAAAAEKml+iitDXWp49zFFM1oLkMPQF5YfkUc7WuAovXPMML8pmn7wyjjvXPtQbL6kWmnZg==", "86c7bfff-2845-487c-8e44-9e3b06baee2c" });
        }
    }
}
