using MedicaNow.Domain.Entities;
using MedicaNow.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MedicaNow.Persistence.Context
{
    public class MedicaNowContext : DbContext
    {
        public MedicaNowContext(DbContextOptions<MedicaNowContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new RatingConfiguration());
            modelBuilder.ApplyConfiguration(new MessageConfiguration());
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}

