using FC.Core.Models;
using System.Threading.Tasks;

namespace FC.Core.Repositories.cs
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Task<Category> GetWithProductsByIdAsync(int id);
    }
}
