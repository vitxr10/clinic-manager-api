using ClinicManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Core.Repository
{
    public interface IPatientRepository
    {
        Task<Patient> GetByIdAsync(int id);
        Task<Patient> GetByDocumentAsync(string document);
        Task<List<Patient>> GetAllAsync();
        Task<int> CreateAsync(Patient patient);
        Task SaveAsync();

    }
}
