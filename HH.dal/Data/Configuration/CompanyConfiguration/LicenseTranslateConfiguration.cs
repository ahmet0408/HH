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
    public class LicenseTranslateConfiguration : IEntityTypeConfiguration<LicenseTranslate>
    {
        public void Configure(EntityTypeBuilder<LicenseTranslate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.LanguageCulture).IsRequired();
            builder.Property(x => x.LicenseId).IsRequired();
        }

    }
}
