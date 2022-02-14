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
    public class OptionContentConfiguration: IEntityTypeConfiguration<OptionContent>
    {
        public void Configure(EntityTypeBuilder<OptionContent> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OptionId).IsRequired();
            builder.Property(x => x.SortOrder).IsRequired();
            builder.HasMany(x => x.OptionContentTranslates).WithOne(x => x.OptionContent).HasForeignKey(x => x.OptionContentId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
