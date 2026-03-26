using System.Net;

namespace GlossBook.BookingService.DTOs
{
    public class ApiResponse<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public string? Message { get; set; }
        public T? Data {get; set; } 
        public bool IsSuccess => (int)StatusCode >= 200 && (int)StatusCode < 300;
    }
}