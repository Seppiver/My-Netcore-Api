using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MyNetCoreApi.Middleware
{
    public class AuthenticationMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Check for authentication token in the request headers
            if (!context.Request.Headers.TryGetValue("Authorization", out var token))
            {
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("Unauthorized");
                return;
            }

            // Validate the token (this is a placeholder for actual validation logic)
            if (token != "YourValidTokenHere")
            {
                context.Response.StatusCode = 403; // Forbidden
                await context.Response.WriteAsync("Forbidden");
                return;
            }

            // Call the next middleware in the pipeline
            await _next(context);
        }
    }
}