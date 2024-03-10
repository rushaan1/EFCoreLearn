using EFCoreLearn.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Data
{
    public class FootballLeagueDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public string DbPath { get; private set; }

        public FootballLeagueDbContext() 
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Combine(path, "FootballLeague_EfCore.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Data Source={DbPath}")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                    new Team
                    {
                        TeamId = 1,
                        Name = "Tivoli Gardens F.C.",
                        CreatedDate = DateTimeOffset.UtcNow.DateTime
                    },
                    new Team
                    {
                        TeamId = 2,
                        Name = "Waterhouse F.C.",
                        CreatedDate = DateTimeOffset.UtcNow.DateTime
                    },
                    new Team
                    {
                        TeamId = 3,
                        Name = "Humble Lions F.C.",
                        CreatedDate = DateTimeOffset.UtcNow.DateTime
                    }

                );
        }
    }
}
