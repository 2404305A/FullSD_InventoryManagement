using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullSD_InventoryManagement.Migrations
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
                    { "10aca7f8-491d-49f5-adca-fc23831802bf", null, "Administrator", "ADMINISTRATOR" },
                    { "57b5a20b-816e-4e93-a8d7-6f965389ec64", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d40252e1-7e47-4998-a6f2-c872657c5223", 0, "9943aee5-bdda-406c-9216-49e1cbb05c1b", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHER01QZUdWz+2kPLS+gS87OVdGPBeWCHh8e4sF1asQBJMG/ZM9nTEyoMu4DgETDyg==", null, false, "0c23e18c-6f02-4ed1-ac17-15c40c1a810f", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1148), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1164), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1368), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1370), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1564), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1567), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1458), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1461), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1464), new DateTime(2026, 1, 7, 17, 52, 12, 656, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "10aca7f8-491d-49f5-adca-fc23831802bf", "d40252e1-7e47-4998-a6f2-c872657c5223" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57b5a20b-816e-4e93-a8d7-6f965389ec64");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10aca7f8-491d-49f5-adca-fc23831802bf", "d40252e1-7e47-4998-a6f2-c872657c5223" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10aca7f8-491d-49f5-adca-fc23831802bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d40252e1-7e47-4998-a6f2-c872657c5223");

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8213), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8227) });

            migrationBuilder.UpdateData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8229), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8441), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8445), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8774), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8778), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8544), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8602), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8604), new DateTime(2026, 1, 7, 17, 19, 48, 301, DateTimeKind.Local).AddTicks(8605) });
        }
    }
}
