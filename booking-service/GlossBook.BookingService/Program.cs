using GlossBook.BookingService.Data;
using GlossBook.BookingService.Repositories;
using GlossBook.BookingService.Repositories.Interfaces;
using GlossBook.BookingService.Services;
using GlossBook.BookingService.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BookingDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
    .LogTo(Console.WriteLine, LogLevel.Information);
});
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();



app.Run();


