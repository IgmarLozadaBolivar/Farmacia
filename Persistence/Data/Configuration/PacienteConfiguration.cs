using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {
            builder.ToTable("Paciente");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .IsRequired()
            .HasMaxLength(3);

            builder.Property(p => p.Nombres)
                .IsRequired()
                .HasColumnName("Nombres")
                .HasComment("Nombres del paciente")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(p => p.Apellidos)
                .IsRequired()
                .HasColumnName("Apellidos")
                .HasComment("Apellidos del paciente")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(p => p.FechaNac)
                .IsRequired()
                .HasColumnName("FechaNac")
                .HasComment("Fecha de nacimiento del paciente")
                .HasColumnType("datetime");

            builder.Property(p => p.Edad)
                .IsRequired()
                .HasColumnName("Edad")
                .HasComment("Edad del paciente")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.HasOne(p => p.TipoDocumento)
                .WithMany(p => p.Pacientes)
                .HasForeignKey(p => p.IdTipoDocFK);

            builder.HasOne(p => p.Genero)
                .WithMany(p => p.Pacientes)
                .HasForeignKey(p => p.IdGenFK);

            builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Pacientes)
                .HasForeignKey(p => p.IdTipoPerFK);

            builder.HasOne(p => p.Direccion)
                .WithMany(p => p.Pacientes)
                .HasForeignKey(p => p.IdDirFK);

            builder.HasOne(p => p.Contacto)
                .WithMany(p => p.Pacientes)
                .HasForeignKey(p => p.IdConFK);
        }
    }
}