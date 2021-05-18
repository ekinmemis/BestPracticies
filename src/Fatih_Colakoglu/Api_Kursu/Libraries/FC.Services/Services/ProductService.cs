using FC.Core.Models;
using FC.Core.Repositories.cs;
using FC.Core.Services;
using FC.Core.UnitOfWork;
using System.Threading.Tasks;

namespace FC.Services.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository)
            : base(unitOfWork, repository)
        {
        }

        public async Task<Product> GetWithCategoryByIdAsync(int id)
        {
            return await _unitOfWork.Product.GetWithCategoryByIdAsync(id);
        }
    }
}
