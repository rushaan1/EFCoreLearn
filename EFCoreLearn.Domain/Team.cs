using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Domain
{
    public class Team : BaseDomainModel
    {
        public int TeamId { get; set; }
        public string? Name { get; set; }
    }
}
