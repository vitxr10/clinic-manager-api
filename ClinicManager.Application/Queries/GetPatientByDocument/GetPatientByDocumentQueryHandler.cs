using ClinicManager.Application.ViewModels;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetPatientByDocument
{
    public class GetPatientByDocumentQueryHandler : IRequestHandler<GetPatientByDocumentQuery, PatientDetailsViewModel>
    {
        private readonly IPatientRepository _patientRepository;
        public GetPatientByDocumentQueryHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<PatientDetailsViewModel> Handle(GetPatientByDocumentQuery request, CancellationToken cancellationToken)
        {
            var patient = await _patientRepository.GetByDocumentAsync(request.Document);

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
                    patient.UpdatedAt
                );

            return pacientDetailsViewModel;
        }
    }
}
