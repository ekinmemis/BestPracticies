using FC.Core.Models;
using FC.Data.Configurations;
using FC.Data.Seed;
using Microsoft.EntityFrameworkCore;

namespace FC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
         
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1, 2 }));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));

            modelBuilder.Entity<Person>().HasKey(f => f.Id);
            modelBuilder.Entity<Person>().Property(f => f.Id).UseIdentityColumn();
            modelBuilder.Entity<Person>().Property(f => f.Name).HasMaxLength(100);
            modelBuilder.Entity<Person>().Property(f => f.Surname).HasMaxLength(100);
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}
