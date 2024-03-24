using ClinicManager.Application.DTOs;
using ClinicManager.Core.Entities;
using ClinicManager.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.CreateDoctor
{
    public class CreateDoctorCommand : IRequest<int>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDay { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string CPF { get; private set; }
        public BloodTypeEnum BloodType { get; private set; }
        public SpecialtyEnum Specialty { get; private set; }
        public string[] Solutions { get; private set; }
        public string CRM { get; private set; }
        public AddressDTO Address { get; set; }
    }
}
