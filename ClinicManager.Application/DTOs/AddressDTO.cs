﻿using ClinicManager.Core.Entities;
using ClinicManager.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.DTOs
{
    public class AddressDTO
    {
        public AddressDTO(RoleEnum userRole, int number, string city, string state, string cEP, string neighborhood)
        {
            UserRole = userRole;
            Number = number;
            City = city;
            State = state;
            CEP = cEP;
            Neighborhood = neighborhood;
        }

        public RoleEnum UserRole { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CEP { get; set; }
        public string Neighborhood { get; set; }
    }
}
