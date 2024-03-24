using ClinicManager.Application.Queries.GetAllPatients;
using ClinicManager.Application.ViewModels;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetAllServices
{
    public class GetAllServicesQueryHandler : IRequestHandler<GetAllServicesQuery, List<ServiceViewModel>>
    {
        private readonly IServiceRepository _serviceRepository;
        public GetAllServicesQueryHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<List<ServiceViewModel>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
        {
            var services = await _serviceRepository.GetAllAsync();

            var servicesViewModel = services
                .Select(s => new ServiceViewModel
                (
                    s.Id,
                    s.PatientId,
                    s.DoctorId,
                    s.Name,
                    s.StartDate,
                    s.Status,
                    s.Modality
                ))
                .ToList();

            return servicesViewModel;
        }
    }
}
