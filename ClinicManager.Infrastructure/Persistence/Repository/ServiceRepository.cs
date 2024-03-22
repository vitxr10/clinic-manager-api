using ClinicManager.Core.Entities;
using ClinicManager.Core.Repository;
using ClinicManager.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Infrastructure.Persistence.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ClinicManagerDbContext _dbContext;
        public ServiceRepository(ClinicManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(Service service)
        {
            await _dbContext.Services.AddAsync(service);
            await _dbContext.SaveChangesAsync();

            return service.Id;
        }

        public async Task<List<Service>> GetAllAsync()
        {
            return await _dbContext.Services.ToListAsync();
        }

        public async Task<Service> GetByIdAsync(int id)
        {
            return await _dbContext.Services.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
