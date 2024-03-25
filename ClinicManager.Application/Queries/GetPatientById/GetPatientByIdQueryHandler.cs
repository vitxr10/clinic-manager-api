using ClinicManager.Application.ViewModels;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetPatientById
{
    public class GetPatientByIdQueryHandler : IRequestHandler<GetPatientByIdQuery, PatientDetailsViewModel>
    {
        private readonly IPatientRepository _patientRepository;
        public GetPatientByIdQueryHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<PatientDetailsViewModel> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            var patient = await _patientRepository.GetByIdAsync(request.Id);

            if (patient == null)
                throw new Exception("Paciente não encontrado.");

            var pacientDetailsViewModel = new PatientDetailsViewModel
                (
                    patient.Id,
                    patient.FirstName,
                    patient.LastName,
                    patient.BirthDay,
                    patient.Phone,
                    patient.Email,
                    patient.CPF,
                    patient.BloodType,
                    patient.Height,
                    patient.Weight,
                    patient.Address,
                    patient.Active,
                    patient.CreatedAt,
                    (DateTime)patient.UpdatedAt
                );

            return pacientDetailsViewModel;
        }
    }
}
