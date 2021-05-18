using FC.Core.Repositories.cs;
using System.Threading.Tasks;

namespace FC.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IProductRepository Product { get; }
        ICategoryRepository Category { get; }
        Task CommitAsync();
        void Commit();
    }
}
