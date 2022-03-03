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
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsPublish).IsRequired();
            builder.Property(x => x.Image).IsRequired();
            builder.Property(x => x.SortOrder).IsRequired();
            builder.Property(x => x.RequestFile).IsRequired(false);
            builder.Property(x => x.DownloadFile).IsRequired(false);
            builder.HasMany(x => x.ProductTranslates).WithOne(x => x.Product).HasForeignKey(x => x.ProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
