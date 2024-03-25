using ClinicManager.Core.Entities;
using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.ViewModels
{
    public class PatientViewModel
    {
        public PatientViewModel(int id, string firstName, string lastName, DateTime birthDay, string email, string cPF, bool active)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Email = email;
            CPF = cPF;
            Active = active;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public bool Active { get; set; }
    }
}
