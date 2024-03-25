using ClinicManager.Core.Entities;
using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.ViewModels
{
    public class PatientDetailsViewModel
    {
        public PatientDetailsViewModel(int id, string firstName, string lastName, DateTime birthDay, string phone, string email, string cPF, BloodTypeEnum bloodType, double height, double weight, Address address, bool active, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            CPF = cPF;
            BloodType = bloodType;
            Height = height;
            Weight = weight;
            Address = address;
            Active = active;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public BloodTypeEnum BloodType { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public Address Address { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
