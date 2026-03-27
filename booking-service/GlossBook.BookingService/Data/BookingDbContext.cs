using GlossBook.BookingService.Models;
using Microsoft.EntityFrameworkCore;

namespace GlossBook.BookingService.Data
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        {
            
        }
        public DbSet<Appointment> Appointments{ get; set; }
        public DbSet<StaffBreak> StaffBreaks { get; set; }
        public DbSet<StaffSchedule> StaffSchedules { get; set; }
        public DbSet<StaffScheduleOverride> StaffScheduleOverrides { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Appointment>(entity =>
                {
                    entity.Property(a => a.Status).HasConversion<string>()
                    .HasColumnType("appointment_status");
                    entity.Property(a => a.PriceAtBooking).HasColumnType("numeric(10,2)");
                });
                
                
                
            }
    }
}