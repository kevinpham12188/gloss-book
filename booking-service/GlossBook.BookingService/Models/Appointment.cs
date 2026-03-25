namespace GlossBook.BookingService.Models
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public Guid ClientId { get; set; }
        public Guid TechnicianId { get; set; }
        public Guid ServiceId { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
        public AppointmentStatus Status { get; set; }
        public decimal PriceAtBooking { get; set; }
        public string? Notes { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

    }
    public enum AppointmentStatus
    {
        Pending,
        Confirmed,
        Completed,
        Cancelled
    }
}