using ClinicManager.Core.Entities;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.CreateDoctor
{
    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand, int>
    {
        private readonly IDoctorRepository _doctorRepository;
        public CreateDoctorCommandHandler(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<int> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            var addressDTO = request.Address;
            var address = new Address
                (
                    request.CPF,
                    addressDTO.Number,
                    addressDTO.City,
                    addressDTO.State,
                    addressDTO.CEP
                );

            var doctor = new Doctor
                (
                    request.FirstName,
                    request.LastName,
                    request.BirthDay,
                    request.Phone,
                    request.Email,
                    request.Password,
                    request.CPF,
                    request.BloodType,
                    request.Specialty,
                    request.Solutions,
                    request.CRM,
                    address
                );

            await _doctorRepository.CreateAsync(doctor);

            return doctor.Id;
        }
    }
}
