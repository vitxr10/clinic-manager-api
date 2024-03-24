using ClinicManager.Core.Entities;
using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommand, int>
    {
        private readonly IServiceRepository _serviceRepository;
        public CreateServiceCommandHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task<int> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var service = new Service
                (
                    request.PatientId,
                    request.DoctorId,
                    request.ReceptionistId,
                    request.Name,
                    request.StartDate,
                    request.Modality
                ) ;

            return await _serviceRepository.CreateAsync(service);
        }
    }
}
