

namespace GlossBook.BookingService.DTOs.Requests
{
    public class CreateAppointmentRequest
    {
        public Guid ClientId { get; set; }
        public Guid TechnicianId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public string? Notes { get; set; }
        
    }
}