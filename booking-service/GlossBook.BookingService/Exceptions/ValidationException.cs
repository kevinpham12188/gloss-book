namespace GlossBook.BookingService.Exceptions
{
    public class ValidationException : BaseCustomException
    {
        public ValidationException(string message) : base(400, message)
        {
        }
    }
}