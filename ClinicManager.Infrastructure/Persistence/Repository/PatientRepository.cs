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
    public class PatientRepository : IPatientRepository
    {
        private readonly ClinicManagerDbContext _dbContext;
        public PatientRepository(ClinicManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateAsync(Patient patient)
        {
            await _dbContext.Patients.AddAsync(patient);
            await _dbContext.SaveChangesAsync();

            return patient.Id;
        }

        public async Task<List<Patient>> GetAllAsync()
        {
            return await _dbContext.Patients.ToListAsync();
        }

        public async Task<Patient> GetByDocumentAsync(string document)
        {
            return await _dbContext.Patients.SingleOrDefaultAsync(p => p.CPF == document);
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            return await _dbContext.Patients.SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
