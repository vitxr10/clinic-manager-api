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
        public Doctor(string firstName, string lastName, DateTime birthDay, string phone, string email, string password, string cPF, BloodTypeEnum bloodType, SpecialtyEnum specialty, List<string> solutions, string cRM, Address address)
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
            Address = address;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDay { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public RoleEnum Role { get; private set; }
        public string CPF { get; private set; }
        public BloodTypeEnum BloodType { get; private set; }
        public SpecialtyEnum Specialty { get; private set; }
        public List<string> Solutions { get; private set; }
        public string CRM { get; private set; }
        public Address Address { get; private set; }
        public List<Service> Services { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
