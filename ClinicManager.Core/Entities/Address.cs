using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Core.Entities
{
    public class Address
    {
        public Address(int userDocument, int number, string city, string state, string cEP ,string neighborhood)
        {
            UserDocument = userDocument;
            Number = number;
            City = city;
            State = state;
            CEP = cEP;
            Neighborhood = neighborhood;
        }

        public int Id {  get; set; }
        public int UserDocument { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CEP { get; set; }
        public string Neighborhood { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Receptionist Recepsionist { get; set; }
    }
}
