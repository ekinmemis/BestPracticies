using FC.Core.Models;
using System.Threading.Tasks;

namespace FC.Core.Repositories.cs
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int id);
    }
}
