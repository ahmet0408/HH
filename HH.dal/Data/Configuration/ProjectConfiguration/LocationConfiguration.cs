using HH.dal.Models.Project;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.ProjectConfiguration
{
    public class LocationConfiguration: IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsPublish).IsRequired();
            builder.HasMany(x => x.LocationTranslates).WithOne(x => x.Location).HasForeignKey(x => x.LocationId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
