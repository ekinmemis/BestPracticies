using FC.Core.Models;
using FC.Core.Repositories.cs;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FC.Data.Repoistories
{
    class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext AppDbContext { get => _context as AppDbContext; }
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int id)
        {
            return await AppDbContext.Category.Include(f => f.Products).FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
