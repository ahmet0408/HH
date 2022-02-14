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
    public class NewsTranslateConfiguration: IEntityTypeConfiguration<NewsTranslate>
    {
        public void Configure(EntityTypeBuilder<NewsTranslate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.ShortDesc).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.LanguageCulture).IsRequired();
            builder.Property(x => x.NewsId).IsRequired();
        }
    }
}
