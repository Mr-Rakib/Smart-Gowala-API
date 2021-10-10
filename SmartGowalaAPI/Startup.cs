using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SmartGowala.API.Infrastructure;
using SmartGowala.API.Mapping;
using SmartGowala.API.Middlewares;
using SmartGowala.Business.Business.Services;
using SmartGowala.Business.Infrastructure.IOC;
using SmartGowala.Data.Data.Context;

namespace SmartGowalaAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<SmartGowalaDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DemoFaceBook.Sql")));
            services.AddAutoMapper()
            .ConfigAutoMapper() // config auto mapper object in API
            .AddScopedServices_SGModule() //  add IOC DI service mapper from Business
            .AddScopedRepositories_SGModule(); //  add IOC DI repository mapper from Business
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseStatusCodePages();
            CustomMiddleware.UseCustomMiddleware(app);
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                   name: "default",
                   pattern: "{controller}/{action=Index}/{id?}");
            });
        }
    }
}
