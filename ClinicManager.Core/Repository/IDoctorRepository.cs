using ClinicManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Core.Repository
{
    public interface IDoctorRepository
    {
        Task<Doctor> GetByIdAsync(int id);
        Task<List<Doctor>> GetAllAsync();
        Task<int> CreateAsync(Doctor doctor);
        Task SaveAsync();

    }
}
