using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartGowala.API.Mapping
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection ConfigAutoMapper(this IServiceCollection serviceCollection)
        {
            Business.Infrastructure.Mapping.AutomapperBootstrapper.Initialize();
            return serviceCollection;
        }
    }
}
