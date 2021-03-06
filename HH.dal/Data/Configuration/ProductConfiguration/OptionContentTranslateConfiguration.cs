using HH.dal.Models.Product;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HH.dal.Data.Configuration.ProductConfiguration
{
    public class OptionContentTranslateConfiguration: IEntityTypeConfiguration<OptionContentTranslate>
    {
        public void Configure(EntityTypeBuilder<OptionContentTranslate> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.LanguageCulture).IsRequired();
            builder.Property(x => x.OptionContentId).IsRequired();
        }
    }
}
