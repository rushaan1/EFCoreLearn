using EFCoreLearn.Data;
using EFCoreLearn.Domain;
using Microsoft.EntityFrameworkCore;

//var context = new FootballLeagueDbContext();


//var goneCoach = context.Coaches.Find(3);
//context.Coaches.Remove(goneCoach); 
//context.SaveChanges();
Console.WriteLine("Hi");


//var ncoach = new Coach()
//{
//    Name = "Pablo Naruto",
//    CreatedDate = DateTime.Now
//};

//context.Coaches.Add(ncoach);
//context.SaveChanges();

//var coach = await context.Coaches.FindAsync(1);
//coach.Name = "IShowSpeed";
//await context.SaveChangesAsync();

//var teamz = await context.Teams
//            .Select(q => new Team{ Name = q.Name, TeamId = q.TeamId })
//            .ToListAsync();
//teamz.ForEach(q =>Console.WriteLine($"{q.TeamId}.{q.Name}"));

//int page = 0;
//int recordCount = 3;
//bool next = true;

//while (next)
//{
//    var teams = await context.Teams.Skip(page * recordCount).Take(recordCount).ToListAsync();
//    Console.WriteLine(teams.Count);
//    foreach (var team in teams)
//    {
//        Console.WriteLine("Team Name: " + team.Name);
//    }
//    Console.WriteLine("Continue? true/false");
//    next = Convert.ToBoolean(Console.ReadLine());
//    if (!next)
//    {
//        break;
//    }
//    page++;
//}
//orderedTeams.ForEach(team => Console.WriteLine($"\n\n{team.Name}") );


//var teams = context.Teams.ToList();
//foreach (var team in teams) 
//{
//    Console.WriteLine(team.Name);
//}