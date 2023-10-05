using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class EspecializacionConfiguration : IEntityTypeConfiguration<Especializacion>
    {
        public void Configure(EntityTypeBuilder<Especializacion> builder)
        {
            builder.ToTable("Especializacion");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre de la especializacion")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(e => e.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion de la especializacion")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(e => e.FechaRegistro)
                .IsRequired()
                .HasColumnName("FechaRegistro")
                .HasComment("Fecha de registro de la especializacion")
                .HasColumnType("datetime");
        }
    }
}