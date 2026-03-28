namespace GlossBook.BookingService.Exceptions
{
    public abstract class BaseCustomException : Exception
    {
        public int StatusCode {get; }
        public BaseCustomException(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }
        
    }
}