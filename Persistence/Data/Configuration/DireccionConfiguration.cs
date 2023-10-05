using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DireccionConfiguration : IEntityTypeConfiguration<Direccion>
    {
        public void Configure(EntityTypeBuilder<Direccion> builder)
        {
            builder.ToTable("Direccion");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(d => d.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion de la direccion")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.HasOne(p => p.Ciudad)
                .WithMany(p => p.Direcciones)
                .HasForeignKey(p => p.IdCiuFK);
        }
    }
}