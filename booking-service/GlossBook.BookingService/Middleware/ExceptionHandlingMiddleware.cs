using GlossBook.BookingService.DTOs;

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

        private static async Task HandleExceptionAsync(HttpContext context, Exception e)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500;

            var response = new ApiResponse<object>
            {
                StatusCode = 500,
                Message = "An unexpected error occurred. Please try again later.",
                Data = null
            };

            await context.Response.WriteAsJsonAsync(response);
        }
    }
}