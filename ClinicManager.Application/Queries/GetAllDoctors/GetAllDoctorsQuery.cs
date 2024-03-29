﻿using ClinicManager.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetAllDoctors
{
    public class GetAllDoctorsQuery : IRequest<List<DoctorViewModel>>
    {
    }
}
