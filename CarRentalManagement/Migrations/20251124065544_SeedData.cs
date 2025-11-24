using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(5781), new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(5802), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(5805), new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(5806), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6142), new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6143), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6146), new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6146), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6239), new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6240), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6242), new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6243), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6245), new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6246), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6247), new DateTime(2025, 11, 24, 14, 55, 43, 267, DateTimeKind.Local).AddTicks(6248), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
