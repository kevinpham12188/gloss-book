using GlossBook.BookingService.DTOs;
using GlossBook.BookingService.Exceptions;

namespace GlossBook.BookingService.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

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

        private static async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            var statusCode = ex is BaseCustomException customEx ? customEx.StatusCode : 500;
            var message = ex is BaseCustomException ? ex.Message : "An unexpected error occurred. Please try again later.";
            context.Response.StatusCode = statusCode;
            var response = new ApiResponse<object>
            {
                StatusCode = statusCode,
                Message = message,
                Data = null
            };

            await context.Response.WriteAsJsonAsync(response);
        }
    }
}