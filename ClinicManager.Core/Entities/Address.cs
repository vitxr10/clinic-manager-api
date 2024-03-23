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
        public Address(string userDocument, int number, string city, string state, string cEP)
        {
            UserDocument = userDocument;
            Number = number;
            City = city;
            State = state;
            CEP = cEP;
        }

        public int Id {  get; private set; }
        public string UserDocument { get; private set; }
        public int Number { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string CEP { get; private set; }
        public Patient Patient { get; private set; }
        public Doctor Doctor { get; private set; }
        public Receptionist Recepsionist { get; private set; }
    }
}
