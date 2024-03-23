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
        public string UserDocument { get; private set; }
        public int Number { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string CEP { get; private set; }
    }
}
