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
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.PhoneNumber).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.Address).IsRequired().HasColumnType("varchar").HasMaxLength(250);
            builder.Property(x => x.Biography).IsRequired().HasColumnType("varchar").HasMaxLength(350);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(x => x.LicenseNumber).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            builder.Property(y => y.Password).IsRequired().HasColumnType("varchar").HasMaxLength(256);
            builder.Property(y => y.PasswordSalt).IsRequired().HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.RefreshTokenKey).IsRequired().HasColumnType("varchar").HasMaxLength(256);

            builder.HasMany(u => u.Appointments).WithOne(y => y.Doctor).HasForeignKey(y => y.DoctorId);
            builder.HasMany(u => u.Ratings).WithOne(y => y.Doctor).HasForeignKey(y => y.DoctorId);
        }
    }
}
