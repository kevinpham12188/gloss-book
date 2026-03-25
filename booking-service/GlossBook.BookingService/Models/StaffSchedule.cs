namespace GlossBook.BookingService.Models
{
    public class StaffSchedule
    {
        public Guid Id { get; set; }
        public Guid TechnicianId { get; set; }
        public int DayOfWeek { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public bool IsActive { get; set; } = true;
    }
}