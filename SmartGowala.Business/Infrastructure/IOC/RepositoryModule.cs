using Microsoft.Extensions.DependencyInjection;
using SmartGowala.Data.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Business.Infrastructure.IOC
{
    public static class RepositoryModule
    {
        public static IServiceCollection AddScopedRepositories_SGModule(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserRoleRepository, UserRoleRepository>();
            serviceCollection.AddScoped<IActionTrackerRepository, ActionTrackerRepository>();
            return serviceCollection;
        }
    }
}
