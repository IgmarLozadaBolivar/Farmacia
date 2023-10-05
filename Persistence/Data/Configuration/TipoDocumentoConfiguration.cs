using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            builder.ToTable("Tipo Documento");

            builder.HasKey(td => td.Id);

            builder.Property(td => td.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(td => td.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del tipo de documento")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(td => td.Abreviatura)
                .IsRequired()
                .HasColumnName("Abreviatura")
                .HasComment("Abreviatura del tipo de documento")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(td => td.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion del tipo de documento")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100); 
        }
    }
}