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
    public class ProductOptionConfiguration: IEntityTypeConfiguration<ProductOption>
    {
        public void Configure(EntityTypeBuilder<ProductOption> builder)
        {
            builder.HasKey(p => new { p.ProductId, p.OptionId});
            builder.HasOne(p => p.Product).WithMany(p => p.ProductOption).HasForeignKey(p => p.ProductId);
            builder.HasOne(p => p.Option).WithMany(p => p.ProductOption).HasForeignKey(p => p.OptionId);
        }
    }
}
