using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Core.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int? ReceptionistId { get; set; }
        public string Name { get; set; }
        public DateTime Duration { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Receptionist Receptionist { get; set; }
    }
}
