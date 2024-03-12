using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreLearn.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedTeamIdToCoaches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "Coaches",
                newName: "TeamId");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 10, 27, 33, 754, DateTimeKind.Unspecified).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 10, 27, 33, 754, DateTimeKind.Unspecified).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 12, 10, 27, 33, 754, DateTimeKind.Unspecified).AddTicks(6756));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Coaches",
                newName: "Experience");

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
    }
}
