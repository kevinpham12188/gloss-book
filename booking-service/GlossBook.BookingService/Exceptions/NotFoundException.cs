namespace GlossBook.BookingService.Exceptions
{
    public class NotFoundException : BaseCustomException
    {
        public NotFoundException(string message) : base(404, message)
        {
        }
    }
}