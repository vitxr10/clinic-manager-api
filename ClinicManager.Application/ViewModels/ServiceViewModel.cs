using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.ViewModels
{
    public class ServiceViewModel
    {
        public ServiceViewModel(int id, int patientId, int doctorId, string name, DateTime startDate, ServiceStatusEnum status, ServiceModalityEnum modality)
        {
            Id = id;
            PatientId = patientId;
            DoctorId = doctorId;
            Name = name;
            StartDate = startDate;
            Status = status;
            Modality = modality;
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public ServiceStatusEnum Status { get; set; }
        public ServiceModalityEnum Modality { get; set; }
    }
}
