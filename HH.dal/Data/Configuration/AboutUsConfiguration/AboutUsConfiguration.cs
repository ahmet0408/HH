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
    public class AboutUsConfiguration: IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MainImage).IsRequired();
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Fax).IsRequired();
            builder.Property(x => x.IsPublish).IsRequired();
            builder.Property(x => x.Mail).IsRequired();
            builder.Property(x => x.Latitude).IsRequired();
            builder.Property(x => x.Longitude).IsRequired();
            builder.HasMany(x => x.AboutUsTranslates).WithOne(x => x.AboutUs).HasForeignKey(x => x.AboutUsId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
