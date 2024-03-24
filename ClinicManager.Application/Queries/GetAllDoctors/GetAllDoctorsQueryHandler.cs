using ClinicManager.Application.ViewModels;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetAllDoctors
{
    public class GetAllDoctorsQueryHandler : IRequestHandler<GetAllDoctorsQuery, List<DoctorViewModel>>
    {
        private readonly IDoctorRepository _doctorRepository;
        public GetAllDoctorsQueryHandler(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<List<DoctorViewModel>> Handle(GetAllDoctorsQuery request, CancellationToken cancellationToken)
        {
            var doctors = await _doctorRepository.GetAllAsync();

            var doctorViewModel = doctors
                .Select(d => new DoctorViewModel
                (
                    d.Id,
                    d.FirstName,
                    d.LastName,
                    d.Phone,
                    d.Email,
                    d.CPF,
                    d.Specialty,
                    d.CRM,
                    d.Active
                ))
                .ToList();

            return doctorViewModel;
        }
    }
}
