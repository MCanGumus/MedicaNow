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
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(y => y.Appointment).WithMany(u => u.Messages).HasForeignKey(y => y.AppointmentId).OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.Content).IsRequired().HasColumnType("varchar").HasMaxLength(250);
        }
    }
}
