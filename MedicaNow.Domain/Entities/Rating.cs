using FKA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicaNow.Domain.Entities
{
    public class Rating : BaseEntity
    {
        public Guid DoctorId { get; set; }  // Puanın verildiği doktorun kimliği
        public Doctor Doctor { get; set; }  // İlişkili Doktor entity'si

        public Guid PatientId { get; set; }  // Puanı veren hastanın kimliği
        public Patient Patient { get; set; }  // İlişkili Patient entity'si

        public int Score { get; set; }  // Puan (örneğin, 1 ile 5 arasında)
        public string Feedback { get; set; }  // Geri bildirim (isteğe bağlı)
    }
}
