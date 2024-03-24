using ClinicManager.Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Application.Queries.GetAllPatients
{
    public class GetAllPatientsQuery : IRequest<List<PatientViewModel>>
    {
    }
}
