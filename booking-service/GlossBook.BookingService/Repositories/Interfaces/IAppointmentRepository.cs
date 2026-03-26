using GlossBook.BookingService.Models;

namespace GlossBook.BookingService.Repositories.Interfaces
{
    public interface IAppointmentRepository
    {
         Task<Appointment> CreateAsync(Appointment appointment);
    }
}