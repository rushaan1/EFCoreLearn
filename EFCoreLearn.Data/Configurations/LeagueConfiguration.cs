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
    internal class LeagueConfiguration : IEntityTypeConfiguration<League>
    {
        public void Configure(EntityTypeBuilder<League> builder)
        {
            builder.HasData(
                    new League
                    {
                        Id = 1,
                        Name = "Jamaica Premiere League",
                    },
                    new League
                    {
                        Id = 2,
                        Name = "English Premiere League",
                    },
                    new League
                    {
                        Id = 3,
                        Name = "La Liga",
                    }
                );
        }
    }
}
