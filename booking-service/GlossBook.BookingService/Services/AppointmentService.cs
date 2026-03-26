using GlossBook.BookingService.DTOs.Requests;
using GlossBook.BookingService.DTOs.Responses;
using GlossBook.BookingService.Models;
using GlossBook.BookingService.Repositories.Interfaces;
using GlossBook.BookingService.Services.Interfaces;

namespace GlossBook.BookingService.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository appointmentRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            this.appointmentRepository = appointmentRepository;
        }

        #region Public Methods
        public async Task<AppointmentResponse> CreateAppointmentAsync(CreateAppointmentRequest createAppointmentRequest)
        {
            var appointment = new Appointment
            {
                ClientId = createAppointmentRequest.ClientId,
                TechnicianId = createAppointmentRequest.TechnicianId,
                ServiceId = createAppointmentRequest.ServiceId,
                Status = AppointmentStatus.Pending,
                StartTime = createAppointmentRequest.StartTime,
                EndTime = createAppointmentRequest.EndTime,
                Notes = createAppointmentRequest.Notes
            };

            var createdAppointment = await appointmentRepository.CreateAsync(appointment);
            return new AppointmentResponse
            {
                Id = createdAppointment.Id,
                ClientId = createdAppointment.ClientId,
                ServiceId = createdAppointment.ServiceId,
                TechnicianId = createdAppointment.TechnicianId,
                StartTime = createdAppointment.StartTime,
                EndTime = createdAppointment.EndTime,
                Status = createdAppointment.Status,
                PriceAtBooking = createdAppointment.PriceAtBooking,
                Notes = createdAppointment.Notes,
                CreatedAt = createdAppointment.CreatedAt
            };
        }
        #endregion
    }
}