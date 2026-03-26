

namespace GlossBook.BookingService.DTOs.Requests
{
    public class CreateAppointmentRequest
    {
        public Guid ClientId { get; set; }
        public Guid TechnicianId { get; set; }
        public Guid ServiceId { get; set; }
        // TODO: Remove once Catalog service is built — price should be fetched via HTTP call to Catalog
        public decimal PriceAtBooking { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public string? Notes { get; set; }
        
    }
}