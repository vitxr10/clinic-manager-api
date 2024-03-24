using ClinicManager.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.DeletePatient
{
    public class DeletePatientCommandHandler : IRequestHandler<DeletePatientCommand>
    {
        private readonly IPatientRepository _patientRepository;
        public DeletePatientCommandHandler(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task Handle(DeletePatientCommand request, CancellationToken cancellationToken)
        {
            var pacient = await _patientRepository.GetByIdAsync(request.Id);

            if (pacient == null)
                throw new Exception("Paciente não encontrado.");

            pacient.Delete();

            await _patientRepository.SaveAsync();
        }
    }
}
