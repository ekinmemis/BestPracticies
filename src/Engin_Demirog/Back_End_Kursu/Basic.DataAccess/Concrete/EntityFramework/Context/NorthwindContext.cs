using Basic.Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace Basic.DataAccess.Concrete.EntityFramework.Context
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-DFVJ9NF;Initial Catalog = Northwind;User ID=sa;Password=ekinmemis123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
