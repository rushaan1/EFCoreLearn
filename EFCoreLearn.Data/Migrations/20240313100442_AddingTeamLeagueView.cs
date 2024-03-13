using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreLearn.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingTeamLeagueView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
	            CREATE VIEW vw_TeamsAndLeagues
	            AS
	            SELECT t.Name, l.Name AS LeagueName
	            FROM  Teams AS t 
	            LEFT JOIN Leagues AS l ON t.LeagueId = l.Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW vw_TeamsAndLeagues");
        }
    }
}
