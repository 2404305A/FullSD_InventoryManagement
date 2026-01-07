using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FullSD_InventoryManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branch",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7057), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7069), "Pasir Ris", "System" },
                    { 2, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7071), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7072), "Woodlands", "System" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "Quantity", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7224), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7225), "Egg", 200, "System" },
                    { 2, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7227), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7228), "Vacuum Cleaner", 130, "System" }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "BranchID", "CreatedBy", "DateCreated", "DateUpdated", "Location", "Movement", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 2, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7441), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7442), "Lot A", 0, "System" },
                    { 2, 1, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7444), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7444), "Lot B", 0, "System" }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "ItemID", "OrderID", "Quantity", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7359), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7360), 1, 1, 50, "System" },
                    { 2, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7362), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7363), 2, 1, 20, "System" },
                    { 3, "System", new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7365), new DateTime(2026, 1, 7, 15, 34, 24, 61, DateTimeKind.Local).AddTicks(7365), 1, 2, 10, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branch",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
