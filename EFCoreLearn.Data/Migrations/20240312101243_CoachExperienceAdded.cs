using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreLearn.Data.Migrations
{
    /// <inheritdoc />
    public partial class CoachExperienceAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Experience",
                table: "Coaches",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 10, 12, 43, 772, DateTimeKind.Unspecified).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 10, 12, 43, 772, DateTimeKind.Unspecified).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 10, 12, 43, 772, DateTimeKind.Unspecified).AddTicks(4699));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Coaches");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 7, 46, 7, 519, DateTimeKind.Unspecified).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 7, 46, 7, 519, DateTimeKind.Unspecified).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 7, 46, 7, 519, DateTimeKind.Unspecified).AddTicks(1066));
        }
    }
}
