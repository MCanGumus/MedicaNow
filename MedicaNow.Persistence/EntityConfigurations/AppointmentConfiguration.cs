using MedicaNow.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicaNow.Persistence.EntityConfigurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Doctor).WithMany(x => x.Appointments).HasForeignKey(x => x.DoctorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Patient).WithMany(x => x.Appointments).HasForeignKey(x => x.PatientId).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Reason).IsRequired().HasColumnType("varchar").HasMaxLength(250);
            builder.Property(x => x.Notes).IsRequired().HasColumnType("varchar").HasMaxLength(250);

            builder.HasMany(x => x.Messages).WithOne(x => x.Appointment).HasForeignKey(x => x.AppointmentId);
        }
    }
}
