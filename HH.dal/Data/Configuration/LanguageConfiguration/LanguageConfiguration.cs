using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using HH.dal.Models.Language;

namespace HH.dal.Data.Configuration.LanguageConfiguration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(p => p.Culture);
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.FlagImage).IsRequired(false);
            builder.Property(p => p.IsPublish).IsRequired();
            builder.Property(p => p.DisplayOrder).IsRequired();
        }
    }
}
