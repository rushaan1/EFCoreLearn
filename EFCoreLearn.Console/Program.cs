using EFCoreLearn.Data;
using Microsoft.EntityFrameworkCore;

using var context = new FootballLeagueDbContext();
var team = await (from t in context.Teams
           where t.TeamId == 2
           select t).FirstAsync();
Console.WriteLine($"\n\n{team.Name}");

//var teams = context.Teams.ToList();
//foreach (var team in teams) 
//{
//    Console.WriteLine(team.Name);
//}