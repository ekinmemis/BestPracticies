using Autofac;

using Basic.Business.Abstract;
using Basic.DataAccess.Abstract;
using Basic.DataAccess.Concrete.EntityFramework;

using Business.Concrete;

namespace Basic.Business.DependencyResolvers.AutoFac
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
        }
    }
}