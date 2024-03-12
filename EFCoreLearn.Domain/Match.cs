using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Domain
{
    public class Match : BaseDomainModel
    {
        public int HomeTeamId {  get; set; }
        public int AwayTeamId {  get; set; }
        public int TicketPrice {  get; set; }
        public DateTime Date {  get; set; }
    }
}
