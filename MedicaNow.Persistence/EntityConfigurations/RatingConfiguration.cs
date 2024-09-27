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
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Doctor).WithMany(x => x.Ratings).HasForeignKey(x => x.DoctorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Patient).WithMany(x => x.Ratings).HasForeignKey(x => x.PatientId).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Feedback).IsRequired().HasColumnType("varchar").HasMaxLength(250);
        }
    }
}
