using Basic.Core.DataAccess.EntityFramework;
using Basic.DataAccess.Abstract;
using Basic.DataAccess.Concrete.EntityFramework;
using Basic.DataAccess.Concrete.EntityFramework.Context;
using Basic.Entities.Concrete;

namespace Basic.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EFEntityRepository<Products, NorthwindContext>, IProductDal
    {

    }
}


