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
                    request.CRM
                );

            await _doctorRepository.CreateAsync(doctor);

            var addressDTO = request.Address;
            var address = new Address
                (
                    doctor.Id,
                    addressDTO.UserRole,
                    addressDTO.Number,
                    addressDTO.City,
                    addressDTO.State,
                    addressDTO.CEP,
                    addressDTO.Neighborhood
                );

            doctor.Address = address;

            await _doctorRepository.SaveAsync();

            var teste = await _doctorRepository.GetByIdAsync(doctor.Id);

            return doctor.Id;
        }
    }
}
