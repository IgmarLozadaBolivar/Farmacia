using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("Rol");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(r => r.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del rol")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);
        }
    }
}