using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.CancelService
{
    public class CancelServiceCommandHandler : IRequestHandler<CancelServiceCommand>
    {
        private readonly IServiceRepository _serviceRepository;
        public CancelServiceCommandHandler(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task Handle(CancelServiceCommand request, CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetByIdAsync(request.Id);

            if (service == null)
                throw new Exception("Serviço não encontrado.");

            service.Cancel();

            await _serviceRepository.SaveAsync();
        }
    }
}
