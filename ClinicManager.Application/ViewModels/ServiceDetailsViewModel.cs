using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.ViewModels
{
    public class ServiceDetailsViewModel
    {
        public ServiceDetailsViewModel(int id, int patientId, int doctorId, int? receptionistId, string name, DateTime startDate, DateTime endDate, ServiceStatusEnum status, ServiceModalityEnum modality)
        {
            Id = id;
            PatientId = patientId;
            DoctorId = doctorId;
            ReceptionistId = receptionistId;
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Status = status;
            Modality = modality;
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int? ReceptionistId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ServiceStatusEnum Status { get; set; }
        public ServiceModalityEnum Modality { get; set; }
    }
}
