using ClinicManager.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Core.Repository
{
    public interface IServiceRepository
    {
        Task<Service> GetByIdAsync(int id);
        Task<List<Service>> GetAllAsync();  
        Task<int> CreateAsync(Service service);
        Task SaveAsync();
    }
}
