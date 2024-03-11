using EFCoreLearn.Data;
using EFCoreLearn.Domain;
using Microsoft.EntityFrameworkCore;

var context = new FootballLeagueDbContext();

int page = 0;
int recordCount = 3;
bool next = true;

while (next)
{
    var teams = await context.Teams.Skip(page * recordCount).Take(recordCount).ToListAsync();
    Console.WriteLine(teams.Count);
    foreach (var team in teams)
    {
        Console.WriteLine("Team Name: " + team.Name);
    }
    Console.WriteLine("Continue? true/false");
    next = Convert.ToBoolean(Console.ReadLine());
    if (!next)
    {
        break;
    }
    page++;
}
//orderedTeams.ForEach(team => Console.WriteLine($"\n\n{team.Name}") );


//var teams = context.Teams.ToList();
//foreach (var team in teams) 
//{
//    Console.WriteLine(team.Name);
//}