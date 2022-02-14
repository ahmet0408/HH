using HH.dal.Models.Banner;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.BannerConfiguration
{
    public class BannerTranslateConfiguration: IEntityTypeConfiguration<BannerTranslate>
    {
        public void Configure(EntityTypeBuilder<BannerTranslate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.LanguageCulture).IsRequired();
            builder.Property(x => x.BannerId).IsRequired();
        }
    }
}
