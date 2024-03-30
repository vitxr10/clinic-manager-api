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
    public class ReceptionistConfiguration : IEntityTypeConfiguration<Receptionist>
    {
        public void Configure(EntityTypeBuilder<Receptionist> builder)
        {
            builder.ToTable("TB_Receptionists");

            builder.HasKey(r => r.Id);

            builder.HasOne(r => r.Address)
                .WithOne()
                .HasForeignKey<Address>(a => a.UserId);

            builder.HasMany(r => r.Services)
                .WithOne()
                .HasForeignKey(s => s.ReceptionistId);
        }
    }
}
