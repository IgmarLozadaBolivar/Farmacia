using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("Marca");

            builder.HasKey(m => m.Id);

            builder.Property(m => m.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(m => m.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre de la marca")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);
        }
    }
}