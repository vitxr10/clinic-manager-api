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
    public class ReceptionistConfiguration : IEntityTypeConfiguration<Receptionist>
    {
        public void Configure(EntityTypeBuilder<Receptionist> builder)
        {
            builder.ToTable("TB_Receptionists");

            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Address)
                .WithOne(a => a.Recepsionist)
                .HasForeignKey<Address>(a => a.UserDocument);

            builder.HasMany(r => r.Services)
                .WithOne(s => s.Receptionist)
                .HasForeignKey(s => s.ReceptionistId);
        }
    }
}
