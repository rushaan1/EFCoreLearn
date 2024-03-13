using EFCoreLearn.Data;
using EFCoreLearn.Domain;
using Microsoft.EntityFrameworkCore;

var context = new FootballLeagueDbContext();

var beforeLeagues = context.Leagues.ToList();
Console.WriteLine("\nBEFORE DELETING THE LEAGUE:");
foreach (var l in beforeLeagues) 
{
    Console.WriteLine(l.Name);
}

var leagueToDelete = context.Leagues.Find(6);
leagueToDelete.IsDeleted = true;
context.SaveChanges();

var afterLeagues = context.Leagues.ToList();
Console.WriteLine("\nAFTER DELETING THE LEAGUE:");
foreach (var l in afterLeagues)
{
    Console.WriteLine(l.Name);
}



//var transaction = context.Database.BeginTransaction();

//var league = new League
//{
//    Name = "Testing Transactions"
//};

//context.Add(league);
//context.SaveChanges();
//transaction.CreateSavepoint("CreatedLeague");

//var coach = new Coach
//{
//    Name = "Transaction Coach"
//};

//context.Add(coach);
//context.SaveChanges();

//var teams = new List<Team>
//{
//    new Team
//    {
//        Name = "Transaction Team 1",
//        LeagueId = league.Id,
//        CoachId = coach.Id
//    }
//};
//context.AddRange(teams);
//context.SaveChanges();

//try
//{
//    transaction.Commit();
//    Console.WriteLine("Transaction Successful!");
//}
//catch (Exception) 
//{
//    transaction.RollbackToSavepoint("CreatedLeague");
//    Console.WriteLine("Transaction Failed & rolled back!");
//}

//var testLeague = new League()
//{
//    Name = "Test FC"
//};
//context.Add(testLeague);
//context.SaveChanges();


//var data = context.TeamsAndLeaguesView.ToList();

//Console.WriteLine("\n");

//foreach (var item in data)
//{
//    Console.WriteLine($"{item.Name} is in League {item.LeagueName}");    
//}

//var teams = context.Teams
//    .Include(t=>t.Coach)
//    .Include(q=>q.HomeMatches.Where(q=>q.HomeTeamScore>0))
//    .ToList();

//foreach (var team in teams) 
//{
//    Console.WriteLine("\n");
//    Console.WriteLine($"Team: {team.Name}");
//    foreach (var match in team.HomeMatches) 
//    {
//        Console.WriteLine($"Score - {match.HomeTeamScore}");
//    }
//}



//var league = new League
//{
//    Name = "Serie A",
//    Teams = new List<Team>
//                {
//                    new Team
//                    {
//                        Name = "Juventus",
//                        Coach = new Coach
//                        {
//                            Name = "Juve Coach"
//                        },
//                    },
//                    new Team
//                    {
//                        Name = "AC Milan",
//                        Coach = new Coach
//                        {
//                            Name = "Milan Coach"
//                        },
//                    },
//                    new Team
//                    {
//                        Name = "AS Roma",
//                        Coach = new Coach
//                        {
//                            Name = "Roma Coach"
//                        },
//                    }
//                }
//};
//await context.AddAsync(league);
//await context.SaveChangesAsync();


//var match1 = new Match
//{
//    AwayTeamId = 2,
//    HomeTeamId = 3,
//    HomeTeamScore = 1,
//    AwayTeamScore = 0,
//    Date = new DateTime(2023, 01, 1),
//    TicketPrice = 20,
//};
//var match2 = new Match
//{
//    AwayTeamId = 2,
//    HomeTeamId = 1,
//    HomeTeamScore = 1,
//    AwayTeamScore = 0,
//    Date = new DateTime(2023, 01, 1),
//    TicketPrice = 20,
//};
//var match3 = new Match
//{
//    AwayTeamId = 1,
//    HomeTeamId = 3,
//    HomeTeamScore = 1,
//    AwayTeamScore = 0,
//    Date = new DateTime(2023, 01, 1),
//    TicketPrice = 20,
//};
//var match4 = new Match
//{
//    AwayTeamId = 4,
//    HomeTeamId = 3,
//    HomeTeamScore = 0,
//    AwayTeamScore = 1,
//    Date = new DateTime(2023, 01, 1),
//    TicketPrice = 20,
//};
//await context.AddRangeAsync(match1, match2, match3, match4);
//await context.SaveChangesAsync();

//Console.WriteLine("All Insertion done!");


//var league = context.Find<League>(1);
//if (!league.Teams.Any()) 
//{
//    Console.WriteLine("No Teams currently loaded!");
//}

//context.Entry(league)
//    .Collection(q => q.Teams)
//    .Load();

//Console.WriteLine("\n");

//if (league.Teams.Any())
//{
//    foreach (var team in league.Teams) 
//    {
//        Console.WriteLine($"{team.Name}");
//    }
//}

//var leagues = context.Leagues
//    .Include(q=>q.Teams)
//    .ThenInclude(q=>q.Coach)
//    .ToList();

//foreach (var league in leagues) 
//{
//    Console.WriteLine(league.Name+":");
//    foreach (var team in league.Teams) 
//    {
//        Console.WriteLine(team.Name+$" with coach {team.Coach.Name}");
//    }
//    Console.WriteLine("\n");
//}




//var team = new Team()
//{
//    Name = "New Team",
//    Coach = new Coach()
//    {
//        Name = "Johnshon"
//    }
//};
//context.Add(team);
//context.SaveChanges();
//Console.WriteLine("Updated Database");

//var goneCoach = context.Coaches.Find(3);
//context.Coaches.Remove(goneCoach); 
//context.SaveChanges();
//Console.WriteLine("Hi");


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