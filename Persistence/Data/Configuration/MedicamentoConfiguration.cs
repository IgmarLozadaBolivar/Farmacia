using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MedicamentoConfiguration : IEntityTypeConfiguration<Medicamento>
    {
        public void Configure(EntityTypeBuilder<Medicamento> builder)
        {
            builder.ToTable("Medicamento");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(m => m.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del medicamento")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(m => m.Precio)
                .IsRequired()
                .HasColumnName("Precio")
                .HasComment("Precio del medicamento")
                .HasColumnType("decimal(12,2)");

            builder.Property(m => m.Stock)
                .IsRequired()
                .HasColumnName("Stock")
                .HasComment("Stock del medicamento")
                .HasColumnType("int")
                .HasMaxLength(999);

            builder.Property(m => m.FechaVencimiento)
                .IsRequired()
                .HasColumnName("FechaVencimiento")
                .HasComment("Fecha de vencimiento del medicamento")
                .HasColumnType("datetime");

            builder.Property(m => m.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion del medicamento")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(m => m.Disponibilidad)
                .IsRequired()
                .HasColumnName("Disponibilidad")
                .HasComment("Disponibilidad del medicamento");

            builder.HasOne(p => p.Categoria)
                .WithMany(p => p.Medicamentos)
                .HasForeignKey(p => p.IdCatFK);

            builder.HasOne(p => p.Marca)
                .WithMany(p => p.Medicamentos)
                .HasForeignKey(p => p.IdMarFK);

            builder.HasOne(p => p.TipoPresentacion)
                .WithMany(p => p.Medicamentos)
                .HasForeignKey(p => p.IdTipoPreFK);
        }
    }
}