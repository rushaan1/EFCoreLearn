using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreLearn.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedTeamId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 7, 29, 44, 753, DateTimeKind.Unspecified).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 7, 29, 44, 753, DateTimeKind.Unspecified).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 7, 29, 44, 753, DateTimeKind.Unspecified).AddTicks(2876));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Teams",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "TeamId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 20, 40, 992, DateTimeKind.Unspecified).AddTicks(6558), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "TeamId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 20, 40, 992, DateTimeKind.Unspecified).AddTicks(6564), null });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "TeamId" },
                values: new object[] { new DateTime(2024, 3, 12, 7, 20, 40, 992, DateTimeKind.Unspecified).AddTicks(6565), null });
        }
    }
}
