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
        public Patient(string firstName, string lastName, DateTime birthDay, string phone, string email, string password, string cPF, BloodTypeEnum bloodType, double height, double weight, Address address)
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
            Address = address;
            Active = true;
            CreatedAt = DateTime.Now;
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
        public double Height { get; private set; }
        public double Weight { get; private set; }
        public Address Address { get; private set; }
        public List<Service> Services { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

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
