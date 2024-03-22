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
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ClinicManagerDbContext _dbContext;
        public DoctorRepository(ClinicManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(Doctor doctor)
        {
            await _dbContext.Doctors.AddAsync(doctor);
            await _dbContext.SaveChangesAsync();

            return doctor.Id;
        }

        public async Task<List<Doctor>> GetAllAsync()
        {
            return await _dbContext.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return await _dbContext.Doctors.SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
