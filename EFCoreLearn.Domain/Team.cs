using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Domain
{
    public class Team : BaseDomainModel
    {
        public int CoachId { get; set; }
        public string? Name { get; set; }
        public League? League { get; set; }
        public int? LeagueId { get; set; }
    }
}
