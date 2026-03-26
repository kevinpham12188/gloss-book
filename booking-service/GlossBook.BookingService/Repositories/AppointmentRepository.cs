using GlossBook.BookingService.Data;
using GlossBook.BookingService.Models;
using GlossBook.BookingService.Repositories.Interfaces;

namespace GlossBook.BookingService.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly BookingDbContext bookingDbContext;
        public AppointmentRepository(BookingDbContext bookingDbContext)
        {
            this.bookingDbContext = bookingDbContext;
        }

        public async Task<Appointment> CreateAsync(Appointment appointment)
        {
            appointment.CreatedAt = DateTimeOffset.UtcNow;
            await bookingDbContext.AddAsync(appointment);
            await bookingDbContext.SaveChangesAsync();
            return appointment;
        }
    }
}