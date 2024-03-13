using EFCoreLearn.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreLearn.Data.Configurations
{
    internal class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.HasData(
                    new Coach
                    {
                        Id = 1,
                        Name = "Jose Mourinho",
                    },
                    new Coach
                    {
                        Id = 2,
                        Name = "Pep Guardiola",
                    },
                    new Coach
                    {
                        Id = 3,
                        Name = "Trevoir Williams",
                    }
                );
        }
    }
}
