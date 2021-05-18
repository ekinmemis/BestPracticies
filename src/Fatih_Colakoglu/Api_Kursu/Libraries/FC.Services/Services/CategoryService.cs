using FC.Core.Models;
using FC.Core.Repositories.cs;
using FC.Core.Services;
using FC.Core.UnitOfWork;
using System.Threading.Tasks;

namespace FC.Services.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) 
            : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int id)
        {
            return await _unitOfWork.Category.GetWithProductsByIdAsync(id);
        }
    }
}
