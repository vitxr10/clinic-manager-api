using ClinicManager.Core.Entities;
using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.ViewModels
{
    public class DoctorViewModel
    {
        public DoctorViewModel(int id, string firstName, string lastName, string phone, string email, string cPF, SpecialtyEnum specialty, string cRM, bool active)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            CPF = cPF;
            Specialty = specialty;
            CRM = cRM;
            Active = active;
        }

        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public SpecialtyEnum Specialty { get; private set; }
        public string CRM { get; private set; }
        public bool Active { get; private set; }
    }
}
