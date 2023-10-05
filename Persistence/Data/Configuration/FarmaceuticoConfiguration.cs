using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class FarmaceuticoConfiguration : IEntityTypeConfiguration<Farmaceutico>
    {
        public void Configure(EntityTypeBuilder<Farmaceutico> builder)
        {
            builder.ToTable("Farmaceutico");

            builder.HasKey(e => e.Id);

            builder.Property(f => f.Id)
            .IsRequired()
            .HasMaxLength(3);

            builder.Property(f => f.Nombres)
                .IsRequired()
                .HasColumnName("Nombres")
                .HasComment("Nombres del farmaceutico")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(f => f.Apellidos)
                .IsRequired()
                .HasColumnName("Apellidos")
                .HasComment("Apellidos del farmaceutico")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(f => f.Edad)
                .IsRequired()
                .HasColumnName("Edad")
                .HasComment("Edad del farmaceutico")
                .HasColumnType("int")
                .HasMaxLength(3);

            builder.HasOne(p => p.TipoDocumento)
                .WithMany(p => p.Farmaceuticos)
                .HasForeignKey(p => p.IdTipoDocFK);

            builder.HasOne(p => p.Genero)
                .WithMany(p => p.Farmaceuticos)
                .HasForeignKey(p => p.IdGenFK);

            builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Farmaceuticos)
                .HasForeignKey(p => p.IdTipoPerFK);

            builder.HasOne(p => p.Direccion)
                .WithMany(p => p.Farmaceuticos)
                .HasForeignKey(p => p.IdDirFK);

            builder.HasOne(p => p.Contacto)
                .WithMany(p => p.Farmaceuticos)
                .HasForeignKey(p => p.IdConFK);

            builder.HasOne(p => p.Cargo)
                .WithMany(p => p.Farmaceuticos)
                .HasForeignKey(p => p.IdCarFK);

            builder.HasOne(p => p.User)
                .WithMany(p => p.Farmaceuticos)
                .HasForeignKey(p => p.IdUserFK);
        }
    }
}