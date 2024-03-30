using ClinicManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Infrastructure.Persistence.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("TB_Doctors");

            builder.HasKey(d => d.Id);

            builder.HasOne(d => d.Address)
                .WithOne()
                .HasForeignKey<Address>(a => a.UserId);

            builder.HasMany(d => d.Services)
                .WithOne()
                .HasForeignKey(s => s.DoctorId);
        }
    }
}
