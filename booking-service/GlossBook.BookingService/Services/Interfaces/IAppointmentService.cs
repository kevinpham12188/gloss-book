using GlossBook.BookingService.DTOs.Requests;
using GlossBook.BookingService.DTOs.Responses;

namespace GlossBook.BookingService.Services.Interfaces
{
    public interface IAppointmentService
    {
         Task<AppointmentResponse> CreateAppointmentAsync(CreateAppointmentRequest createAppointmentRequest);
    }
}