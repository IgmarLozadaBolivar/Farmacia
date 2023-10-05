using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class CompraProveedorConfiguration : IEntityTypeConfiguration<CompraProveedor>
    {
        public void Configure(EntityTypeBuilder<CompraProveedor> builder)
        {
            builder.ToTable("Compra Proveedor");

            builder.HasKey(cp => cp.Id);

            builder.Property(cp => cp.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(cp => cp.Precio)
                .IsRequired()
                .HasColumnName("Precio")
                .HasComment("Precio total de lo que se vendio")
                .HasColumnType("decimal(12,2)");
        
            builder.Property(cp => cp.Cantidad)
                .IsRequired()
                .HasColumnName("Cantidad")
                .HasComment("Cantidad que se vendio")
                .HasColumnType("int");

            builder.HasOne(p => p.Medicamentos)
                .WithMany(p => p.CompraProveedores)
                .HasForeignKey(p => p.IdMedFK);

            builder.HasOne(p => p.Proveedor)
                .WithMany(p => p.CompraProveedores)
                .HasForeignKey(p => p.IdProvFK);

            builder.HasOne(p => p.Farmaceutico)
                .WithMany(p => p.CompraProveedores)
                .HasForeignKey(p => p.IdFarFK);
        }
    }
}