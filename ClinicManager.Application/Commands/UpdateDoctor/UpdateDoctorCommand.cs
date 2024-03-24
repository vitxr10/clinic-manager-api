using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.UpdateDoctor
{
    public class UpdateDoctorCommand : IRequest
    {
        public UpdateDoctorCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public string[] Solutions { get; private set; }
    }
}
