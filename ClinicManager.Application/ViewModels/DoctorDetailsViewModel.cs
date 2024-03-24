using ClinicManager.Core.Entities;
using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.ViewModels
{
    public class DoctorDetailsViewModel
    {
        public DoctorDetailsViewModel(int id, string firstName, string lastName, DateTime birthDay, string phone, string email, string cPF, BloodTypeEnum bloodType, SpecialtyEnum specialty, string[] solutions, string cRM, Address address, bool active, DateTime createdAt, DateTime updatedAt)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            CPF = cPF;
            BloodType = bloodType;
            Specialty = specialty;
            Solutions = solutions;
            CRM = cRM;
            Address = address;
            Active = active;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDay { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public BloodTypeEnum BloodType { get; private set; }
        public SpecialtyEnum Specialty { get; private set; }
        public string[] Solutions { get; private set; }
        public string CRM { get; private set; }
        public Address Address { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
