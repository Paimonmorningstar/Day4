using Microsoft.AspNetCore.Builder;

namespace Day4Middleware.Middlewares
{
    public static class MiddlewareExtentions
    {
        public static IApplicationBuilder UseLogginMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogginMiddleware>();
        }
    }
}