using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .IsRequired()
            .HasMaxLength(3);

            builder.Property(p => p.Nombres)
                .IsRequired()
                .HasColumnName("Nombres")
                .HasComment("Nombres del proveedor")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(p => p.Apellidos)
                .IsRequired()
                .HasColumnName("Apellidos")
                .HasComment("Apellidos del proveedor")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(p => p.Edad)
                .IsRequired()
                .HasColumnName("Edad")
                .HasComment("Edad del proveedor")
                .HasColumnType("int")
                .HasMaxLength(3);

            builder.HasOne(p => p.TipoDocumento)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(p => p.IdTipoDocFK);

            builder.HasOne(p => p.Genero)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(p => p.IdGenFK);

            builder.HasOne(p => p.TipoPersona)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(p => p.IdTipoPerFK);

            builder.HasOne(p => p.Direccion)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(p => p.IdDirFK);

            builder.HasOne(p => p.Contacto)
                .WithMany(p => p.Proveedores)
                .HasForeignKey(p => p.IdConFK);
        }
    }
}