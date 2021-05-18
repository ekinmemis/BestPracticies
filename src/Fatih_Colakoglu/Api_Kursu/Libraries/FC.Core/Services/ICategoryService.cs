using FC.Core.Models;
using System.Threading.Tasks;

namespace FC.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int id);
    }
}
