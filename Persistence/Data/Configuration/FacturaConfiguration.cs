using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class FacturaConfiguration : IEntityTypeConfiguration<Factura>
    {
        public void Configure(EntityTypeBuilder<Factura> builder)
        {
            builder.ToTable("Factura");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(f => f.FechaCreacion)
                .IsRequired()
                .HasColumnName("FechaCreacion")
                .HasComment("Fecha de creacion de la factura")
                .HasColumnType("datetime");

            builder.Property(f => f.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion de la factura")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(f => f.Valor)
                .IsRequired()
                .HasColumnName("Valor")
                .HasComment("Valor total de la factura")
                .HasColumnType("decimal(10,2)");

            builder.Property(f => f.Estado)
                .IsRequired()
                .HasColumnName("Estado")
                .HasComment("Estado de la factura")
                .HasColumnType("varchar(30)")
                .HasMaxLength(30);

            builder.Property(f => f.Cantidad)
                .IsRequired()
                .HasColumnName("Cantidad")
                .HasComment("Cantidad total de la factura")
                .HasColumnType("int")
                .HasMaxLength(7);

            builder.HasOne(p => p.Medicamento)
                .WithMany(p => p.Facturas)
                .HasForeignKey(p => p.IdMedFK);

            builder.HasOne(p => p.Farmaceutico)
                .WithMany(p => p.Facturas)
                .HasForeignKey(p => p.IdFarFK);

            builder.HasOne(p => p.Paciente)
                .WithMany(p => p.Facturas)
                .HasForeignKey(p => p.IdPacFK);

            builder.HasOne(p => p.Formula)
                .WithMany(p => p.Facturas)
                .HasForeignKey(p => p.IdForFK);
        }
    }
}