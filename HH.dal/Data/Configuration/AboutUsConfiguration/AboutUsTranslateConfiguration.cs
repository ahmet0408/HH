using HH.dal.Models.AboutUs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.AboutUsConfiguration
{
    public class AboutUsTranslateConfiguration: IEntityTypeConfiguration<AboutUsTranslate>
    {
        public void Configure(EntityTypeBuilder<AboutUsTranslate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.ShortDesc).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.LocationAdress).IsRequired();
            builder.Property(x => x.LanguageCulture).IsRequired();
            builder.Property(x => x.AboutUsId).IsRequired();
        }
    }
}
