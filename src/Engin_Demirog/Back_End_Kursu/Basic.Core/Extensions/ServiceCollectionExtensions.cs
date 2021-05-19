using Basic.Core.Utilities.IoC;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection services, List<ICoreModule> modules)
        {
            modules.ForEach(module => { module.Load(services); });
            return ServiceTool.Create(services);
        }
    }
}
