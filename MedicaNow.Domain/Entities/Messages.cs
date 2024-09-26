using FKA.Domain.Entities;
using MedicaNow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicaNow.Domain.Entities
{
    public class Message : BaseEntity
    {
        public Guid SenderId { get; set; }  
        public Guid ReceiverId { get; set; }
        public Guid AppointmentId { get; set; }
        public Appointment Appointment { get; set; }
        public string Content { get; set; } 
        public DateTime SentAt { get; set; }
        public bool IsRead { get; set; }  
        public EnumUserType SenderType { get; set; } 
        public EnumUserType ReceiverType { get; set; } 
    }
}
