using FC.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FC.Data.Seed
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { CategoryId = _ids[0], Id = 1, InnerBarcode = "123456", IsDeleted = false, Name = "Pilot Kalem", Price = 33.33M, Stock = 20 },
                new Product { CategoryId = _ids[0], Id = 2, InnerBarcode = "654321", IsDeleted = false, Name = "Kurşun Kalem", Price = 33.33M, Stock = 20 },
                new Product { CategoryId = _ids[0], Id = 3, InnerBarcode = "135790", IsDeleted = false, Name = "Dolma Kalem", Price = 33.33M, Stock = 20 },
                new Product { CategoryId = _ids[0], Id = 4, InnerBarcode = "097531", IsDeleted = false, Name = "Uçlu Kalem", Price = 33.33M, Stock = 20 },
                new Product { CategoryId = _ids[0], Id = 5, InnerBarcode = "108642", IsDeleted = false, Name = "Tükenmez Kalem", Price = 33.33M, Stock = 20 },
                new Product { CategoryId = _ids[1], Id = 6, InnerBarcode = "126789", IsDeleted = false, Name = "Defter", Price = 33.33M, Stock = 20 },
                new Product { CategoryId = _ids[0], Id = 7, InnerBarcode = "108642", IsDeleted = false, Name = "Kara Kalem", Price = 33.33M, Stock = 20 });
        }
    }
}
