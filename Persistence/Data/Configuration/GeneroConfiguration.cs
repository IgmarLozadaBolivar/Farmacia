using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Genero");

            builder.HasKey(g => g.Id);

            builder.Property(g => g.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(g => g.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del genero")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(g => g.Abreviatura)
                .IsRequired()
                .HasColumnName("Abreviatura")
                .HasComment("Abreviatura del genero")
                .HasColumnType("varchar(3)")
                .HasMaxLength(3);

            builder.Property(g => g.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion del genero")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);
        }
    }
}