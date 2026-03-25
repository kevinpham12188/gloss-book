namespace GlossBook.BookingService.Models
{
    public class StaffBreak
    {
        public Guid Id { get; set; }
        public Guid ScheduleId { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string? Label { get; set; }
    }
}