using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoContactoConfiguration : IEntityTypeConfiguration<TipoContacto>
    {
        public void Configure(EntityTypeBuilder<TipoContacto> builder)
        {
            builder.ToTable("Tipo Contacto");

            builder.HasKey(tc => tc.Id);

            builder.Property(tc => tc.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(tc => tc.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del tipo de contacto")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);
        }
    }
}