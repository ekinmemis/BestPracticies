using FC.Core.Models;
using System.Threading.Tasks;

namespace FC.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<Product> GetWithCategoryByIdAsync(int id);
        // bool ControlInnerBarcode(Product product);
    }
}
