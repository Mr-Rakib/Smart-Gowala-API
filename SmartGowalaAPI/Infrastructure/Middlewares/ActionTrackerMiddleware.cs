using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using SmartGowala.Business.Business.Services;
using SmartGowala.Business.Business.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SmartGowala.API.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ActionTrackerMiddleware
    {
        public readonly RequestDelegate _next;
        public readonly IActionTrackerService _actionTrackerService;
        public ActionTrackerMiddleware(RequestDelegate next, IActionTrackerService actionTrackerService)
        {
            _next = next;
            _actionTrackerService = actionTrackerService;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            ActionTrackerViewModel tracker = new ActionTrackerViewModel();
            tracker.UserId = 1;
            tracker.Method = httpContext.Request.Method;
            tracker.Path = httpContext.Request.Path.Value;
            tracker.Matchine = Dns.GetHostEntry(httpContext.Connection.RemoteIpAddress).HostName;
            tracker.Browser = httpContext.Request.Headers["User-Agent"];
            tracker.IP = string.Concat(httpContext.Request.Host.Value, $" - (Remote IP:{httpContext.Connection.RemoteIpAddress} )");
            tracker.ActionDate = DateTime.Now; ;

            await _actionTrackerService.InsertAsync(tracker);
            await _actionTrackerService.SaveChangesAsync();
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ActionTrackerMiddlewareExtensions
    {
        public static IApplicationBuilder UseActionTrackerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ActionTrackerMiddleware>();
        }
    }
}
