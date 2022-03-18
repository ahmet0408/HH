using HH.dal.Models.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.CompanyConfiguration
{
    public class LicenseConfiguration : IEntityTypeConfiguration<License>
    {
        public void Configure(EntityTypeBuilder<License> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.File).IsRequired();
            builder.Property(x => x.IsPublish).IsRequired();
            builder.HasMany(x => x.LicenseTranslates).WithOne(x => x.License).HasForeignKey(x => x.LicenseId).OnDelete(DeleteBehavior.Cascade);
        }

    }
}
