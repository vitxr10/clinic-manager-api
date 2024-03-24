using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.UpdatePatient
{
    public class UpdatePatientCommand : IRequest
    {
        public UpdatePatientCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public double Height { get; private set; }
        public double Weight { get; private set; }
    }
}
