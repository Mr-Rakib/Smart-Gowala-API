using Microsoft.Extensions.DependencyInjection;
using SmartGowala.Business.Business.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartGowala.Business.Infrastructure.IOC
{
    public static class ServiceModule
    {
        public static IServiceCollection AddScopedServices_SGModule(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserRoleService, UserRoleService>();
            serviceCollection.AddScoped<IActionTrackerService, ActionTrackerService>();
            return serviceCollection;
        }
    }
}
