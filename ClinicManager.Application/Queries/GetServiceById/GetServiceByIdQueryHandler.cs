using ClinicManager.Application.ViewModels;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetServiceById
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, ServiceDetailsViewModel>
    {
        private readonly IServiceRepository _serviceRepository;
        public GetServiceByIdQueryHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<ServiceDetailsViewModel> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetByIdAsync(request.Id);

            if (service == null)
                throw new Exception("Serviço não encontrado.");

            var serviceDetailsViewModel = new ServiceDetailsViewModel
                (
                    service.Id,
                    service.PatientId,
                    service.DoctorId,
                    service.ReceptionistId,
                    service.Name,
                    service.StartDate,
                    service.EndDate,
                    service.Status,
                    service.Modality
                );

            return serviceDetailsViewModel;
        }
    }
}
