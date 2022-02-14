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
    public class BannerConfiguration: IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.IsPublish).IsRequired();
            builder.HasMany(x => x.BannerTranslates).WithOne(x => x.Banner).HasForeignKey(x => x.BannerId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
