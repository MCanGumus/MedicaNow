using FKA.Domain.Entities;
using MedicaNow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicaNow.Domain.Entities
{
    public class Appointment : BaseEntity
    {
        public Guid PatientId { get; set; }  
        public Guid DoctorId { get; set; }  
        public DateTime AppointmentDate { get; set; }  
        public EnumStatus Status { get; set; } 
        public string Reason { get; set; } 
        public string Notes { get; set; }  

        public Patient Patient { get; set; } 
        public Doctor Doctor { get; set; }

        public ICollection<Message> Messages{ get; set; }
    }
}
