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
    public class NewsConfiguration: IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.IsPublish).IsRequired();
            builder.Property(x => x.Date).IsRequired();
            builder.HasMany(x => x.NewsTranslates).WithOne(x => x.News).HasForeignKey(x => x.NewsId).OnDelete(DeleteBehavior.Cascade);
        }

    }
}
