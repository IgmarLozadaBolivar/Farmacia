using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder)
        {
            builder.ToTable("Pais");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(p => p.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del pais")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(p => p.Capital)
                .IsRequired()
                .HasColumnName("Capital")
                .HasComment("Capital del pais")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);
        }
    }
}