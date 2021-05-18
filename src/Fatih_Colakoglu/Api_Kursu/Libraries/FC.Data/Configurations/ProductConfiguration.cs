using FC.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FC.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));
            builder.Property(f => f.Id).UseIdentityColumn();
            builder.Property(f => f.Name).IsRequired().HasMaxLength(200);
            builder.Property(f => f.Stock).IsRequired();
            builder.Property(p => p.InnerBarcode).HasMaxLength(50);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}
