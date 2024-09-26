using FKA.Domain.Entities;
using MedicaNow.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicaNow.Domain.Entities
{
    public class Doctor : BaseEntity
    {
        public Guid Id { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfStart { get; set; }
        public string Email { get; set; }  
        public string PhoneNumber { get; set; }  
        public string Address { get; set; }  

        public EnumSpeciality Specialty { get; set; } 
        public string LicenseNumber { get; set; } 
        public string Biography { get; set; } 
        public string ProfilePhoto { get; set; }

        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public string RefreshTokenKey { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Rating> Ratings { get; set; }

    }
}