using FC.Core.Repositories.cs;
using FC.Core.UnitOfWork;
using FC.Data.Repoistories;
using System.Threading.Tasks;

namespace FC.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IProductRepository Product => _productRepository ?? new ProductRepository(_appDbContext);
        public ICategoryRepository Category => _categoryRepository ?? new CategoryRepository(_appDbContext);

        public void Commit()
        {
            _appDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _appDbContext.SaveChangesAsync();
        }
    }
}
