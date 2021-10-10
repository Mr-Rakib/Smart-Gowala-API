using Microsoft.AspNetCore.Builder;
using SmartGowala.API.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartGowala.API.Infrastructure
{
    public static class CustomMiddleware
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app)
        {
            app.UseActionTrackerMiddleware();
            app.UseHandleErrorMiddleware();
            return app;
        }
    }
}
