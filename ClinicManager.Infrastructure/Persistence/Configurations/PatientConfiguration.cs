﻿using ClinicManager.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManager.Infrastructure.Persistence.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.ToTable("TB_Patients");

            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Address)
                .WithOne()
                .HasForeignKey<Address>(a => a.UserId);

            builder.HasMany(p => p.Services)
                .WithOne()
                .HasForeignKey(s => s.PatientId);
        }
    }
}
