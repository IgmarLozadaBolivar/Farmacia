using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoPresentacionConfiguration : IEntityTypeConfiguration<TipoPresentacion>
    {
        public void Configure(EntityTypeBuilder<TipoPresentacion> builder)
        {
            builder.ToTable("Tipo Presentacion");

            builder.HasKey(tp => tp.Id);

            builder.Property(tp => tp.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(tp => tp.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del tipo de presentacion del medicamento")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);
        }
    }
}