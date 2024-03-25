using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Core.Entities
{
    public class Doctor
    {
        public Doctor(string firstName, string lastName, DateTime birthDay, string phone, string email, string password, string cPF, BloodTypeEnum bloodType, SpecialtyEnum specialty, string[] solutions, string cRM)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            Password = password;
            Role = RoleEnum.Doctor;
            CPF = cPF;
            BloodType = bloodType;
            Specialty = specialty;
            Solutions = solutions;
            CRM = cRM;
            Active = true;
            CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }
        public string CPF { get; set; }
        public BloodTypeEnum BloodType { get; set; }
        public SpecialtyEnum Specialty { get; set; }
        public string[] Solutions { get; set; }
        public string CRM { get; set; }
        public Address Address { get; set; }
        public List<Service> Services { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public void Update(string[] solutions)
        {
            Solutions = solutions;
            UpdatedAt = DateTime.Now;
        }

        public void Delete()
        {
            Active = false;
            UpdatedAt = DateTime.Now;
        }
    }
}
