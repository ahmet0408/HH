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
    public class StatusConfiguration: IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasMany(x => x.Projects).WithOne(x => x.Status).HasForeignKey(x => x.StatusId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(x => x.StatusTranslates).WithOne(x => x.Status).HasForeignKey(x => x.StatusId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
