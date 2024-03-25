using ClinicManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.DTOs
{
    public class AddressDTO
    {
        public AddressDTO(int userDocument, int number, string city, string state, string cEP, string neighborhood)
        {
            UserDocument = userDocument;
            Number = number;
            City = city;
            State = state;
            CEP = cEP;
            Neighborhood = neighborhood;    
        }

        public int UserDocument { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CEP { get; set; }
        public string Neighborhood { get; set; }
    }
}
