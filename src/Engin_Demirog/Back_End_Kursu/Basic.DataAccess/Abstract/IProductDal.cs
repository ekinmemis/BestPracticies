using Basic.Core.DataAccess;
using Basic.Entities.Concrete;

namespace Basic.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Products>
    {
    }
}