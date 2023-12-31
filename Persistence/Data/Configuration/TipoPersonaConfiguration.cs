using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            builder.ToTable("Tipo Persona");

            builder.HasKey(tp => tp.Id);

            builder.Property(tp => tp.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(tp => tp.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del tipo de persona")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(tp => tp.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion del tipo de persona")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);
        }
    }
}