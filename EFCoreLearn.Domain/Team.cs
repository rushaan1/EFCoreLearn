using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Domain
{
    public class Team : BaseDomainModel
    {
        public string? Name { get; set; }
        public Coach Coach { get; set; }
        public int CoachId { get; set; }
        public League? League { get; set; }
        public int? LeagueId { get; set; }
        public List<Match> HomeMatches { get; set; }
        public List<Match> AwayMatches { get; set; }
    }
}
