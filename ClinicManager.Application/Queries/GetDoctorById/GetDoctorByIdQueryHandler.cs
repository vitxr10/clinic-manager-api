using ClinicManager.Application.ViewModels;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetDoctorById
{
    public class GetDoctorByIdQueryHandler : IRequestHandler<GetDoctorByIdQuery, DoctorDetailsViewModel>
    {
        private readonly IDoctorRepository _doctorRepository;
        public GetDoctorByIdQueryHandler(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task<DoctorDetailsViewModel> Handle(GetDoctorByIdQuery request, CancellationToken cancellationToken)
        {
            var doctor = await _doctorRepository.GetByIdAsync(request.Id);

            if (doctor == null)
                throw new Exception("Médico não encontrado.");

            var doctorDetailsViewModel = new DoctorDetailsViewModel
                (
                    doctor.Id,
                    doctor.FirstName,
                    doctor.LastName,
                    doctor.BirthDay,
                    doctor.Phone,
                    doctor.Email,
                    doctor.CPF,
                    doctor.BloodType,
                    doctor.Specialty,
                    doctor.Solutions,
                    doctor.CRM,
                    doctor.Address,
                    doctor.Active,
                    doctor.CreatedAt,
                    doctor.UpdatedAt
                );

            return doctorDetailsViewModel;
        }
    }
}
