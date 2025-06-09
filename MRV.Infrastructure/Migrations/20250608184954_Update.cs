using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MRV.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 18, 49, 54, 98, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 18, 49, 54, 98, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 18, 49, 54, 98, DateTimeKind.Utc).AddTicks(1764));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 18, 49, 54, 98, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 18, 49, 54, 98, DateTimeKind.Utc).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 18, 49, 54, 98, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 18, 49, 54, 98, DateTimeKind.Utc).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(2025, 6, 8, 18, 49, 54, 98, DateTimeKind.Utc).AddTicks(1777));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Leads",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateCreated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
