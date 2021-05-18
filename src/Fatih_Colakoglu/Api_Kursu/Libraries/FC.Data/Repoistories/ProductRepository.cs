using FC.Core.Models;
using FC.Core.Repositories.cs;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FC.Data.Repoistories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext AppDbContext { get => _context as AppDbContext; }
        public ProductRepository(AppDbContext context) : base(context)
        {

        }
        public async Task<Product> GetWithCategoryByIdAsync(int id)
        {
            return await AppDbContext.Product.Include(f => f.Category).FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
