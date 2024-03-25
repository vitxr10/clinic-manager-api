using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Core.Entities
{
    public class Service
    {
        public Service(int patientId, int doctorId, int? receptionistId, string name, DateTime startDate, ServiceModalityEnum modality)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            ReceptionistId = receptionistId;
            Name = name;
            StartDate = startDate;
            EndDate = StartDate.AddMinutes(30);
            Modality = modality;
        }

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int? ReceptionistId { get; set; }
        public string Name { get; set; }
        //public DateTime Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ServiceStatusEnum Status { get; set; }
        public ServiceModalityEnum Modality { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Receptionist Receptionist { get; set; }

        public void Start()
        {
            Status = ServiceStatusEnum.Started;
        }

        public void Finish()
        {
            Status = ServiceStatusEnum.Finished;
        }

        public void Cancel()
        {
            Status = ServiceStatusEnum.Cancelled;
        }
    }
}
