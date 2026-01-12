using System.Net;
using System.Text.Json;

namespace TaskManagement.Api.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        public readonly RequestDelegate _next;
        public GlobalExceptionMiddleware(RequestDelegate next) { _next = next; }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex) 
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        public async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var result = JsonSerializer.Serialize(new
            {
                status = false,
                statusMessage = ex.Message
            });

            await response.WriteAsync(result);
        }
    }
}
