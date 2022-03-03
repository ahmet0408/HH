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
    public class OptionConfiguration: IEntityTypeConfiguration<Option>
    {
        public void Configure(EntityTypeBuilder<Option> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OptionCode).IsRequired();
            builder.HasMany(x => x.OptionContent).WithOne(x => x.Option).HasForeignKey(x => x.OptionId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
