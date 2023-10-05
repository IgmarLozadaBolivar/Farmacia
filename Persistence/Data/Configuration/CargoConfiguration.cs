using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("Cargo");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(c => c.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del cargo")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(c => c.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion del cargo")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);
        }
    }
}