using HH.dal.Models.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.ServiceConfiguration
{
    public class ServiceConfiguration: IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.IsPublish).IsRequired();
            builder.HasMany(x => x.ServiceTranslates).WithOne(x => x.Service).HasForeignKey(x => x.ServiceId).OnDelete(DeleteBehavior.Cascade); 
        }
    }
}
