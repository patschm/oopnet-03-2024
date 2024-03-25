﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebLingo.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LingoMiddleware
    {
        private readonly RequestDelegate _next;

        public LingoMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LingoMiddlewareExtensions
    {
        public static IApplicationBuilder UseLingoMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LingoMiddleware>();
        }
    }
}
