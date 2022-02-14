using HH.dal.Models.Mission;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.MissionConfiguration
{
    public class MissionConfiguration: IEntityTypeConfiguration<Mission>
    {
        public void Configure(EntityTypeBuilder<Mission> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Icon).IsRequired();
            builder.Property(x => x.IsPublish).IsRequired();
            builder.HasMany(x => x.MissionTranslates).WithOne(x => x.Mission).HasForeignKey(x => x.MissionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
