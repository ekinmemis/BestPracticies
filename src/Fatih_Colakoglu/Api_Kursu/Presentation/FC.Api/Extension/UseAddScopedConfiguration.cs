using FC.Api.Filters;
using FC.Core.Repositories.cs;
using FC.Core.Services;
using FC.Core.UnitOfWork;
using FC.Data.Repoistories;
using FC.Data.UnitOfWorks;
using FC.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FC.Api.Extension
{
    public static class UseAddScopedConfiguration
    {
        public static void AddServiceScoped(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<NotFoundFilter>();
        }
    }
}
