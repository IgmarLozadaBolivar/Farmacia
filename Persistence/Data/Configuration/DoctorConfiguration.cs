using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("Doctor");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(d => d.Nombres)
                .IsRequired()
                .HasColumnName("Nombres")
                .HasComment("Nombres del docto")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(d => d.Apellidos)
                .IsRequired()
                .HasColumnName("Apellidos")
                .HasComment("Apellidos del doctor")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(d => d.Edad)
                .IsRequired()
                .HasColumnName("Edad")
                .HasComment("Edad del doctor")
                .HasColumnType("int")
                .HasMaxLength(3);

            builder.HasOne(p => p.Especializacion)
                .WithMany(p => p.Doctores)
                .HasForeignKey(p => p.IdEspFK);

            builder.HasOne(p => p.TipoDocumento)
                .WithMany(p => p.Doctores)
                .HasForeignKey(p => p.IdTipoDocFK);

            builder.HasOne(p => p.Genero)
                .WithMany(p => p.Doctores)
                .HasForeignKey(p => p.IdGenFK);

            builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Doctores)
                .HasForeignKey(p => p.IdTipoPerFK);

            builder.HasOne(p => p.Direccion)
                .WithMany(p => p.Doctores)
                .HasForeignKey(p => p.IdDirFK);

            builder.HasOne(p => p.Contacto)
                .WithMany(p => p.Doctores)
                .HasForeignKey(p => p.IdConFK);
        }
    }
}