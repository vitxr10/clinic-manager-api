using ClinicManager.Core.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Commands.CreateService
{
    public class CreateServiceCommand : IRequest<int>
    {
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int? ReceptionistId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public ServiceModalityEnum Modality { get; set; }
    }
}
