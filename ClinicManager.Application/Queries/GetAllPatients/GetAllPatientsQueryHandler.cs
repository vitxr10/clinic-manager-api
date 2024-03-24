using ClinicManager.Application.ViewModels;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetAllPatients
{
    public class GetAllPatientsQueryHandler : IRequestHandler<GetAllPatientsQuery, List<PatientViewModel>>
    {
        private readonly IPatientRepository _patientRepository;
        public GetAllPatientsQueryHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<List<PatientViewModel>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
        {
            var patients = await _patientRepository.GetAllAsync();

            var patientsViewModel = patients
                .Select(p => new PatientViewModel
                (
                    p.Id,
                    p.FirstName,
                    p.LastName,
                    p.BirthDay,
                    p.Email,
                    p.CPF,
                    p.Active
                ))
                .ToList();

            return patientsViewModel;
        }
    }
}
