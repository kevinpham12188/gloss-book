using System.Net;
using GlossBook.BookingService.DTOs;
using GlossBook.BookingService.DTOs.Requests;
using GlossBook.BookingService.DTOs.Responses;
using GlossBook.BookingService.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GlossBook.BookingService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentsController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppointment([FromBody] CreateAppointmentRequest createAppointmentRequest)
        {
            var appointment = await _appointmentService.CreateAppointmentAsync(createAppointmentRequest);
            return StatusCode(201, new ApiResponse<AppointmentResponse> {
               StatusCode = HttpStatusCode.Created,
               Message = "Appointment created successfully",
               Data = appointment 
            });
        }
        
    }
}