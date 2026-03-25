namespace GlossBook.BookingService.Models
{
    public class StaffScheduleOverride
    {
        public Guid Id { get; set; }
        public Guid TechnicianId { get; set; }
        public DateOnly Date { get; set; }
        public bool IsAvailable { get; set; }
        public TimeOnly? StartTime { get; set; }
        public TimeOnly? EndTime { get; set; }
        public string? Reason { get; set; }
    }
}