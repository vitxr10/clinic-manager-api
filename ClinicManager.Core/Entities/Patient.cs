using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Core.Entities
{
    public class Patient
    {
        public Patient(string firstName, string lastName, DateTime birthDay, string phone, string email, string password, string cPF, BloodTypeEnum bloodType, double height, double weight)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            Password = password;
            Role = RoleEnum.Patient;
            CPF = cPF;
            BloodType = bloodType;
            Height = height;
            Weight = weight;
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
        public double Height { get; set; }
        public double Weight { get; set; }
        public Address Address { get; set; }
        public List<Service> Services { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public void Update(double height, double weight)
        {
            Height = height;
            Weight = weight;
            UpdatedAt = DateTime.Now;
        }

        public void Delete()
        {
            Active = false;
            UpdatedAt = DateTime.Now;
        }
    }
}
