using ClinicManager.Core.Entities;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.CreatePatient
{
    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, int>
    {
        private readonly IPatientRepository _patientRepository;
        public CreatePatientCommandHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<int> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            var patient = new Patient
                (
                    request.FirstName,
                    request.LastName,
                    request.BirthDay,
                    request.Phone,
                    request.Email,
                    request.Password,
                    request.CPF,
                    request.BloodType,
                    request.Height,
                    request.Weight
                );

            await _patientRepository.CreateAsync(patient);

            
            var addressDTO = request.Address;

            var address = new Address
                (
                    patient.Id,
                    addressDTO.UserRole,
                    addressDTO.Number,
                    addressDTO.City,
                    addressDTO.State,
                    addressDTO.CEP,
                    addressDTO.Neighborhood
                );

            patient.Address = address;

            await _patientRepository.SaveAsync();

            return patient.Id;
        }
    }
}
