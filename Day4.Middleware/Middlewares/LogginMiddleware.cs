using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace Day4Middleware.Middlewares
{
    public class LogginMiddleware
    {
        private readonly RequestDelegate _next;
        public LogginMiddleware(RequestDelegate next)
        {
            _next = next;
        }
    public async Task Invoke(HttpContext context)
        {
            var request = context.Request;
            string requestInfo = "scheme:" + request.Scheme +
            "\tHost" + request.Host +
            "\tPath" + request.Path +
            "\tQueryString" + request.QueryString+
            "\tRequestBody" + request.Body;

            Debug.Write(requestInfo);
            File.WriteAllText("textInformation.txt", requestInfo);

            await _next(context);
        }
    }
}
