using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "981cf0b5-7188-41e1-8b34-0008826460c6", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEA7+VQ2tmUb+TtvQmWYJMje8Qc9yblYx6n3+fOoTXOmT5+o95foHrPDRq4HQa1InQA==", null, false, "337c2b8e-87ea-4721-8584-07c1b3ddfc5d", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2262), new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2285), new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2600), new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2604), new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2761), new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2765), new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2769), new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2772), new DateTime(2025, 11, 26, 11, 29, 56, 812, DateTimeKind.Local).AddTicks(2773) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8241), new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8266), new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8526), new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8530), new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8630), new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8633), new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8635), new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8638), new DateTime(2025, 11, 26, 11, 1, 9, 363, DateTimeKind.Local).AddTicks(8639) });
        }
    }
}
